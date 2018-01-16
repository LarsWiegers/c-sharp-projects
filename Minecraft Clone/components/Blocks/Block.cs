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
        private IDictionary<string, bool> VisibleFaces;

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
            GL.Begin(PrimitiveType.Quads);
            if (this.VisibleFaces["top"])
            {
                GL.Color3(topColor);
                this.DisplayTop();
            }
            if (this.VisibleFaces["left"])
            {
                GL.Color3(sideColor);
                this.DisplayLeft();
            }
            if (this.VisibleFaces["bottom"])
            {
                GL.Color3(bottomColor);
                this.DisplayBottom();
            }
            if (this.VisibleFaces["right"])
            {
                GL.Color3(sideColor);
                this.DisplayRight();
            }
            if (this.VisibleFaces["front"])
            {
                GL.Color3(sideColor);
                this.DisplayFront();
            }
            if (this.VisibleFaces["back"])
            {
                GL.Color3(sideColor);
                this.DisplayBack();
            }
            GL.End();
        }

        public IDictionary<string, bool> GetVisibileFaces()
        {
            return VisibleFaces;
        }
        public void SetVisibleFaces(IDictionary<string, bool> dict)
        {
            this.VisibleFaces = dict;
        }

        private void DisplayBack()
        {
            GL.Vertex3(this.position.X - blockSize, this.position.Y + blockSize, this.position.Z + blockSize);
            GL.Vertex3(this.position.X - blockSize, this.position.Y - blockSize, this.position.Z + blockSize);
            GL.Vertex3(this.position.X + blockSize, this.position.Y - blockSize, this.position.Z + blockSize);
            GL.Vertex3(this.position.X + blockSize, this.position.Y + blockSize, this.position.Z + blockSize); 
        }
        private void DisplayFront()
        {
            GL.Vertex3(this.position.X + blockSize, this.position.Y + blockSize, this.position.Z - blockSize);
            GL.Vertex3(this.position.X + blockSize, this.position.Y - blockSize, this.position.Z - blockSize);
            GL.Vertex3(this.position.X - blockSize, this.position.Y - blockSize, this.position.Z - blockSize);
            GL.Vertex3(this.position.X - blockSize, this.position.Y + blockSize, this.position.Z - blockSize);
        }
        private void DisplayRight()
        {
            GL.Vertex3(this.position.X - blockSize, this.position.Y + blockSize, this.position.Z - blockSize);
            GL.Vertex3(this.position.X - blockSize, this.position.Y - blockSize, this.position.Z - blockSize);
            GL.Vertex3(this.position.X - blockSize, this.position.Y - blockSize, this.position.Z + blockSize);
            GL.Vertex3(this.position.X - blockSize, this.position.Y + blockSize, this.position.Z + blockSize);
        }

        private void DisplayLeft()
        {
            GL.Vertex3(this.position.X + blockSize, this.position.Y + blockSize, this.position.Z + blockSize);
            GL.Vertex3(this.position.X + blockSize, this.position.Y - blockSize, this.position.Z + blockSize);
            GL.Vertex3(this.position.X + blockSize, this.position.Y - blockSize, this.position.Z - blockSize);
            GL.Vertex3(this.position.X + blockSize, this.position.Y + blockSize, this.position.Z - blockSize);
        }
        private void DisplayBottom()
        {
            GL.Vertex3(this.position.X - blockSize, this.position.Y - blockSize, this.position.Z - blockSize);
            GL.Vertex3(this.position.X + blockSize, this.position.Y - blockSize, this.position.Z - blockSize);
            GL.Vertex3(this.position.X + blockSize, this.position.Y - blockSize, this.position.Z + blockSize);
            GL.Vertex3(this.position.X - blockSize, this.position.Y - blockSize, this.position.Z + blockSize);
        }
        private void DisplayTop()
        {
            GL.Vertex3(this.position.X - blockSize, this.position.Y + blockSize, this.position.Z - blockSize);
            GL.Vertex3(this.position.X - blockSize, this.position.Y + blockSize, this.position.Z + blockSize);
            GL.Vertex3(this.position.X + blockSize, this.position.Y + blockSize, this.position.Z + blockSize);
            GL.Vertex3(this.position.X + blockSize, this.position.Y + blockSize, this.position.Z - blockSize);
        }
    }
}
