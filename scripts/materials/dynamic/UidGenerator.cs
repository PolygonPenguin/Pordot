using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pordot.scripts.materials.dynamic
{
	public class UidGenerator
	{
		private List<string> used = new List<string>();
		private RandomNumberGenerator rng = new RandomNumberGenerator();
		private Dictionary<string, string> mappings = new Dictionary<string, string>();
		private const string ALLOWED_CHARS = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
		public string getUid()
		{
			string output = "";
			int length = rng.RandiRange(0, 16);
			for (int i =0; i<length; i++)
			{
				output+=ALLOWED_CHARS[rng.RandiRange(0, ALLOWED_CHARS.Length)];
			}
			if (used.Contains(output))
			{
				return getUid();
			}
			used.Add(output);
			return output;
		}
		public string getUid(string name)
		{
			if (mappings.ContainsKey(name))
			{
				return mappings[name];
			}
			string output = getUid();
			mappings[name] = output;
			return output;
		}
		public void lockUid(string name)
		{
			mappings[name] = name;
			used.Add(name);
		}
	}
}
