using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursionsTree
{
    public partial class Form1 : Form
    {
        private Pen pen;

        public Form1()
        {
            
            InitializeComponent();

            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                bool first = false;
                pen = new Pen(new Brush(Color.Black));
                pen.Color = Color.Black;
                if (first)
                {
                    first = false;
                }
                // System.Threading.Thread.Sleep(5000);
                //g.TranslateTransform(new x , new y);


            }
        }
    }
}
