using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pordot.scripts.materials.dynamic
{
    public class FunctionCall
    {
        public enum Function
        {
            Set,
            And,
            Or,
            Not,
            Xor,
            Add,
            Subtract,
            Multiply,
            Divide,
            Mod,
            Pow,
            Abs,
            Round,
            Translate,
            Scale,
            Contrast,
            Invert,
            NormalMap,
            Noise,
            CellNoise,
            X,
            Y,
            Z,
            Red,
            Green,
            Blue,
            Alpha
        }
        public Function function;
        public Value[] inputs;
        private DynamicMaterial material;
        public FunctionCall(Function function, Value[] inputs, DynamicMaterial material)
        {
            this.function=function;
            this.inputs = inputs;
            this.material = material;
        }
        public FunctionCall(string function, Value[] inputs, DynamicMaterial material)
        {
            switch (function)
            {
                case "set":
                this.function = Function.Set;
                break;
                case "and":
                this.function = Function.And;
                break;
                case "or":
                this.function = Function.Or;
                break;
                case "not":
                this.function = Function.Not;
                break;
                case "xor":
                this.function = Function.Xor;
                break;
                case "add":
                this.function = Function.Add;
                break;
                case "subtract":
                this.function = Function.Subtract;
                break;
                case "multiply":
                this.function = Function.Multiply;
                break;
                case "divide":
                this.function = Function.Divide;
                break;
                case "mod":
                this.function = Function.Mod;
                break;
                case "pow":
                this.function = Function.Pow;
                break;
                case "abs":
                this.function = Function.Abs;
                break;
                case "round":
                this.function = Function.Round;
                break;
                case "translate":
                this.function = Function.Translate;
                break;
                case "scale":
                this.function = Function.Scale;
                break;
                case "contrast":
                this.function = Function.Contrast;
                break;
                case "invert":
                this.function = Function.Invert;
                break;
                case "normalMap":
                this.function = Function.NormalMap;
                break;
                case "noise":
                this.function = Function.Noise;
                break;
                case "cellNoise":
                this.function = Function.CellNoise;
                break;
                case "x":
                this.function = Function.X;
                break;
                case "y":
                this.function = Function.Y;
                break;
                case "z":
                this.function = Function.Z;
                break;
                case "red":
                this.function = Function.Red;
                break;
                case "green":
                this.function = Function.Green;
                break;
                case "blue":
                this.function = Function.Blue;
                break;
                case "alpha":
                this.function = Function.Alpha;
                break;
            }
            this.inputs = inputs;
            this.material = material;
        }
        public void addLines(List<string> list)
        {
            switch (function)
            {
                case Function.Set:
                list.Add("output = "+inputs[0].toShaderCode());
                break;
                case Function.And:
                list.Add("output = output && "+inputs[0].toShaderCode());
                break;
                case Function.Or:
                list.Add("output = output || "+inputs[0].toShaderCode());
                break;
                case Function.Not:
                list.Add("output = !output");
                break;
                case Function.Xor:
                list.Add("output = output != "+inputs[0].toShaderCode());
                break;
                case Function.Add:
                list.Add("output = output + "+inputs[0].toShaderCode());
                break;
                case Function.Subtract:
                list.Add("output = output - "+inputs[0].toShaderCode());
                break;
                case Function.Multiply:
                list.Add("output = output * "+inputs[0].toShaderCode());
                break;
                case Function.Divide:
                list.Add("output = output / "+inputs[0].toShaderCode());
                break;
                case Function.Mod:
                list.Add("output = fmod(output, "+inputs[0].toShaderCode()+")");
                break;
                case Function.Pow:
                list.Add("output = pow(output, "+inputs[0].toShaderCode()+")");
                break;
                case Function.Abs:
                list.Add("output = abs(output)");
                break;
                case Function.Round:
                list.Add("output = round(output)");
                break;
                case Function.Translate:
                string store = material.uidGenerator.getUid();
                if (inputs.Length == 2)
                {
                    list.Insert(0, "vec2 "+store+" = vec2("+inputs[0].toShaderCode()+", "+inputs[1].toShaderCode()+")");
                } else
                {
                    list.Insert(0, "vec2 "+store+" = "+inputs[0].toShaderCode());
                }
                list.Insert(1, "vec2 uv -= "+store);
                list.Add("vec2 uv += "+store);
                break;
                case Function.Scale:
                store = material.uidGenerator.getUid();
                if (inputs.Length == 2)
                {
                    list.Insert(0, "vec2 "+store+" = vec2("+inputs[0].toShaderCode()+", "+inputs[1].toShaderCode()+")");
                } else
                {
                    list.Insert(0, "vec2 "+store+" = "+inputs[0].toShaderCode());
                }
                list.Insert(1, "vec2 uv /= "+store);
                list.Add("vec2 uv *= "+store);
                break;
                case Function.Contrast:
                list.Add("output = "+inputs[0].toShaderCode()+"*(output-0.5)+0.5");
                break;
                case Function.Invert:
                list.Add("output = 1.0-output");
                break;
                case Function.NormalMap:
                list.Add("output = toNormalMap(output)");
                break;
                case Function.Noise:
                list.Add("output = noise(uv, "+inputs[0].toShaderCode()+", "+inputs[1].toShaderCode()+")");
                break;
                case Function.CellNoise:
                list.Add("output = noise(uv, "+inputs[0].toShaderCode()+")");
                break;
                case Function.X:
                list.Add("output.x = "+inputs[0].toShaderCode());
                break;
                case Function.Y:
                list.Add("output.y = "+inputs[0].toShaderCode());
                break;
                case Function.Z:
                list.Add("output.Z = "+inputs[0].toShaderCode());
                break;
                case Function.Red:
                list.Add("output.r = "+inputs[0].toShaderCode());
                break;
                case Function.Green:
                list.Add("output.g = "+inputs[0].toShaderCode());
                break;
                case Function.Blue:
                list.Add("output.b = "+inputs[0].toShaderCode());
                break;
                case Function.Alpha:
                list.Add("output.a = "+inputs[0].toShaderCode());
                break;
            }
        }
    }
}