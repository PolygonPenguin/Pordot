using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pordot.scripts.materials.dynamic
{
    public class PdmNumber
    {
        public bool isConstant;
		public PdmFunction[] instructions;
		public float constant;

        public PdmNumber(PdmFunction[] instructions)
        {
            this.instructions = instructions;
            isConstant=false;
        }
        public PdmNumber(float constant)
        {
            this.constant = constant;
            isConstant=true;
        }
    }
}