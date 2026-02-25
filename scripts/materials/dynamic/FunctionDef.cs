using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pordot.scripts.materials.dynamic
{
    public class FunctionDef
    {
        public enum Function
        {
            Add,
            Subtract,
            Multiply,
            Divide,
            Mod,
            Set,
            Pow,
            Translate,
            Scale,
            Normal,
            Contrast,
            Abs,
            Noise,
            CellNoise,
            SetRed,
            SetGreen,
            SetBlue,
            SetAlpha,
            Round,
            Invert,
            And,
            Or,
            Not,
            Xor,
            IfElse,
            Unknown
        }
        public static Function getFunction(string name)
        {
            switch (name)
            {
                case "add":
                return Function.Add;
                case "subtract":
                return Function.Subtract;
                case "multiply":
                return Function.Multiply;
                case "divide":
                return Function.Divide;
                case "mod":
                return Function.Mod;
                case "set":
                return Function.Set;
                case "pow":
                return Function.Pow;
                case "translate":
                return Function.Translate;
                case "scale":
                return Function.Scale;
                case "normal":
                return Function.Normal;
                case "contrast":
                return Function.Contrast;
                case "abs":
                return Function.Abs;
                case "noise":
                return Function.Noise;
                case "cellNoise":
                return Function.CellNoise;
                case "setRed":
                return Function.SetRed;
                case "setGreen":
                return Function.SetGreen;
                case "setBlue":
                return Function.SetBlue;
                case "setAlpha":
                return Function.SetAlpha;
                case "round":
                return Function.Round;
                case "invert":
                return Function.Invert;
                case "and":
                return Function.And;
                case "or":
                return Function.Or;
                case "not":
                return Function.Not;
                case "xor":
                return Function.Xor;
                case "ifElse":
                return Function.IfElse;
                default:
                return Function.Unknown;
            }
        }
        public static string getShaderCode(Function function, PdmValue[] parameters)
        {
            switch (function)
            {
                case (Function.Add):
                    if (parameters.Length == 1 && parameters[0].type == PdmValue.DataType.Number)
                    {
                        return outp
                    }
                    break;
            }
        }
    }
}