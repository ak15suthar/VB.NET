using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace u4p2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\VB.NET\College\u4p2\check.mdb");
            OleDbCommand cmd = new OleDbCommand("select count(*) from login where uname=@user and pass=@passw", con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@passw", textBox2.Text);
            con.Open();

            int c = Convert.ToInt32(cmd.ExecuteScalar());

            if(c == 1)
            {
                MessageBox.Show("Login Successfull");
                Form2 f = new Form2();
                //f.MdiParent=this;
                f.Show();
            }
            else if(c == 0)
            {
                MessageBox.Show("Login Unsuccessfull");
            }
            else if(c > 1)
            {
                MessageBox.Show("You have more than one of the same username and password");
            }
            con.Close();

        }
    }
}
