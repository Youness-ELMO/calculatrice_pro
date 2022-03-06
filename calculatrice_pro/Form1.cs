using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatrice_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x;
        char o;
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text ="";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            x = int.Parse(textBox1.Text);
            textBox1.Text = "";
            o = '+';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            x = int.Parse(textBox1.Text);
            textBox1.Text = "";
            o = '-';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            x = int.Parse(textBox1.Text);
            textBox1.Text = "";
            o = '*';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = int.Parse(textBox1.Text);
            textBox1.Text = "";
            o = '/';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int y = int.Parse(textBox1.Text);
            if (o == '+')
            {
                textBox1.Text= ""+(x+y);
            }
            if (o == '-')
            {
                textBox1.Text = "" + (x - y);
            }
            if (o == '*')
            {
                textBox1.Text = "" + (x * y);
            }
            if (o == '/')
            {
                textBox1.Text = "" + (x / y);
            }
        }
    }
}
