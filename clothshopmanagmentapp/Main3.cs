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
    public partial class Main3 : Form
    {
        public Main3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Main3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
              
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\WindowsFormsApp9\WindowsFormsApp9\test.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            con.Open();
            String query = "INSERT INTO tbl_insertion(no,sname,mobno,purchase,discount,amount) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            SqlDataAdapter SDA= new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Supplier data inserted successfully!!!!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            String query="DELETE FROM tbl_insertion WHERE no='"+textBox1.Text+"'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deletion  of supplier detail successful!!! ");
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM tbl_insertion";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "UPDATE tbl_insertion SET Sname='" + textBox2.Text + "',mobno='" + textBox4.Text + "',purchase='" + comboBox1.Text + "',discount='" + textBox5.Text + "',amount='" + textBox6.Text + "' WHERE no='" + textBox1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updation of supplier detail successful!!! ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Main2 mh = new Main2();
            mh.Show();
        }

        private void print_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString(label7.Text, new Font("Arial", 40, FontStyle.Bold), Brushes.Black, 37, 20);
            e.Graphics.DrawString(textBox1.Text, new Font("Arial", 40, FontStyle.Bold), Brushes.Black, 145, 17);
            e.Graphics.DrawString(label2.Text, new Font("Arial", 40, FontStyle.Bold), Brushes.Black, 37, 56);
            e.Graphics.DrawString(textBox2.Text, new Font("Arial", 40, FontStyle.Bold), Brushes.Black, 145, 56);
            e.Graphics.DrawString(label3.Text, new Font("Arial", 40, FontStyle.Bold), Brushes.Black, 37, 97);
            e.Graphics.DrawString(textBox4.Text, new Font("Arial", 40, FontStyle.Bold), Brushes.Black, 145, 97);
            e.Graphics.DrawString(label4.Text, new Font("Arial", 40, FontStyle.Bold), Brushes.Black, 39, 134);
           


        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 hh = new Form4();
            hh.Show();
        }
    }
}
