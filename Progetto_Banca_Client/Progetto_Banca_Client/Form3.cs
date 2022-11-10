using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Progetto_Banca_Client
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            DateTime thisDay = DateTime.Today;
            label_date.Text = thisDay.ToString("D");
        }

        private void panel_ricarica_carta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_num_carta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_importo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                if(textBox_importo.Text != "" && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
                else
                {
                    textBox_importo.Text = "0";
                    e.Handled = true;
                }
                
            }
            else
            {
                TextBox tb = sender as TextBox;

                int cursorPosLeft = tb.SelectionStart;

                int cursorPosRight = tb.SelectionStart + tb.SelectionLength;

                string result = tb.Text.Substring(0, cursorPosLeft) + e.KeyChar + tb.Text.Substring(cursorPosRight);

                string[] parts = result.Split('.');

                if (parts.Length > 1)

                {

                    if (parts[1].Length > 2 || parts.Length > 2)

                    {

                        e.Handled = true;
                    }

                    // only allow one decimal point
                    if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void textBox_importo_Click(object sender, EventArgs e)
        {
            textBox_importo.Text = "";
        }

        private void textBox_iban_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Green;
            label_conto_ben.Visible = true;
            textBox_iban.Visible = true;
            label_dati.Visible = true;
            label_importo.Visible = true;
            textBox_importo.Visible = true;
            label_causale.Visible = true;
            textBox_causale.Visible = true;
            label_tipo_bon.Visible = true;
            checkBox_det_fisc.Visible = true;
            label_det_fisc.Visible = true;
            checkBox_bon_ordinario.Visible = true;
            checkBox_bon_istantaneo.Visible = true;
            button_invia_bon.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label_num_carta.Visible = true;
            textBox_num_carta.Visible = true;
        }

        private void textBox_importo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_iban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar < 65 || e.KeyChar > 122)
            {
                e.Handled = true;
            }
        }

        private void textBox_num_carta_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_bon_ordinario_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_bon_istantaneo.Checked == true)
            {
                checkBox_bon_istantaneo.Checked = false;
                checkBox_bon_ordinario.Checked = true;
            }
            
        }

        private void checkBox_bon_istantaneo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_bon_ordinario.Checked == true)
            {
                checkBox_bon_ordinario.Checked = false;
                checkBox_bon_istantaneo.Checked = true;
            }
            
          
        }
    }
}
