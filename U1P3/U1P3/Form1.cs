using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1P3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            double n = double.Parse(textBox1.Text);
            double ans = 0;

            if(radioButton1.Checked == true)
            {
                ans = 1.8 * n + 32;
                MessageBox.Show(ans.ToString());
            }
            else if(radioButton2.Checked == true)
            {
                ans = (n - 32) / 1.8;
                MessageBox.Show(ans.ToString());
            }

        }
    }
}
