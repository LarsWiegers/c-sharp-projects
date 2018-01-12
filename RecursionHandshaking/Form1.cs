using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursionHandshaking
{
    public partial class Form1 : Form
    {
        int handshakes = 0;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int people = int.Parse( textBox1.Text.ToString() );
            label1.Text = "het aantal hand keer schudden is " + CountHandshakes(people).ToString();

            label2.Text = "het aantal hand keer schudden is( berekend door for ) " + CountHandshakesViaFor(people).ToString();
            this.handshakes = 0;

        }

        private int CountHandshakes(int people)
        {
            
            if(people == 1)
            {
                return this.handshakes;
            }else
            {
                people = people - 1;
                this.handshakes = this.handshakes + people;

                return CountHandshakes(people);
            }
            
        }
        private int CountHandshakesViaFor(int people)
        {
            int handshakes = 0;
                for(int i = 1; i < people; i++)
            {
                handshakes = handshakes + i;
            }
            return handshakes;
        }
    }
}
