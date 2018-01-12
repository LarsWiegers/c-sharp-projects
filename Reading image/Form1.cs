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

namespace Reading_image
{
    
    public partial class Form1 : Form
    {
        public int r, g, b;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap("C:\\Users\\Lars\\Pictures\\lars.jpg");
            picture.Image = image;

            for(int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                   Color pixel = image.GetPixel(x, y);
                   r += pixel.R;
                   g += pixel.G;
                   b += pixel.B;
                }
            }
        }
        public void Picture_Click(object sender, EventArgs e)
        {
            int total = r + g + b;
            // deel gedeelt door geheel * 100
            Debug.WriteLine("rood " + r);
            Debug.WriteLine("Totaal " + total);
            double procentageR = (double) r / total;
            double procentageG = (double) g / total;
            double procentageB = (double) b / total;
            Debug.WriteLine("Red : " +
                procentageR.ToString("0.0%") +
                " Green : " + procentageG.ToString("0.0%") + 
                " Blue : " + procentageB.ToString("0.0%")
                );
            Debug.WriteLine("Red : " + r + " " + "Green : " + g + " " + "Blue : " + b );
        }
    }
}
