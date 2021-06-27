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
    public partial class Main2 : Form
    {
        public Main2()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VB_Tax mj = new VB_Tax();
            mj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Main3 mh = new Main3();
            mh.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 mh = new Form1();
            mh.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Main3 kk = new Main3();
            kk.Show();
        }
    }
}
