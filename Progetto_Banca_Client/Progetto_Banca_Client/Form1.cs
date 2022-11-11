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
            CheckForIllegalCrossThreadCalls = false;
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

        private void label2_MouseHover(object sender, EventArgs e)
        {

        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button_accedi_Click(object sender, EventArgs e)
        {
            if(textBox_username.Text == "u1" && textBox_password.Text == "u1")
            {
                Form2 f2 = new Form2(this);
                f2.Show();
                this.Hide();
            }
            else
            {
                label_error.Visible = true;
                textBox_username.Text = "";
                textBox_password.Text = "";
            }
        }

        private void button_accedi_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_accedi_Click(sender, e);
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cartabcc.it/vantaggi-e-servizi/controllo/Pagine/assistenza-24-7.aspx");
        }
    }
}
