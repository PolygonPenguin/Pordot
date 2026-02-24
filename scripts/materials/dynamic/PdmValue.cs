using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scripts.materials.dynamic
{
    public class PdmValue
    {
        public enum DataType {
            Texture,
            Number,
            Color,
            Vector2,
            Vector3,
            Boolean
        }
        public DataType type;
        
    }
}