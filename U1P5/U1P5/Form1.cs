using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1P5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = textBox1.Text;
            int d = 0, v = 0, sc = 0, sp = 0, i;
            for(i=0; i<s.Length; i++)
            {
                char ch = s[i];
                if(ch == ' ')
                {
                    sp++;
                }
                else if(ch>='0' && ch<='9')
                {
                    d++;
                }
                else if(ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' ||
                    ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
                {
                    v++;
                }
                else if(!Char.IsLetterOrDigit(ch))
                {
                    sc++;
                }
            }

            label6.Text = v.ToString();
            label7.Text = sp.ToString();
            label8.Text = d.ToString();
            label9.Text = sc.ToString();
        }
    }
}
