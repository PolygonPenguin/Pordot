using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Godot;

namespace pordot.scripts.materials.dynamic
{
    public class Parser
    {
        public class Part
        {
            public bool hasCode = false;
            public bool hasList = false;
            public string code;
            public Part[] inside;
            public Part(string code)
            {
                hasCode = false;
                this.code = code;
            }
            public Part(Part[] inside)
            {
                hasList = true;
                this.inside = inside;
            }
            public Part(string code, Part[] inside)
            {
                hasCode = true;
                hasList = true;
                this.code = code;
                this.inside = inside;
            }
        }
        private class ParsePartOutput {
            public string code;
            public List<FunctionCall> parts;
            public ParsePartOutput(string code, List<FunctionCall> parts)
            {
                this.code = code;
                this.parts = parts;
            }
        }
        public static DynamicMaterial parse(string code)
        {
            DynamicMaterial material = new DynamicMaterial();
            string current = "";
            string name = "";
            string type;
            for (int i =0; i<code.Length; i++)
            {
                string character = code.Substr(0, 1);
                code = code.Substring(1);
                if (character==":")
                {
                    name = current;
                    current = "";
                } else if (character=="{")
                {
                    type = current;
                    ParsePartOutput content = parsePart(code, material);
                    code = content.code;
                    if (name.StartsWith("!"))
                    {
                        name = name.Substring(1);
                        material.outputs[name] = material.uidGenerator.getUid(name);
                    }
                    Value var = new Value(Value.stringToDataType(type), content.parts.ToArray(), name, material);
                    material.variables.Add(var);
                    current = "";
                    name = "";
                } else if (character==";")
                {
                    type = current;
                    if (name.StartsWith(">"))
                    {
                        name = name.Substring(1);
                        material.uidGenerator.lockUid(name);
                        material.uniforms.Add(new DynamicMaterial.Uniform(name, Value.stringToDataType(type)));
                    }
                    
                    current = "";
                    name = "";
                }
                current+=character;
            }
            return material;
        }
        private static ParsePartOutput parsePart(string code, DynamicMaterial material)
        {
            List<FunctionCall> functions = new List<FunctionCall>();
            string currentPart = "";
            List<FunctionCall> list = null;
            string function = "";
            List<Value> parameters = new List<Value>();
            for (int i = 0; i<code.Length; i++)
            {
                string character = code.Substr(0, 1);
                code = code.Substring(1);
                if (character == "}")
                {
                    return new ParsePartOutput(code, functions);
                }
                    
                if (character == ";" || character == ","){
                    if (list is null)
                    {
                        parameters.Add(Value.parse(currentPart, material));
                        
                    } else
                    {
                        Value param = Value.parse(currentPart, list.ToArray(), material);
                        material.variables.Add(param);
                        parameters.Add(param);
                        list = null;
                    }
                    currentPart = "";
                }
                if (character == ";")
                {
                    functions.Add(new FunctionCall(function, parameters.ToArray(), material));
                    function = "";
                    parameters = new List<Value>();
                } else if (character == ":")
                {
                    function = currentPart;
                    currentPart = "";
                }
                else if (character == "{")
                {
                    ParsePartOutput output = parsePart(code, material);
                    code = output.code;
                    list = output.parts;
                }
            }
            return new ParsePartOutput(code, functions);
        }
    }
}