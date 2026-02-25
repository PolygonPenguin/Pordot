using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pordot.scripts.materials.dynamic
{
    public class PdmColor
    {
        public bool isConstant;
		public PdmFunction[] instructions;
		public Color constant;

        public PdmColor(PdmFunction[] instructions)
        {
            this.instructions = instructions;
            isConstant=false;
        }
        public PdmColor(Color constant)
        {
            this.constant = constant;
            isConstant=true;
        }
    }
}