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

namespace u4p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\VB.NET\College\u4p1\book.mdb");
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("select * from book1",con);
            da = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);

            textBox1.DataBindings.Add("Text", ds.Tables[0], "bookid");
            textBox2.DataBindings.Add("Text", ds.Tables[0], "bname");
            textBox3.DataBindings.Add("Text", ds.Tables[0], "qty");
            textBox4.DataBindings.Add("Text", ds.Tables[0], "unitprice");
            textBox5.DataBindings.Add("Text", ds.Tables[0], "totalprice");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new OleDbCommand("delete from book1 where bookid=" + textBox1.Text,con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.BindingContext[ds.Tables[0]].AddNew();
            MessageBox.Show("Deleted Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("insert into book1 values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new OleDbCommand("update book1 set bookid=" + textBox1.Text + ",bname='" + textBox2.Text + "',qty=" + textBox3.Text + ",unitprice=" + textBox4.Text + ",totalprice=" + textBox5.Text+" where bookid="+textBox1.Text,con);
            
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds.Tables[0]].AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds.Tables[0]].Position = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds.Tables[0]].Position = this.BindingContext[ds.Tables[0]].Position + 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds.Tables[0]].Position = this.BindingContext[ds.Tables[0]].Position - 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds.Tables[0]].Position = this.BindingContext[ds.Tables[0]].Count - 1;
        }
    }
}
