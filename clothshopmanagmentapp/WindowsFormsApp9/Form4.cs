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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\WindowsFormsApp9\WindowsFormsApp9\test.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataReader dr;
        SqlCommand cmd;
        public Form4()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            
                int aa = Convert.ToInt32(textBox1.Text);

                string abc = "SELECT no,Sname,amount,mobno,purchase,discount FROM tbl_insertion WHERE no = '" + aa + "'";
                cmd = new SqlCommand(abc, con);
           
                MessageBox.Show("one found");


                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            con.Close();
            
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet1.tbl_insertion' table. You can move, or remove it, as needed.
            this.tbl_insertionTableAdapter.Fill(this.testDataSet1.tbl_insertion);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main3 mk = new Main3();
            mk.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
