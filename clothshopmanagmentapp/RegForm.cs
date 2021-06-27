using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AesEncDec;
using System.IO;
namespace WindowsFormsApp9
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usrTxt.Text.Length < 3 || passTxt.Text.Length < 5)
            {
                MessageBox.Show("Username or Password is invaled or too short!");
            }
            else
            {
                string dir = usrTxt.Text;
                Directory.CreateDirectory("data\\" + dir);

                var sw = new StreamWriter("data\\" + dir + "\\data.ls");

                string encusr = AesCryp.Encrypt(usrTxt.Text);
                string encpass = AesCryp.Encrypt(passTxt.Text);
             
                sw.WriteLine(encusr);
                sw.WriteLine(encpass);
                
                sw.Close();

                MessageBox.Show("User {0} was successfully created.", usrTxt.Text);
                MessageBox.Show("User {0} was successfully created.", passTxt.Text);
                this.Close();
            }
        }
    }
}
