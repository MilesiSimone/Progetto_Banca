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
                label_num_carta_1.Visible = true;
                label_num_carta_2.Visible = true;
                label7.Text = "Nascondi carte";
            }
            else
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label_num_carta_1.Visible = false;
                label_num_carta_2.Visible = false;
                label7.Text = "Visualizza carte";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button_operazioni_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            f3.comboBox_num_carta.Items.Add(label_num_carta_1.Text);
            f3.comboBox_num_carta.Items.Add(label_num_carta_2.Text);
        }

        // Mostra/Nascondi assistenza
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBox1, "Assistenza");
        }

        // Mostra/Nascondi password
        private void pictureBox_mostra_password_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox_mostra_password, "Mostra/Nascondi saldo");
        }

        // Conversione saldo da string a double
        public double saldo_cont()
        {
            double saldo = 0;
            string string_saldo = label_saldo_contabile.Text;
            string_saldo = string_saldo.Substring(0, string_saldo.Length - 2);
            saldo = Convert.ToDouble(string_saldo);
            return saldo;
        }

        // Conversione saldo da string a double
        public double saldo_disp()
        {
            double saldo = 0;
            string string_saldo = label_saldo_disponibile.Text;
            string_saldo = string_saldo.Substring(0, string_saldo.Length - 2);
            saldo = Convert.ToDouble(string_saldo);
            return saldo;
        }
    }
}
