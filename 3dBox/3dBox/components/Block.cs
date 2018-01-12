using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainGame.components
{
    class Block
    {
        Vector3 position;
        private Vector3 color;

        public Block()
        {
            position = new Vector3(0f,0f,0f);
            color = new Vector3(0f, 1f, 0f);
        }

        public void Display()
        {
            //face 1
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(color);
            GL.Vertex3(this.position.X + 1.0f , this.position.Y + 1.0f, this.position.Z - 1.0f);
            GL.Vertex3(this.position.X + 1.0f , this.position.Y - 1.0f, this.position.Z - 1.0f);
            GL.Vertex3(this.position.X - 1.0f , this.position.Y - 1.0f, this.position.Z - 1.0f);
            GL.Vertex3(this.position.X - 1.0f , this.position.Y + 1.0f, this.position.Z - 1.0f);
            GL.End();

            //face 2
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(color);
            GL.Vertex3(this.position.X - 1.0f, this.position.Y - 1.0f, this.position.Z - 1.0f);
            GL.Vertex3(this.position.X + 1.0f, this.position.Y - 1.0f, this.position.Z - 1.0f);
            GL.Vertex3(this.position.X + 1.0f, this.position.Y - 1.0f, this.position.Z + 1.0f);
            GL.Vertex3(this.position.X - 1.0f, this.position.Y - 1.0f, this.position.Z + 1.0f);
            GL.End();

            //face 3
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(color);
            GL.Vertex3(this.position.X - 1.0f, this.position.Y + 1.0f, this.position.Z - 1.0f);
            GL.Vertex3(this.position.X - 1.0f, this.position.Y - 1.0f, this.position.Z - 1.0f);
            GL.Vertex3(this.position.X - 1.0f, this.position.Y - 1.0f, this.position.Z + 1.0f);
            GL.Vertex3(this.position.X - 1.0f, this.position.Y + 1.0f, this.position.Z + 1.0f);
            GL.End();

            //face 4
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(color);
            GL.Vertex3(this.position.X + 1.0f, this.position.Y + 1.0f, this.position.Z + 1.0f);
            GL.Vertex3(this.position.X + 1.0f, this.position.Y - 1.0f, this.position.Z + 1.0f);
            GL.Vertex3(this.position.X + 1.0f, this.position.Y - 1.0f, this.position.Z - 1.0f);
            GL.Vertex3(this.position.X + 1.0f, this.position.Y + 1.0f, this.position.Z - 1.0f);
            GL.End();

            //face 5
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(color);
            GL.Vertex3(this.position.X - 1.0f, this.position.Y + 1.0f, this.position.Z - 1.0f);
            GL.Vertex3(this.position.X - 1.0f, this.position.Y + 1.0f, this.position.Z + 1.0f);
            GL.Vertex3(this.position.X + 1.0f, this.position.Y + 1.0f, this.position.Z + 1.0f);
            GL.Vertex3(this.position.X + 1.0f, this.position.Y + 1.0f, this.position.Z - 1.0f);
            GL.End();

            //face 6
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(color);
            GL.Vertex3(this.position.X - 1.0f, this.position.Y + 1.0f, this.position.Z + 1.0f);
            GL.Vertex3(this.position.X - 1.0f, this.position.Y - 1.0f, this.position.Z + 1.0f);
            GL.Vertex3(this.position.X + 1.0f, this.position.Y - 1.0f, this.position.Z + 1.0f);
            GL.Vertex3(this.position.X + 1.0f, this.position.Y + 1.0f, this.position.Z + 1.0f);
            GL.End();
        }
    }
}
