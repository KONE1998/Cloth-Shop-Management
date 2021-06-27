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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\WindowsFormsApp9\WindowsFormsApp9\test.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataReader dr;
        SqlCommand cmd;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet2.Table2' table. You can move, or remove it, as needed.
            this.table2TableAdapter.Fill(this.testDataSet2.Table2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            int aa = Convert.ToInt32(textBox1.Text);

            string abc = "SELECT billno,itemname,quantity,Total,subtotal,time FROM table2 WHERE billno = '" + aa + "'";
            cmd = new SqlCommand(abc, con);

            MessageBox.Show("one found");


            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
