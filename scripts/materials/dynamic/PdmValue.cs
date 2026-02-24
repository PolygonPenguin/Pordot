using Godot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace pordot.scripts.materials.dynamic
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
        public string name;
        public DataType type;
        private PdmTexture texture;
        private PdmNumber number;
        private PdmColor color;
        private PdmVector2 vector2;
        private PdmVector3 vector3;
        private PdmBoolean boolean;
        public PdmValue(string name, PdmTexture texture) {
            this.name = UidGenerator.getUid(name);
            this.texture = texture;
            this.type = DataType.Texture;
        }
        public PdmValue(string name, PdmNumber number) {
            this.name = UidGenerator.getUid(name);
            this.number = number;
            this.type = DataType.Number;
        }
        public PdmValue(string name, PdmColor color) {
            this.name = UidGenerator.getUid(name);
            this.color = color;
            this.type = DataType.Color;
        }
        public PdmValue(string name, PdmVector2 vector2) {
            this.name = UidGenerator.getUid(name);
            this.vector2 = vector2;
            this.type = DataType.Vector2;
        }
        public PdmValue(string name, PdmVector3 vector3) {
            this.name = UidGenerator.getUid(name);
            this.vector3 = vector3;
            this.type = DataType.Vector3;
        }
        public PdmValue(string name, PdmBoolean boolean) {
            this.name = UidGenerator.getUid(name);
            this.boolean = boolean;
            this.type = DataType.Boolean;
        }
        public PdmValue(PdmTexture texture) {
            this.name = UidGenerator.getUid();
            this.texture = texture;
            this.type = DataType.Texture;
        }
        public PdmValue(PdmNumber number) {
            this.name = UidGenerator.getUid();
            this.number = number;
            this.type = DataType.Number;
        }
        public PdmValue(PdmColor color) {
            this.name = UidGenerator.getUid();
            this.color = color;
            this.type = DataType.Color;
        }
        public PdmValue(PdmVector2 vector2) {
            this.name = UidGenerator.getUid();
            this.vector2 = vector2;
            this.type = DataType.Vector2;
        }
        public PdmValue(PdmVector3 vector3) {
            this.name = UidGenerator.getUid();
            this.vector3 = vector3;
            this.type = DataType.Vector3;
        }
        public PdmValue(PdmBoolean boolean) {
            this.name = UidGenerator.getUid();
            this.boolean = boolean;
            this.type = DataType.Boolean;
        }
        public string getInlineShaderCode()
        {
            switch (type)
            {
                case DataType.Texture:
                    if (texture.isConstant)
                    {
                        return "texture(uv, "+name+")";
                    } else
                    {
                        return name+"(uv)";
                    }
                case DataType.Number:
                break;
                case DataType.Color:
                break;
                case DataType.Vector2:
                break;
                case DataType.Vector3:
                break;
                case DataType.Boolean:
                break; 
            }
            return "";
            
        }
    }

}