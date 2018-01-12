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
        public Block()
        {
            this.position = new Vector3(1,1,1);
        }

        public void Display()
        {
            //draw a primitive
            GL.Begin(PrimitiveType.Triangles);
            //color is active as long as no new color is set
            GL.Color3(1.0f, 1.0f, 0.0f); GL.Vertex3(-1.0f, -1.0f, 4.0f);
            GL.Color3(1.0f, 0.0f, 0.0f); GL.Vertex3(1.0f, -1.0f, 4.0f);
            GL.Color3(0.2f, 0.9f, 1.0f); GL.Vertex3(0.0f, 1.0f, 4.0f);
            GL.End();
        }
    }
}
