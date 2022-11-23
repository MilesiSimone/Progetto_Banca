using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        int s = 0;
        Form2 f2 = new Form2();

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

        // Controllo inserimento IMPORTO
        
        private void textBox_importo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                if (textBox_importo.Text != "" && (e.KeyChar != ','))
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

                string[] parts = result.Split(',');

                if (parts.Length > 1)

                {

                    if (parts[1].Length > 2 || parts.Length > 2)

                    {

                        e.Handled = true;
                    }

                    // only allow one decimal point
                    if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void textBox_importo_Click(object sender, EventArgs e)
        {
            if(textBox_importo.Text == "0,00 €")
            {
                textBox_importo.Text = "";
            }
        }

        // Pulsanti Operazioni
        private void button1_Click(object sender, EventArgs e)
        {
            if (s == 3)
            {
                button3.ForeColor = Color.Black;
                label_dati_ricarica.Visible = false;
                label_num_carta.Visible = false;
                comboBox_num_carta.Visible = false;
                label_importo.Visible = false;
                textBox_importo.Visible = false;
                button_invia_ricarica.Visible = false;
            }
            else if(s == 4 || s == 2)
            {
                button2.ForeColor = Color.Black;
                button4.ForeColor = Color.Black;
                pictureBox_att.Visible = false;
                label_att_1.Visible = false;
                label_att_2.Visible = false;
                button_invia_ricarica.Visible = false;
            }
            s = 1;
            button1.ForeColor = Color.Green;
            label_conto_ben.Visible = true;
            textBox_iban.Visible = true;
            label_dati.Visible = true;
            label_importo.Visible = true;
            textBox_importo.Visible = true;
            label_causale.Visible = true;
            textBox_causale.Visible = true;
            label_det_fisc.Visible = true;
            checkBox_det_fisc.Visible = true;
            label_tipo_bon.Visible = true;
            checkBox_bon_ordinario.Visible = true;
            checkBox_bon_istantaneo.Visible = true;
            button_invia_bon.Visible = true;
           
        }

        // Pulsanti Operazioni
        private void button3_Click(object sender, EventArgs e)
        {
            if (s == 1)
            {
                button1.ForeColor = Color.Black;
                label_conto_ben.Visible = false;
                textBox_iban.Visible = false;
                label_dati.Visible = false;
                label_importo.Visible = false;
                textBox_importo.Visible = false;
                label_causale.Visible = false;
                textBox_causale.Visible = false;
                label_det_fisc.Visible = false;
                checkBox_det_fisc.Visible = false;
                label_tipo_bon.Visible = false;
                checkBox_bon_ordinario.Visible = false;
                checkBox_bon_istantaneo.Visible = false;
                button_invia_bon.Visible = false;
            }
            else if(s == 2 || s == 4)
            {
                button2.ForeColor = Color.Black;
                button4.ForeColor = Color.Black;
                pictureBox_att.Visible = false;
                label_att_1.Visible = false;
                label_att_2.Visible = false;
            }
            s = 3;
            button3.ForeColor = Color.Green;
            label_dati_ricarica.Visible = true;
            label_num_carta.Visible = true;
            comboBox_num_carta.Visible = true;
            label_importo.Visible = true;
            textBox_importo.Visible = true;
            button_invia_ricarica.Visible = true;
        }

        // Controllo inserimento IBAN
        private void textBox_iban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar < 65 || e.KeyChar > 122)
            {
                e.Handled = true;
            }
        }

        // Pulsanti Operazioni
        private void button2_Click(object sender, EventArgs e)
        {
            if (s == 1)
            {
                button1.ForeColor = Color.Black;
                label_conto_ben.Visible = false;
                textBox_iban.Visible = false;
                label_dati.Visible = false;
                label_importo.Visible = false;
                textBox_importo.Visible = false;
                label_causale.Visible = false;
                textBox_causale.Visible = false;
                label_det_fisc.Visible = false;
                checkBox_det_fisc.Visible = false;
                label_tipo_bon.Visible = false;
                checkBox_bon_ordinario.Visible = false;
                checkBox_bon_istantaneo.Visible = false;
                button_invia_bon.Visible = false;
            }
            else if (s == 3)
            {
                button3.ForeColor = Color.Black;
                label_dati_ricarica.Visible = false;
                label_num_carta.Visible = false;
                comboBox_num_carta.Visible = false;
                label_importo.Visible = false;
                textBox_importo.Visible = false;
                button_invia_ricarica.Visible = false;
            }
            else if (s == 4)
            {
                button4.ForeColor = Color.Black;
                pictureBox_att.Visible = false;
                label_att_1.Visible = false;
                label_att_2.Visible = false;
            }
            s = 2;
            button2.ForeColor = Color.Green;
            pictureBox_att.Visible = true;
            label_att_1.Visible = true;
            label_att_2.Visible = true;
        }

        // Pulsanti Operazioni
        private void button4_Click(object sender, EventArgs e)
        {
            if (s == 1)
            {
                button1.ForeColor = Color.Black;
                label_conto_ben.Visible = false;
                textBox_iban.Visible = false;
                label_dati.Visible = false;
                label_importo.Visible = false;
                textBox_importo.Visible = false;
                label_causale.Visible = false;
                textBox_causale.Visible = false;
                label_det_fisc.Visible = false;
                checkBox_det_fisc.Visible = false;
                label_tipo_bon.Visible = false;
                checkBox_bon_ordinario.Visible = false;
                checkBox_bon_istantaneo.Visible = false;
                button_invia_bon.Visible = false;
            }
            else if (s == 3)
            {
                button3.ForeColor = Color.Black;
                label_dati_ricarica.Visible = false;
                label_num_carta.Visible = false;
                comboBox_num_carta.Visible = false;
                label_importo.Visible = false;
                textBox_importo.Visible = false;
                button_invia_ricarica.Visible = false;
            }
            else if (s == 2)
            {
                button2.ForeColor = Color.Black;
                pictureBox_att.Visible = false;
                label_att_1.Visible = false;
                label_att_2.Visible = false;
            }
            s = 4;
            button4.ForeColor = Color.Green;
            pictureBox_att.Visible = true;
            label_att_1.Visible = true;
            label_att_2.Visible = true;
        }

        // Controllo inserimento IMPORTO
        private void textBox_importo_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_importo.Text != "")
            {
                Double value;
                if (Double.TryParse(textBox_importo.Text, out value))
                    textBox_importo.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
                else
                    textBox_importo.Text = String.Empty;
            }
        }

        // Controllo inserimento tipo bonifico
        private void checkBox_bon_istantaneo_Click(object sender, EventArgs e)
        {
            if (checkBox_bon_ordinario.Checked == true)
            {
                checkBox_bon_ordinario.Checked = false;
                checkBox_bon_istantaneo.Checked = true;
            }
            else
            {
                checkBox_bon_istantaneo.Checked = true;
            }
        }

        // Controllo inserimento tipo bonifico
        private void checkBox_bon_ordinario_Click(object sender, EventArgs e)
        {
            if (checkBox_bon_istantaneo.Checked == true)
            {
                checkBox_bon_istantaneo.Checked = false;
                checkBox_bon_ordinario.Checked = true;
            }
            else
            {
                checkBox_bon_ordinario.Checked = true;
            }
        }

        // Pulsante INVIA bonifico
        private void button_invia_bon_Click(object sender, EventArgs e)
        {
            if (textBox_causale.Text != "" && textBox_iban.SelectionLength == 27 && textBox_importo.Text != "0,00 €" && textBox_importo.Text != "" && (checkBox_bon_istantaneo.Checked == true || checkBox_bon_ordinario.Checked == true) && (f2.saldo_disp() - importo()) >= 0)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("OPERAZIONE NON RIUSCITA...     CONTROLLARE I DATI INSERITI.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Conversione importo da string a double
        public double importo()
        {
            double saldo = 0;
            string string_saldo = textBox_importo.Text;
            string_saldo = string_saldo.Substring(0, string_saldo.Length - 2);
            saldo = Convert.ToDouble(string_saldo);
            return saldo;
        }

    }
}
