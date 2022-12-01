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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Progetto_Banca_Client
{
    public partial class Form4 : Form
    {
        int s = 0;
        Form2 f;
        bool attivo_bon = false;
        bool attivo_ric = false;

        public Form4(Form2 f2)
        {
            InitializeComponent();
            DateTime thisDay = DateTime.Today;
            label_date.Text = thisDay.ToString("dd/MM/yyyy");
            f = f2;
            attivo_bon = false;
            attivo_ric = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button_bon_view_Click(object sender, EventArgs e)
        {
            attivo_ric = false;
            listView_BON.Visible = true;
            listView_RIC.Visible = false;
            if (attivo_bon != true)
            {
                if (s == 2)
                {
                    button_ricariche_view.ForeColor = Color.Black;
                }
                s = 1;
                button_bon_view.ForeColor = Color.Green;

                byte[] bytes_ok = new byte[102456];

                // Connect to a remote device.  
                try
                {
                    // Establish the remote endpoint for the socket.  
                    // This example uses port 11000 on the local computer.  
                    IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                    IPEndPoint remoteEP = new IPEndPoint(ipAddress, 5000);

                    // Create a TCP/IP  socket.  
                    Socket sen = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                    // Connect the socket to the remote endpoint. Catch any errors.  
                    try
                    {
                        sen.Connect(remoteEP);

                        // Encode the data string into a byte array.  
                        byte[] msg = Encoding.ASCII.GetBytes("lista_bonifici" + ';' + f.label_iban.Text + "<EOF>");

                        // Send the data through the socket.  
                        int bytesSent = sen.Send(msg);

                        // Receive the response from the remote device.  
                        int bytesRec = sen.Receive(bytes_ok);

                        string msg_server = Encoding.ASCII.GetString(bytes_ok, 0, bytesRec);

                        if (msg_server == "non_esiste")
                        {
                            MessageBox.Show("NON SONO ANCORA PRESENTI DEI BONIFICI.");
                        }
                        else
                        {
                            string[] items_temp = new string[9];
                            int freq = msg_server.Count(f => (f == '$'));
                            string[] row_temp = msg_server.Split('$');
                            for (int i = 0; i < freq; i++)
                            {
                                string temp = row_temp[i];
                                items_temp = temp.Split(';');
                                if (items_temp[6] == "False")
                                {
                                    items_temp[6] = "no";
                                }
                                else
                                {
                                    items_temp[6] = "si";
                                }

                                if (items_temp[7] == "False")
                                {
                                    items_temp[7] = "no";
                                }
                                else
                                {
                                    items_temp[7] = "si";
                                }

                                if (items_temp[8] == "False")
                                {
                                    items_temp[8] = "no";
                                }
                                else
                                {
                                    items_temp[8] = "si";
                                }

                                string[] row = { items_temp[0], items_temp[1], items_temp[2], items_temp[3] + " €", items_temp[5], items_temp[6], items_temp[7], items_temp[8], items_temp[4] + " €" };
                                var listViewItem = new ListViewItem(row);
                                listView_BON.Items.Add(listViewItem);
                            }
                            listView_BON.View = View.Details;
                            listView_BON.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                            listView_BON.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        }

                        // Release the socket.  
                        sen.Shutdown(SocketShutdown.Both);
                        sen.Close();

                    }
                    catch (ArgumentNullException ane)
                    {
                        MessageBox.Show("ArgumentNullException : {0}", ane.ToString());
                    }
                    catch (SocketException se)
                    {
                        MessageBox.Show("SocketException : {0}", se.ToString());
                    }
                    catch (Exception r)
                    {
                        MessageBox.Show("Unexpected exception : {0}", e.ToString());
                    }
                }
                catch (Exception o)
                {
                    MessageBox.Show(o.ToString());
                }
                attivo_bon = true;
            }
        }

        private void button_ricariche_view_Click(object sender, EventArgs e)
        {
            attivo_bon = false;
            listView_BON.Items.Clear();
            listView_BON.Visible = false;
            listView_RIC.Visible = true;
            if (attivo_ric != true)
            {
                listView_RIC.View = View.Details;
                listView_BON.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                listView_BON.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                if (s == 1)
                {
                    button_bon_view.ForeColor = Color.Black;
                }
                s = 2;
                button_ricariche_view.ForeColor = Color.Green;

                attivo_ric = true;
            }
        }
    }
}
