using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainGame.components
{
    class Block
    {
        public Vector3 position;
        private float blockSize;
        public Color topColor, sideColor, bottomColor;


        public Block(Vector3 position = new Vector3())
        {
            if(position.Length > 0)
            {
                this.position = position;
            }
            blockSize = 0.5f;
            topColor = Color.FromArgb(255, 0, 255);
            sideColor = Color.FromArgb(255, 0, 255);
            bottomColor = Color.FromArgb(255, 0, 255);
        }

        public void Display()
        {
            GL.Vertex3(this.position.X - blockSize, this.position.Y - blockSize, this.position.Z + blockSize);
        }
    }
}
