using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp9
{
    public partial class Main5 : Form
    {
        public Main5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\WindowsFormsApp9\WindowsFormsApp9\test.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO login(username,password) VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User data inserted successfully!!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            main4 mh = new main4();
            mh.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

