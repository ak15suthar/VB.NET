using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictacktow
{
    public partial class Form1 : Form
    {
        char flag = '0';
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = flag.ToString();
           
            if (checkwinner())
            {

                MessageBox.Show(flag.ToString() + " is winner");
                clear();
              
            }

            if (flag=='0')
            {
                flag = 'X';
            }
            else
            {
                flag = '0';
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = flag.ToString();
            if (checkwinner())
            {
                MessageBox.Show(flag.ToString() + " is winner");
                clear();
            }
            if (flag == '0')
            {
                flag = 'X';
            }
            else
            {
                flag = '0';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = flag.ToString();
            if (checkwinner())
            {
                MessageBox.Show(flag.ToString() + " is winner");
                clear();
            }
            if (flag == '0')
            {
                flag = 'X';
            }
            else
            {
                flag = '0';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = flag.ToString();
            if (checkwinner())
            {
                MessageBox.Show(flag.ToString() + " is winner");
                clear();
            }
            if (flag == '0')
            {
                flag = 'X';
            }
            else
            {
                flag = '0';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = flag.ToString();
            if (checkwinner())
            {
                MessageBox.Show(flag.ToString() + " is winner");
                clear();
            }
            if (flag == '0')
            {
                flag = 'X';
            }
            else
            {
                flag = '0';
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = flag.ToString();
            if (checkwinner())
            {
                MessageBox.Show(flag.ToString() + " is winner");
                clear();
            }
            if (flag == '0')
            {
                flag = 'X';
            }
            else
            {
                flag = '0';
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = flag.ToString();
            if (checkwinner())
            {
                MessageBox.Show(flag.ToString() + " is winner");
                clear();
            }
            if (flag == '0')
            {
                flag = 'X';
            }
            else
            {
                flag = '0';
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = flag.ToString();
            if (checkwinner())
            {
                MessageBox.Show(flag.ToString() + " is winner");
                clear();
            }
            if (flag == '0')
            {
                flag = 'X';
            }
            else
            {
                flag = '0';
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = flag.ToString();
            if (checkwinner())
            {
                MessageBox.Show(flag.ToString() + " is winner");
                clear();
            }
            if (flag == '0')
            {
                flag = 'X';
            }
            else
            {
                flag = '0';
            }
        }

        bool checkwinner()
        {
            bool result = false;
            if(button1.Text==button2.Text && button2.Text==button3.Text)
            {
                if (button1.Text == "")
                {

                }
                else
                {
                    result = true;
                }
            }
            else if(button4.Text==button5.Text && button5.Text==button6.Text)
            {
                if (button4.Text == "")
                {
                }
                else
                {
                    result = true;
                }
            }
            else if(button7.Text==button8.Text && button8.Text==button9.Text)
            {
                if (button7.Text == "")
                {

                }
                else
                {
                    result = true;
                }
            }
            else if(button1.Text==button5.Text && button5.Text==button9.Text)
            {
                if (button1.Text=="")
                { }
                else
                {
                    result = true;
                }
            }
            else if(button3.Text==button5.Text && button5.Text==button7.Text)
            {
                if (button3.Text == "")
                { }
                else
                {
                    result = true;
                }
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text == "")
                { }
                else
                {
                    result = true;
                }
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text == "")
                { }
                else
                {
                    result = true;
                }
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text == "")
                { }
                else
                {
                    result = true;
                }
            }
            else
            {
                result = false;
            }
            return result;
        }
        void clear()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            flag = '0';
        }
    }
}
