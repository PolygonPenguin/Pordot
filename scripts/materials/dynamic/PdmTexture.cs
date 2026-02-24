using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scripts.materials.dynamic
{
    public class PdmTexture
    {
        public String name;
        public bool isConstant;
        public PdmFunction[] instructions;
    }
}