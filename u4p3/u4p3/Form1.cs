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
     
namespace u4p3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\VB.NET\u4p3.mdb");
        OleDbCommand cmd;
       // OleDbDataAdapter da;
        //DataSet ds;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("select sname from state", con);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            cmd = new OleDbCommand();
            cmd.CommandText = "select sno from state where sname='" + comboBox1.Text + "'";
            cmd.Connection = con;
            con.Open();
            int i = Convert.ToInt16(cmd.ExecuteScalar());

            cmd.CommandText = "select cname from city where sno=" + i;

            OleDbDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                comboBox2.Items.Add(dr[0]);
            }
            con.Close();
        }
    }
}
