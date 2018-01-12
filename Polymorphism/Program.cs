using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Polygon{
        public virtual void Draw()
        {
            Console.WriteLine("Polygon : Drawing!");
        }

    }
    class Rectangle: Polygon
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing : Triangle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
