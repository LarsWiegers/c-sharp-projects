using MainGame.components;
using System;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace FirstProjectOpenTK.components
{
    class Chunk
    {
        public List<Block> blocks;
        public int chuncksize = 16;
        private int beginX;
        private int beginZ;

        public Chunk(int beginX , int beginZ,List<Block> blocks)
        {
            this.beginX = beginX;
            this.beginZ = beginZ;
            this.blocks = blocks;
        }

        public void DisplayChunk()
        {
            GL.Begin(PrimitiveType.TriangleStrip);
            foreach (Block block in blocks)
            {
                block.Display();
            }
            GL.End();
        } 

    }

}
