using MainGame.components;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectOpenTK.components.Blocks
{
    class Grass_Block : Block
    {
        public Grass_Block(Vector3 position = new Vector3()) : base(position)
        {
            topColor = Color.FromArgb(0, 120, 0);
            sideColor = Color.FromArgb(139, 69, 19);
            bottomColor = Color.FromArgb(79, 39, 09);
        }
    }
}
