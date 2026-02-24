using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pordot.scripts.materials.dynamic
{
	public class PdmTexture
	{
		public bool isConstant;
		public PdmFunction[] instructions;
		public ImageTexture constant;

		public PdmTexture(PdmFunction[] instructions) {
			this.instructions = instructions;
			this.isConstant = false;
		}
		public PdmTexture(ImageTexture constant) {
			this.constant = constant;
			this.isConstant = true;
		}
	}
}
