﻿using System;
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
                        Console.WriteLine("Iban utente:");
                        Console.WriteLine(messaggio_client[1]);
                        Console.WriteLine("Iban beneficiario:");
                        Console.WriteLine(messaggio_client[2]);
                        Console.WriteLine("Importo:");
                        Console.WriteLine(messaggio_client[3]);
                        Console.WriteLine("Casuale:");
                        Console.WriteLine(messaggio_client[5]);
                        lines = File.ReadAllLines("clienti.txt");
                        info = new string[9];
                        using (StreamWriter sw = new StreamWriter("clienti.txt"))
                        {
                            foreach (string line in lines)
                            {
                                info = line.Split(';');
                                if (messaggio_client[1] == info[4])
                                {
                                    //sw.WriteLine(info[0] + ';' + info[1] + ';' + info[2] + ';' + info[3] + ';' + info[4] + ';' + messaggio_client[4] + ';' + messaggio_client[4] + ';' + info[7] + ';' + info[8]);
                                    break;
                                }
                            }
                        }
                        string folderName = messaggio_client[1];
                        string pathString = Path.Combine(folderName, "C:\\Users\\UTENTE\\source\repos\\MilesiSimone\\Progetto_Banca\\Progetto_Banca_Server\\Progetto_Banca_Server\\bin\\Debug\\net6.0\\bonifici");
                        if (!Directory.Exists(pathString))
                        {
                            Directory.CreateDirectory(pathString);
                            using (FileStream fs = File.Create(pathString))
                            {
                                //File.AppendAllLines(pathString, messaggio_client[2]);
                            }
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
