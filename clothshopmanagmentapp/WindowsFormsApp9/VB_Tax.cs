using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp9
{
    public partial class VB_Tax : Form
    {
        double iTax, iSubTotal, iTotal;
        


        public VB_Tax()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)

        {
            DialogResult iExit;
            iExit = MessageBox.Show("confirm if u want to exit", "sales inventory system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                this.Close();
                Main2 mj = new Main2();
                mj.Show();
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblTax.BackColor = Color.White;
            lblSubTotal.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";
            txtquantity.Text = "";

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_QueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label5.Text, new Font("Arial", 30, FontStyle.Italic), Brushes.Black, 120, 24);
            e.Graphics.DrawString(comboBox1.Text, new Font("Arial", 30, FontStyle.Italic), Brushes.Black, 438, 24);

            e.Graphics.DrawString(textBox1.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Green, 419, 9);
            e.Graphics.DrawString(label7.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Green, 234, 9);
            e.Graphics.DrawString(label1.Text, new Font("Arial", 30, FontStyle.Italic), Brushes.Black, 114, 72);
            e.Graphics.DrawString(label2.Text, new Font("Arial", 30, FontStyle.Italic), Brushes.Black, 114, 130);
            e.Graphics.DrawString(lblSubTotal.Text, new Font("Arial", 30, FontStyle.Italic), Brushes.Black, 432, 130);
            e.Graphics.DrawString(label3.Text, new Font("Arial", 30, FontStyle.Italic), Brushes.Black, 114, 184);
            e.Graphics.DrawString(lblTax.Text, new Font("Arial", 30, FontStyle.Italic), Brushes.Pink, 432, 184);
            e.Graphics.DrawString(txtquantity.Text, new Font("Arial", 30, FontStyle.Italic), Brushes.Black, 430, 92);
            e.Graphics.DrawString(label4.Text, new Font("Arial", 30, FontStyle.Bold), Brushes.Black, 114, 242);
            e.Graphics.DrawString(lblTotal.Text, new Font("Arial", 30, FontStyle.Bold), Brushes.Black, 431, 242);
            e.Graphics.DrawString(label6.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Green, 12, -1);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblTax_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\WindowsFormsApp9\WindowsFormsApp9\test.mdf;Integrated Security=True;Connect Timeout=30");
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string s = " ";
            
            String query = "INSERT INTO Table2(billno,itemname,quantity,Total,time) VALUES('" + textBox1.Text + "','" + comboBox1.Text + "','" + txtquantity.Text + "','" + lblTotal.Text + "','" + s + dateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Bill Added  successfully!!!!");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSubTotal_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 kl = new Form5();
            kl.Show();
        }

        private void VB_Tax_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("select * from table2",con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            int i = dt.Rows.Count;
            string cnt = Convert.ToString(i + 1);
            textBox1.Text = " " + cnt;
            con.Close();

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            cTax cost = new cTax();
            if (txtquantity.Text == "")
            {
                MessageBox.Show("enter quanity", "sales inventory system", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtquantity.Focus();
            }
            else
            {
                cost.item1 = double.Parse(txtquantity.Text) * 4.5;

                iSubTotal = cost.GetAmount();
                iTax = cost.cFindTax(iSubTotal);

                iTotal = iSubTotal + iTax;
                string c = "Rs";
                lblTax.Text = String.Format("{0:F2}", iTax);
                lblSubTotal.Text = String.Format("{0:F2}",iSubTotal);
                lblTotal.Text = String.Format("{0:F2}", iTotal);
                lblTax.BackColor = Color.Azure;
                
            }
        }
    }
}





   