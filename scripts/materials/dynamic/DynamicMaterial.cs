using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pordot.scripts.materials.dynamic
{
    public class DynamicMaterial
    {
        public PdmValue[] nonConstants;

        static DynamicMaterial parsePdm(String pdmCode) {
            // TODO: Implement
            return new DynamicMaterial();
        }

        public string toShaderCode()
        {
            return """
                #[compute]
                #version 450
            """;
        }
    }
}