using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pordot.scripts.materials.dynamic
{
    public class UidGenerator
    {
        private static Dictionary<string, string> mappings = new Dictionary<string, string>();
        private static List<string> used = new List<string>();
        private static RandomNumberGenerator rand = new RandomNumberGenerator();
        private const string ALLOWED_CHARS = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string getUid()
        {
            string output = "";
            for (int i = 0; i < rand.RandiRange(0, 11); i++)
            {
                output += ALLOWED_CHARS[rand.RandiRange(0, ALLOWED_CHARS.Length)];
            }
            if (used.Contains(output))
            {
                return getUid();
            }
            used.Add(output);
            return output;
        }
        public static string getUid(string name)
        {
            if (mappings.ContainsKey(name))
            {
                return mappings[name];
            } else
            {
                string output = getUid();
                mappings[name] = output;
                return output;
            }
            
        }
        public static void clear()
        {
            mappings.Clear();
            used.Clear();
        }
    }
}