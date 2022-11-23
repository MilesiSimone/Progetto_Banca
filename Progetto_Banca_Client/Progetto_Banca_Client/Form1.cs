using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_Banca_Client
{
    public partial class Form1 : Form
    {
        public string[] s = new string[9];
        string nome;

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
            if (textBox_password.UseSystemPasswordChar == false)
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
           VerificaCredenziali();
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

        private void pictureBox_mostra_password_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBox_mostra_password, "Mostra/Nascondi password");
        }

        private void VerificaCredenziali()
        {
            // Data buffer for incoming data.  
            byte[] bytes_ok = new byte[1024];
            byte[] bytes_info = new byte[5000];

            // Connect to a remote device.  
            try
            {
                // Establish the remote endpoint for the socket.  
                // This example uses port 11000 on the local computer.  
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 5000);

                // Create a TCP/IP  socket.  
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.  
                try
                {
                    sender.Connect(remoteEP);

                    // Encode the data string into a byte array.  
                    byte[] msg = Encoding.ASCII.GetBytes("accedi" + ';' + textBox_username.Text + ';' + textBox_password.Text + "<EOF>");

                    // Send the data through the socket.  
                    int bytesSent = sender.Send(msg);

                    // Receive the response from the remote device.  
                    int bytesRec = sender.Receive(bytes_ok);

                    string msg_server = Encoding.ASCII.GetString(bytes_ok, 0, bytesRec);
                    s = msg_server.Split(';');
                    nome = s[2] + " " + s[1];
                    if (s[0] == "ok")
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        this.Hide();
                        f2.label_utente.Text = nome;
                        f2.label_iban.Text = s[3];
                        f2.label_saldo_contabile.Text = s[4] + " €";
                        f2.label_saldo_disponibile.Text = s[5] + " €";
                        s[6] = s[6].Remove(0, 12);
                        s[6] = "************" + s[6];
                        s[7] = s[7].Remove(0, 12);
                        s[7] = "************" + s[7];
                        f2.label_num_carta_1.Text = s[6];
                        f2.label_num_carta_2.Text = s[7];
                    }
                    else
                    {
                        label_error.Visible = true;
                        textBox_username.Text = "";
                        textBox_password.Text = "";
                    }
                    
                    // Release the socket.  
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    MessageBox.Show("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    MessageBox.Show("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            CloseCancel(e);
        }

        public static void CloseCancel(FormClosingEventArgs e)
        {
            const string message = "SEI SICURO DI VOLER CHIUDERE L'APP?";
            const string caption = "Conferma chiusura";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }
    }
}

