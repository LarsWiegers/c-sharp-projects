using MainGame.components;
using System;
using System.Collections.Generic;
using OpenTK;
using FirstProjectOpenTK.components.Blocks;

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
            foreach (Block block in blocks)
            {
                block.Display();
            }
        } 

    }

}
