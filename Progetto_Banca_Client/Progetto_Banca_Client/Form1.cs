using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_Banca_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime thisDay = DateTime.Today;
            label_date.Text = thisDay.ToString("D");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_mostra_password_Click(object sender, EventArgs e)
        {
            if(textBox_password.UseSystemPasswordChar == false)
            {
                textBox_password.UseSystemPasswordChar = true;
            }
            else
            {
                textBox_password.UseSystemPasswordChar = false;
            }
        }

        private void button_accedi_MouseHover(object sender, EventArgs e)
        {
            button_accedi.ForeColor = Color.White;
        }

        private void button_accedi_MouseLeave(object sender, EventArgs e)
        {
            button_accedi.ForeColor = Color.Black;
        }
    }
}
