using Godot;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace pordot.scripts.materials.dynamic
{
    public class Value
    {
        public string name;
        private DynamicMaterial material;
        public enum DataType
        {
            Boolean,
            Number,
            Vector2,
            Vector3,
            Color,
            BooleanSampler,
            NumberSampler,
            Vector2Sampler,
            Vector3Sampler,
            ColorSampler,
            Texture,
            Unknown
        }
        public DataType dataType;
        public bool isConstant;
        public bool isVariable;
        public FunctionCall[] instructions;
        public bool boolean;
        public float number;
        public Vector2 vector2;
        public Vector3 vector3;
        public Color color;
        public bool[][] booleanSampler;
        public float[][] numberSampler;
        public Vector2[][] vector2Sampler;
        public Vector3[][] vector3Sampler;
        public Color[][] colorSampler;
        public Texture texture;
        public Value(bool boolean, string name, DynamicMaterial material)
        {
            dataType = DataType.Boolean;
            this.boolean = boolean;
            this.name = material.uidGenerator.getUid(name);
            this.material = material;
            isConstant = true;
        }
        public Value(float number, string name, DynamicMaterial material)
        {
            dataType = DataType.Number;
            this.number = number;
            this.name = material.uidGenerator.getUid(name);
            this.material = material;
            isConstant = true;
        }
        public Value(Vector2 vector2, string name, DynamicMaterial material)
        {
            dataType = DataType.Vector2;
            this.vector2 = vector2;
            this.name = material.uidGenerator.getUid(name);
            this.material = material;
            isConstant = true;
        }
        public Value(Vector3 vector3, string name, DynamicMaterial material)
        {
            dataType = DataType.Vector3;
            this.vector3 = vector3;
            this.name = material.uidGenerator.getUid(name);
            this.material = material;
            isConstant = true;
        }
        public Value(Color color, string name, DynamicMaterial material)
        {
            dataType = DataType.Color;
            this.color = color;
            this.name = material.uidGenerator.getUid(name);
            this.material = material;
            isConstant = true;
        }
        public Value(bool[][] booleanSampler, string name, DynamicMaterial material)
        {
            dataType = DataType.BooleanSampler;
            this.booleanSampler = booleanSampler;
            this.name = material.uidGenerator.getUid(name);
            this.material = material;
            isConstant = true;
        }
        public Value(float[][] numberSampler, string name, DynamicMaterial material)
        {
            dataType = DataType.NumberSampler;
            this.numberSampler = numberSampler;
            this.name = material.uidGenerator.getUid(name);
            this.material = material;
            isConstant = true;
        }
        public Value(Vector2[][] vector2Sampler, string name, DynamicMaterial material)
        {
            dataType = DataType.Vector2Sampler;
            this.vector2Sampler = vector2Sampler;
            this.name = material.uidGenerator.getUid(name);
            this.material = material;
            isConstant = true;
        }
        public Value(Vector3[][] vector3Sampler, string name, DynamicMaterial material)
        {
            dataType = DataType.Vector3Sampler;
            this.vector3Sampler = vector3Sampler;
            this.name = material.uidGenerator.getUid(name);
            this.material = material;
            isConstant = true;
        }
        public Value(Color[][] colorSampler, string name, DynamicMaterial material)
        {
            dataType = DataType.ColorSampler;
            this.colorSampler = colorSampler;
            this.name = material.uidGenerator.getUid(name);
            this.material = material;
            isConstant = true;
        }
        public Value(Texture texture, string name, DynamicMaterial material)
        {
            dataType = DataType.Texture;
            this.texture = texture;
            this.name = material.uidGenerator.getUid(name);
            this.material = material;
            isConstant = true;
        }
        public Value(bool boolean, DynamicMaterial material)
        {
            dataType = DataType.Boolean;
            this.boolean = boolean;
            this.name = material.uidGenerator.getUid();
            this.material = material;
            isConstant = true;
        }
        public Value(float number, DynamicMaterial material)
        {
            dataType = DataType.Number;
            this.number = number;
            this.name = material.uidGenerator.getUid();
            this.material = material;
            isConstant = true;
        }
        public Value(Vector2 vector2, DynamicMaterial material)
        {
            dataType = DataType.Vector2;
            this.vector2 = vector2;
            this.name = material.uidGenerator.getUid();
            this.material = material;
            isConstant = true;
        }
        public Value(Vector3 vector3, DynamicMaterial material)
        {
            dataType = DataType.Vector3;
            this.vector3 = vector3;
            this.name = material.uidGenerator.getUid();
            this.material = material;
            isConstant = true;
        }
        public Value(Color color, DynamicMaterial material)
        {
            dataType = DataType.Color;
            this.color = color;
            this.name = material.uidGenerator.getUid();
            this.material = material;
            isConstant = true;
        }
        public Value(bool[][] booleanSampler, DynamicMaterial material)
        {
            dataType = DataType.BooleanSampler;
            this.booleanSampler = booleanSampler;
            this.name = material.uidGenerator.getUid();
            this.material = material;
            isConstant = true;
        }
        public Value(float[][] numberSampler, DynamicMaterial material)
        {
            dataType = DataType.NumberSampler;
            this.numberSampler = numberSampler;
            this.name = material.uidGenerator.getUid();
            this.material = material;
            isConstant = true;
        }
        public Value(Vector2[][] vector2Sampler, DynamicMaterial material)
        {
            dataType = DataType.Vector2Sampler;
            this.vector2Sampler = vector2Sampler;
            this.name = material.uidGenerator.getUid();
            this.material = material;
            isConstant = true;
        }
        public Value(Vector3[][] vector3Sampler, DynamicMaterial material)
        {
            dataType = DataType.Vector3Sampler;
            this.vector3Sampler = vector3Sampler;
            this.name = material.uidGenerator.getUid();
            this.material = material;
            isConstant = true;
        }
        public Value(Color[][] colorSampler, DynamicMaterial material)
        {
            dataType = DataType.ColorSampler;
            this.colorSampler = colorSampler;
            this.name = material.uidGenerator.getUid();
            this.material = material;
            isConstant = true;
        }
        public Value(Texture texture, DynamicMaterial material)
        {
            dataType = DataType.Texture;
            this.texture = texture;
            this.name = material.uidGenerator.getUid();
            this.material = material;
            isConstant = true;
        }
        public Value(DataType dataType, FunctionCall[] instructions, string name, DynamicMaterial material)
        {
            this.dataType = dataType;
            this.instructions = instructions;
            this.name = material.uidGenerator.getUid(name);
            this.material = material;
            isConstant = false;
        }
        public Value(DataType dataType, FunctionCall[] instructions, DynamicMaterial material)
        {
            this.dataType = dataType;
            this.instructions = instructions;
            this.name = material.uidGenerator.getUid();
            this.material = material;
            isConstant = false;
        }
        public Value(DataType dataType, string varName, DynamicMaterial material)
        {
            this.dataType = dataType;
            this.name = material.uidGenerator.getUid(varName);
            this.material = material;
            isConstant = false;
            isVariable=true;
        }
        public Value(DynamicMaterial material)
        {
            dataType = DataType.Unknown;
            this.name = material.uidGenerator.getUid();
            this.material = material;
            isConstant = true;
        }
        public static Value parse(string code, DynamicMaterial material)
        {
            if (code.IsValidFloat())
            {
                return new Value(float.Parse(code), material); 
            }
            if (code.StartsWith("#"))
            {
                return new Value(Color.FromHtml(code.Substring(1)), material); 
            }
            if (code == "true")
            {
                return new Value(true, material); 
            }
            if (code == "false")
            {
                return new Value(false, material); 
            }
            for (int i = 0; i<material.variables.Count; i++)
            {
                if (material.variables[i].name == material.uidGenerator.getUid(code))
                {
                    return material.variables[i];
                }
            }
            return new Value(material);
        }
        public static DataType stringToDataType(string type)
        {
            switch (type)
            {
                case "Boolean":
                return DataType.Boolean;
                case "Number":
                return DataType.Number;
                case "Vector2":
                return DataType.Vector2;
                case "Vector3":
                return DataType.Vector3;
                case "Color":
                return DataType.Color;
                case "BooleanSampler":
                return DataType.BooleanSampler;
                case "NumberSampler":
                return DataType.NumberSampler;
                case "Vector2Sampler":
                return DataType.Vector2Sampler;
                case "Vector3Sampler":
                return DataType.Vector3Sampler;
                case "ColorSampler":
                return DataType.ColorSampler;
                case "Texture":
                return DataType.Texture;
            }
            return DataType.Unknown;
        }
        public static Value parse(string type, FunctionCall[] inner, DynamicMaterial material)
        {
            return new Value(stringToDataType(type), inner, material);
        }
        public static int getMatchingTypes(Value[] values, DataType[][] typeOptions)
        {
            for (int i = 0; i<typeOptions.Length; i++)
            {
                if (typeOptions[i].Length == values.Length)
                {
                    bool valid = true;
                    for (int j =0; j<typeOptions[i].Length; j++)
                    {
                        if (typeOptions[i][j]!=values[j].dataType)
                        {
                            valid = false;
                            break;
                        }
                    }
                    if (valid)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public string toShaderCode()
        {
            if (dataType==DataType.Unknown)
            {
                return "";
            }
            if (isConstant)
            {
                if (dataType == DataType.Boolean)
                {
                    return boolean.ToString();
                }
                if (dataType == DataType.Number)
                {
                    return number.ToString();
                }
                if (dataType == DataType.Color)
                {
                    return "vec4("+color.R.ToString()+", "+color.G.ToString()+", "+color.B.ToString()+", "+color.A.ToString()+")";
                }
            } else
            {
                if (dataType==DataType.Boolean || dataType==DataType.Number || dataType==DataType.Vector2 || dataType==DataType.Vector3 || dataType==DataType.Color)
                {
                    return name+"()";
                }
                if (dataType==DataType.Texture)
                {
                    return "texture("+name+", uv)";
                }
                return name+"(uv)";
            }
            return "";
        }
    }

}