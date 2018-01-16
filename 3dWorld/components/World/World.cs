
using MainGame.components;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;

namespace FirstProjectOpenTK.components.World
{
    class World
    {
        Chunk[,] chunks = new Chunk[20 , 20];
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
            this.blocks = null;

        }

        private List<Block> GenerateBlocks(int BeginX , int BeginZ, FastNoise noise)
        {
            List<Block> blocks = new List<Block>();

            for (int x = 0; x <= chunkSize; x ++)
            {
                for (int z = 0; z <= chunkSize; z++)
                {
                    double y = Math.Floor(ConvertRange(0, 1, 0, 100, noise.GetPerlin(x + BeginX, 0 , z + BeginZ)));
                   
                    blocks.Add(new Block(new Vector3(x + BeginX, (int)y, z + BeginZ)));
                    blocks.Add(new Block(new Vector3(x + BeginX, (int)y, z + 1 + BeginZ)));

                    blocks.Add(new Block(new Vector3(x + 1 + BeginX, (int)y, z + BeginZ)));
                    blocks.Add(new Block(new Vector3(x + 1 + BeginX, (int)y, z + 1 + BeginZ)));
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
        public void DisplayTest(List<Block> blocks)
        {
            GL.Begin(PrimitiveType.TriangleStripAdjacency);
            foreach (Block block in blocks)
            {
                block.Display();
            }
            GL.End();
        }
    }

}
