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
    class Stone_Block : Block
    {
        public Stone_Block(Vector3 position = new Vector3()) : base(position)
        {
            topColor = Color.FromArgb(139, 141, 122);
            sideColor = Color.FromArgb(139, 141, 122);
            bottomColor = Color.FromArgb(139, 141, 122);
        }
    }
}
