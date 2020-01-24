using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sign;
        double val1;
        double val2;

        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text += one.Text;
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text += two.Text;
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text += three.Text;
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text += four.Text;
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text += five.Text;
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text += six.Text;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text += seven.Text;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text += eight.Text;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text += nine.Text;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text += zero.Text;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            sign = "*";
            val1 = double.Parse(textBox1.Text);
            textBox1.Text = " ";
        }

        private void add_Click(object sender, EventArgs e)
        {
            sign = "+";
            val1 = double.Parse(textBox1.Text);
            textBox1.Text = " ";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            sign = "-";
            val1 = double.Parse(textBox1.Text);
            textBox1.Text = " ";
        }

        private void div_Click(object sender, EventArgs e)
        {
            sign = "/";
            val1 = double.Parse(textBox1.Text);
            textBox1.Text = " ";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double result;
            val2 = double.Parse(textBox1.Text);
            if(sign == "+")
            {
                result = val1 + val2;
                textBox1.Text = result.ToString();
            }
            else if(sign == "-")
            {
                result = val1 - val2;
                textBox1.Text = result.ToString();
            }
            else if(sign == "*")
            {
                result = val1 * val2;
                textBox1.Text = result.ToString();
            }
            else if(sign == "/")
            {
                result = val1 / val2;
                textBox1.Text = result.ToString();
            }
        }

        private void fact_Click(object sender, EventArgs e)
        {
            
            double n = double.Parse(textBox1.Text);
            double i, f = 1;
            for(i=1; i<n; i++)
            {
                f = f * n; 
            }
            textBox1.Text = f.ToString();
        }

        private void squ_Click(object sender, EventArgs e)
        {
            double v = double.Parse(textBox1.Text);
            double ans = v * v;
            textBox1.Text = ans.ToString();
        }

        private void log_Click(object sender, EventArgs e)
        {
            double v = double.Parse(textBox1.Text);
            textBox1.Text = Math.Log(v).ToString();
        }

        private void pow_Click(object sender, EventArgs e)
        {
            double v = double.Parse(textBox1.Text);
            double u = double.Parse(textBox1.Text);
            textBox1.Text = Math.Pow(v, u).ToString();

        }

        private void squRoot_Click(object sender, EventArgs e)
        {
            double v = double.Parse(textBox1.Text);
            textBox1.Text = Math.Sqrt(v).ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
