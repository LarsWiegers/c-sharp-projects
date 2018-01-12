using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic01
{
    public partial class Form1 : Form
    {
        private int GRIDSIZE = 10;
        private Point[,] Grid = new Point[10000, 10000];
        public Form1()
        {
            InitializeComponent();
           this.Grid = createGrid ( this.Grid );
        }

        private Point[,] createGrid(Point[,] grid)
        {
            for (int x = 0; x < (this.Width + this.GRIDSIZE); x = x + this.GRIDSIZE)
            {
                for (int y = 0; y < (this.Height + this.GRIDSIZE); y = y + this.GRIDSIZE)
                {
                    // Add grid 2d array
                    grid[x / this.GRIDSIZE, y / this.GRIDSIZE] = new Point(x / this.GRIDSIZE, y / this.GRIDSIZE);
                }
            }
            Debug.WriteLine("Creating grid has been succesfully.");
            return grid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            int highestXinGrid = 0, highestYinGrid = 0;
            foreach(Point item in this.Grid)
            {
                if (highestXinGrid < item.X) {
                    highestXinGrid = item.X;
                }
                if (highestYinGrid < item.Y)
                {
                    highestYinGrid = item.Y;
                }
            }
            for (int x = 0; x < highestXinGrid; x++)
            {
                for (int y = 0; y < highestYinGrid; y++)
                {
                    // Display Grid
                    graphics.DrawRectangle(System.Drawing.Pens.Black, x * this.GRIDSIZE, y * this.GRIDSIZE, this.GRIDSIZE, this.GRIDSIZE);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
