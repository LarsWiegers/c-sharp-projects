using FirstProjectOpenTK.components.Blocks;
using MainGame.components;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectOpenTK.components.World
{
    class World
    {
        Chunk[,] chunks = new Chunk[10, 10];
        int chunkSize = 16;
        List<Block> blocks;
        public World()
        {
            this.blocks = new List<Block>();
            Random random = new Random();
            FastNoise noise = new FastNoise(100);


            for (int x = 0; x <= chunks.GetLength(0) - 1; ++x)
            {
                for (int z = 0; z <= chunks.GetLength(1) - 1; ++z)
                {
                    int ChunkX = x * chunkSize;
                    int ChunkZ = z * chunkSize;
                    List<Block> blocks = GenerateBlocks(ChunkX, ChunkZ, noise);
                    this.blocks.AddRange(blocks);
                    chunks[x, z] = new Chunk(ChunkX, ChunkZ, blocks );
                }
            }
            blocks = GenerateBlockFaces(blocks);
            this.blocks = null;

        }

        private List<Block> GenerateBlockFaces(List<Block> blocks)
        {
            foreach(Block blockSelected in blocks)
            {
                Boolean top = true, left = true, right = true, front = true, back = true, bottom = true;
                foreach(Block block in blocks)
                { 
                    if(blockSelected.position.X == block.position.X - 1 && 
                        blockSelected.position.Y == block.position.Y &&
                        blockSelected.position.Z == block.position.Z  )
                    {
                        // if this block is to the right of it
                        left = false;
                    }

                    if (blockSelected.position.X == block.position.X + 1 &&
                        blockSelected.position.Y == block.position.Y &&
                        blockSelected.position.Z == block.position.Z)
                    {
                        // if this block is to the left of it
                        
                        right = false;
                    }

                    if (blockSelected.position.X == block.position.X  &&
                       blockSelected.position.Y == block.position.Y &&
                       blockSelected.position.Z == block.position.Z - 1)
                    {
                        // if this block is to the front of it
                        back = false;
                    }

                    if (blockSelected.position.X == block.position.X &&
                       blockSelected.position.Y == block.position.Y &&
                       blockSelected.position.Z == block.position.Z + 1)
                    {
                        // if this block is to the back of it
                        front = false;
                    }

                    if (blockSelected.position.X == block.position.X &&
                       blockSelected.position.Y == block.position.Y - 1 &&
                       blockSelected.position.Z == block.position.Z )
                    {
                        // if this block is to the front of it
                        bottom = false;
                    }

                    if (blockSelected.position.X == block.position.X &&
                       blockSelected.position.Y == block.position.Y + 1 &&
                       blockSelected.position.Z == block.position.Z)
                    {
                        // if this block is to the front of it
                        top = false;
                    }

                }
                IDictionary<string, Boolean> dict = new Dictionary<string, Boolean>
                {
                    ["top"] = top,
                    ["left"] = left,
                    ["right"] = right,
                    ["front"] = front,
                    ["back"] = back,
                    ["bottom"] = bottom
                };
                blockSelected.SetVisibleFaces(dict);
            }
            return blocks;
        }

        private List<Block> GenerateBlocks(int BeginX , int BeginZ, FastNoise noise)
        {
            List<Block> blocks = new List<Block>();

            for (int x = 0; x <= chunkSize; x++)
            {
                for (int z = 0; z <= chunkSize; z++)
                {
                    double y = Math.Floor(ConvertRange(0, 1, 0, 100, noise.GetPerlin(x + BeginX, 0 , z + BeginZ)));
                   
                    blocks.Add(new Grass_Block(new Vector3(x + BeginX, (int)y, z + BeginZ)));
                }
            }
            return blocks;
        }
        public static float ConvertRange(
               int originalStart, int originalEnd, // original range
               int newStart, int newEnd, // desired range
               float value) // value to convert
        {
            double scale = (double)(newEnd - newStart) / (originalEnd - originalStart);
            return (float)(newStart + ((value - originalStart) * scale));
        }

        public void Display()
        {
            foreach (Chunk chunk in chunks)
            {
                chunk.DisplayChunk();
            }
        }
    }

}
