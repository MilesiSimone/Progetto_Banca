using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;
using System.Diagnostics;

public class SynchronousSocketListener
{

    // Incoming data from the client.  
    public static string data = null;
    public static string fileName = "clienti.txt";

    public static void StartListening()
    {
        // Data buffer for incoming data.  
        byte[] bytes = new Byte[1024];
        byte[] msg_list_bon = new Byte[1024];
        byte[] msg_list_ric = new Byte[1024];

        // Establish the local endpoint for the socket.  
        // Dns.GetHostName returns the name of the   
        // host running the application.  
        IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
        IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);

        // Create a TCP/IP socket.  
        Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

        // Bind the socket to the local endpoint and   
        // listen for incoming connections.  
        try
        {
            listener.Bind(localEndPoint);
            listener.Listen(10);

            // Start listening for connections.  
            while (true)
            {

                Console.WriteLine("\n\nWaiting for a connection...\n");
                // Program is suspended while waiting for an incoming connection.  
                Socket handler = listener.Accept();
                data = null;

                // An incoming connection needs to be processed.  
                while (true)
                {
                    int bytesRec = handler.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (data.IndexOf("<EOF>") > -1)
                    {
                        break;
                    }
                }
               
                string[] messaggio_client = data.Split(';');
                switch (messaggio_client[0])
                {

                    case "accedi":

                        string[] lines = File.ReadAllLines("clienti.txt");
                        string[] info = new string[9];
                        string controllo = "no";
                        foreach (string line in lines)
                        {
                            info = line.Split(';');
                            if (messaggio_client[1] == info[0] && messaggio_client[2] == (info[1] + "<EOF>"))
                            {
                                controllo = "ok";
                                Console.WriteLine("Accesso effettuato.");
                                Console.WriteLine("Utente: " + messaggio_client[1]);
                                break;
                            }
                        }

                        controllo = controllo + ";" + info[2] + ";" + info[3] + ";" + info[4] + ";" + info[5] + ";" + info[6] + ";" + info[7] + ";" + info[8];
                        // Echo the data back to the client.  
                        byte[] msg = Encoding.ASCII.GetBytes(controllo);
                        handler.Send(msg);
                        handler.Shutdown(SocketShutdown.Both);
                        handler.Close();

                        break;

                    case "bonifico":

                        Console.WriteLine("BONIFICO:\n");
                        Console.WriteLine("Iban utente:");
                        Console.WriteLine(messaggio_client[1]);
                        Console.WriteLine("Iban beneficiario:");
                        Console.WriteLine(messaggio_client[2]);
                        Console.WriteLine("Importo:");
                        messaggio_client[3] = messaggio_client[3].Substring(0, messaggio_client[3].Length - 2);
                        Console.WriteLine(messaggio_client[3]);
                        Console.WriteLine("Causale:");
                        Console.WriteLine(messaggio_client[5]);
                        Console.WriteLine("Data e ora:");
                        Console.WriteLine(messaggio_client[9]);
                        messaggio_client[10] = messaggio_client[10].Substring(0, messaggio_client[10].Length - 5);
                        Console.WriteLine(messaggio_client[10]);

                        string[] lines_read = File.ReadAllLines("clienti.txt");
                        string path_temp = "clienti_temp.txt";
                        string [] info_bon_read = new string[20];
                        foreach (string line in lines_read)
                        {
                            info_bon_read = line.Split(';');
                            if (messaggio_client[1] == info_bon_read[4])
                            {
                                File.AppendAllText(path_temp, info_bon_read[0] + ';' + info_bon_read[1] + ';' + info_bon_read[2] + ';' + info_bon_read[3] + ';' + info_bon_read[4] + ';' + messaggio_client[4] + ';' + messaggio_client[4] + ';' + info_bon_read[7] + ';' + info_bon_read[8] + "\n");
                            }
                            else
                            {
                                File.AppendAllText(path_temp, info_bon_read[0] + ';' + info_bon_read[1] + ';' + info_bon_read[2] + ';' + info_bon_read[3] + ';' + info_bon_read[4] + ';' + info_bon_read[5] + ';' + info_bon_read[6] + ';' + info_bon_read[7] + ';' + info_bon_read[8] + "\n");
                            }
                        }
                        File.Delete("clienti.txt");
                        File.Move("clienti_temp.txt", "clienti.txt");


                        if (!Directory.Exists("BONIFICI"))
                        {

                            Directory.CreateDirectory("BONIFICI");
                        }
                        string path = "BONIFICI/" + messaggio_client[1] + ".txt";
                        string lineappend = messaggio_client[9] + ';' + messaggio_client[10] + ';' + messaggio_client[2] + ';' + messaggio_client[3] + ';' + messaggio_client[4] + ';' + messaggio_client[5] + ';' + messaggio_client[6] + ';' + messaggio_client[7] + ';' + messaggio_client[8] + "\n";
                        File.AppendAllText(path, lineappend);

                        break;

                    case "ricarica":

                        Console.WriteLine("RICARICA:\n");
                        Console.WriteLine("Iban utente:");
                        Console.WriteLine(messaggio_client[1]);
                        Console.WriteLine("Numero carta:");
                        Console.WriteLine(messaggio_client[3]);
                        Console.WriteLine("Importo:");
                        messaggio_client[2] = messaggio_client[2].Substring(0, messaggio_client[2].Length - 2);
                        Console.WriteLine(messaggio_client[2]);
                        Console.WriteLine("Data e ora:");
                        Console.WriteLine(messaggio_client[5]);
                        messaggio_client[6] = messaggio_client[6].Substring(0, messaggio_client[6].Length - 5);
                        Console.WriteLine(messaggio_client[6]);

                        if (!Directory.Exists("RICARICHE"))
                        {

                            Directory.CreateDirectory("RICARICHE");
                        }
                        path = "RICARICHE/" + messaggio_client[1] + ".txt";
                        lineappend = messaggio_client[5] + ';' + messaggio_client[6] + ';' + messaggio_client[3] + ';' + messaggio_client[2] + ';' + messaggio_client[4] + "\n";
                        File.AppendAllText(path, lineappend);

                        break;

                    case "lista_bonifici":

                        Console.WriteLine("RICHIESTA LISTA BONIFICI:\n");
                        Console.WriteLine("Iban utente:");
                        messaggio_client[1] = messaggio_client[1].Substring(0, messaggio_client[1].Length - 5);
                        Console.WriteLine(messaggio_client[1]);

                        string msg_nonesiste = "";
                        string msg_bonifici = "";
                        path = "BONIFICI/" + messaggio_client[1] + ".txt";
                        if (File.Exists(path))
                        {
                            string[] lines_bon = File.ReadAllLines(path);
                            string[] info_bon = new string[20];
                            foreach (string line in lines_bon.Reverse())
                            {
                                info_bon = line.Split(';');
                                msg_bonifici = msg_bonifici + info_bon[0] + ";" + info_bon[1] + ";" + info_bon[2] + ";" + info_bon[3] + ";" + info_bon[4] + ";" + info_bon[5] + ";" + info_bon[6] + ";" + info_bon[7] + ";" + info_bon[8] + "$";
                            }
                            msg_list_bon = Encoding.ASCII.GetBytes(msg_bonifici);
                            handler.Send(msg_list_bon);
                            handler.Shutdown(SocketShutdown.Both);
                            handler.Close();
                        }
                        else
                        {
                            msg_nonesiste = "non_esiste";
                            // Echo the data back to the client.  
                            byte[] msg_no_bon = Encoding.ASCII.GetBytes(msg_nonesiste);
                            handler.Send(msg_no_bon);
                            handler.Shutdown(SocketShutdown.Both);
                            handler.Close();
                        }

                        break;

                    case "lista_ricariche":

                        Console.WriteLine("RICHIESTA LISTA RICARICHE:\n");
                        Console.WriteLine("Iban utente:");
                        messaggio_client[1] = messaggio_client[1].Substring(0, messaggio_client[1].Length - 5);
                        Console.WriteLine(messaggio_client[1]);

                        msg_nonesiste = "";
                        string msg_ricariche = "";
                        path = "RICARICHE/" + messaggio_client[1] + ".txt";
                        if (File.Exists(path))
                        {
                            string[] lines_ric = File.ReadAllLines(path);
                            string[] info_ric = new string[5];
                            foreach (string line in lines_ric.Reverse())
                            {
                                info_ric = line.Split(';');
                                msg_ricariche = msg_ricariche + info_ric[0] + ";" + info_ric[1] + ";" + info_ric[2] + ";" + info_ric[3] + ";" + info_ric[4] + "$";
                            }
                            msg_list_ric = Encoding.ASCII.GetBytes(msg_ricariche);
                            handler.Send(msg_list_ric);
                            handler.Shutdown(SocketShutdown.Both);
                            handler.Close();
                        }
                        else
                        {
                            msg_nonesiste = "non_esiste";
                            // Echo the data back to the client.  
                            byte[] msg_no_ric = Encoding.ASCII.GetBytes(msg_nonesiste);
                            handler.Send(msg_no_ric);
                            handler.Shutdown(SocketShutdown.Both);
                            handler.Close();
                        }

                        break;
                }
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

        Console.WriteLine("\nPress ENTER to continue...");
        Console.Read();

    }

    public static int Main(String[] args)
    {
        StartListening();
        return 0;
    }
}
