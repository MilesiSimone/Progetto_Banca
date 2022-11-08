using Progetto_Banca_Client.Properties;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_iban_Click(object sender, EventArgs e)
        {

        }

        private void label_icona_euro_Click(object sender, EventArgs e)
        {

        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Blue;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.FromArgb(64,64,64);
        }

        private void pictureBox_mostra_password_Click(object sender, EventArgs e)
        {
            if (pictureBox_cassaforte.Visible == false)
            {
                pictureBox_cassaforte.Visible = true;
                label_saldoNasc.Visible = true;
                pictureBox_cassaforte.BringToFront();
                label_saldoNasc.BringToFront();
                pictureBox_mostra_password.Image = Resources.visible;
            }
            else
            {
                pictureBox_cassaforte.Visible = false;
                label_saldoNasc.Visible = false;
                pictureBox_cassaforte.SendToBack();
                label_saldoNasc.SendToBack();
                pictureBox_mostra_password.Image = Resources.nascondi;
            }
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Blue;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(64,64,64);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == false)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                label7.Text = "Nascondi carte";
            }
            else
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label7.Text = "Visualizza carte";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
