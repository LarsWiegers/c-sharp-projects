using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldDomination
{
    public class WorldPixel
    {
        public int x;
        public Boolean isLand;
        public int y;

        public WorldPixel(int x , int y, Boolean isLand)
        {
            this.x = x;
            this.y = y;
            this.isLand = isLand;
        }

        public int Y { get => y; set => y = value; }
        public int X { get => x; set => x = value; }

        public override String ToString()
        {
            return ("X = " + this.x + " y =  " + this.y + "  is land = " + this.isLand);
        }
    }
}
