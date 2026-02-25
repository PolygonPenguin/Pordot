using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pordot.scripts.materials.dynamic
{
    public class PdmVector2
    {
        public bool isConstant;
		public PdmFunction[] instructions;
		public Vector2 constant;

        public PdmVector2(PdmFunction[] instructions)
        {
            this.instructions = instructions;
            isConstant=false;
        }
        public PdmVector2(Vector2 constant)
        {
            this.constant = constant;
            isConstant=true;
        }
    }
}