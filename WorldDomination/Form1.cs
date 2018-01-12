using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldDomination
{
    public partial class Form1 : Form
    {
        public List<WorldPixel> Grid;
        public int GRIDSIZE = 3;
        private SolidBrush brush;

        public Form1()
        {
            InitializeComponent();
            List<WorldPixel> Grid = new List<WorldPixel>();
            Color water = Color.Blue, land = Color.Green;
            Bitmap image = new Bitmap("C:\\Users\\Lars\\Pictures\\world_map.png");
            this.Grid = this.CreateGridBasedOn2ColorImage(Grid, GRIDSIZE, water,land,image);
             
        }
        private void DrawWorldMap()
        {
            Graphics graphics = this.CreateGraphics();
            brush = new SolidBrush(Color.Green);
            foreach (WorldPixel item in this.Grid)
            {
                if (item.isLand)
                {
                    brush.Color = Color.Green;
                    graphics.FillRectangle(brush, item.x * GRIDSIZE, item.y * GRIDSIZE, GRIDSIZE, GRIDSIZE);
                }else
                {
                    brush.Color = Color.Blue;
                    graphics.FillRectangle(brush, item.x * GRIDSIZE, item.y * GRIDSIZE, GRIDSIZE, GRIDSIZE);
                }
            }
        }

        private List<WorldPixel> CreateGridBasedOn2ColorImage(List<WorldPixel> grid, int GridSize, Color water, Color land, Bitmap bitmap)
        {
            for (int x = 0; x < (bitmap.Width); x++)
            {
                for (int y = 0; y < (bitmap.Height); y++)
                {

                    Color pixel = bitmap.GetPixel(x , y );
                    Boolean isLand = false;
                    if (pixel.B == 255)
                    {
                        isLand = false;
                    }else if(pixel.G == 255)
                    {
                        isLand = true;
                    }
                    grid.Add(new WorldPixel(x , y , isLand));
                }
            }   
            System.Diagnostics.Debug.WriteLine("Creating grid has been succesfully.");
            return grid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawWorldMap();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.GRIDSIZE += 1;
            DrawWorldMap();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.GRIDSIZE -= 1;
            DrawWorldMap();
        }
    }
}
