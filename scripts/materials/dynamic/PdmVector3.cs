using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Godot;

namespace pordot.scripts.materials.dynamic
{
    public class PdmVector3
    {
        public bool isConstant;
		public PdmFunction[] instructions;
		public Vector3 constant;

        public PdmVector3(PdmFunction[] instructions)
        {
            this.instructions = instructions;
            isConstant=false;
        }
        public PdmVector3(Vector3 constant)
        {
            this.constant = constant;
            isConstant=true;
        }
    }
}