using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace pordot.scripts.materials.dynamic
{
	public class DynamicMaterial
	{
		public class Uniform
		{
			public string name;
			public Value.DataType dataType;
			public Uniform(string name, Value.DataType dataType)
			{
				this.name = name;
				this.dataType = dataType;
			}
		}
		public UidGenerator uidGenerator = new UidGenerator();
		public List<Value> variables = new List<Value>();
		public List<Uniform> uniforms = new List<Uniform>();
		public List<Value> textures = new List<Value>();
		public Dictionary<string, string> outputs = new Dictionary<string, string>();
		public List<string> lines;
		public static DynamicMaterial parse(string code)
		{
			code = code.Replace(" ", "").Replace("\t", "").Replace("\n", "").Replace("+", "add: ").Replace("-", "subtract: ").Replace("*", "multiply: ").Replace("/", "divide: ");
			return Parser.parse(code);
		}
	}
}
