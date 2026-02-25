using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pordot.scripts.materials.dynamic
{
    public class PdmBoolean
    {
        public bool isConstant;
		public PdmFunction[] instructions;
		public bool constant;

        public PdmBoolean(PdmFunction[] instructions)
        {
            this.instructions = instructions;
            isConstant=false;
        }
        public PdmBoolean(bool constant)
        {
            this.constant = constant;
            isConstant=true;
        }
    }
}