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
using System.Security.Cryptography.X509Certificates;

namespace Assignment_1
{
    public partial class Form1 : Form
    {

        private TcpListener server;
        private TcpClient client;
        private NetworkStream stream;
        private bool isServerRunning = false;

        public Form1()
        {
            InitializeComponent();
            exitMenuOption.Click += exitMenuOption_Click;
        }

        private void exitMenuOption_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void serverMenuOption_Click(object sender, EventArgs ea)
        {
            RunServer();
        }

        private void clientMenuOption_Click(object sender, EventArgs e)
        {
            RunClient("127.0.0.1", "Hello From Client!");
        }

        private void connectMenuItem_Click(object sender, EventArgs e)
        {
            ConnectServer();
        }

        private void disconnectMenuItem_Click(object sender, EventArgs e)
        {
            DisconnectServer();
        }

        private void RunServer(int port = 13000)
        {
            Task.Run(() =>
            {
                TcpListener server = null;
                try
                {
                    // Set the TcpListener on port 13000.
                    // Int32 port = 13000;
                    IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                    // TcpListener server = new TcpListener(port);
                    server = new TcpListener(localAddr, port);

                    // Start listening for client requests.
                    server.Start();
                    isServerRunning = true; // Indicate that the server is running

                    // Buffer for reading data
                    Byte[] bytes = new Byte[256];
                    String data = null;

                    // Enter the listening loop.
                    while (true)
                    {
                        Console.Write("Waiting for a connection... ");

                        // Perform a blocking call to accept requests.
                        // You could also user server.AcceptSocket() here.
                        TcpClient client = server.AcceptTcpClient();
                        Console.WriteLine("Connected!");
                        // HandleClient(client);

                        data = null;

                        // Get a stream object for reading and writing
                        NetworkStream stream = client.GetStream();

                        int i;

                        // Loop to receive all the data sent by the client.
                        while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            // Translate data bytes to a ASCII string.
                            data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                            Console.WriteLine("Received: {0}", data);

                            // Process the data sent by the client.
                            data = data.ToUpper();

                            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                            // Send back a response.
                            stream.Write(msg, 0, msg.Length);
                            Console.WriteLine("Sent: {0}", data);
                        }

                        // Shutdown and end connection
                        client.Close();
                    }
                }
                catch (SocketException e)
                {
                    Console.WriteLine("SocketException: {0}", e);
                }
                finally
                {
                    // Stop listening for new clients.
                    server.Stop();
                }

                Console.WriteLine("\nHit enter to continue...");
                Console.Read();
            });
        }

        private void RunClient(String server, String message)
        {
            try
            {
                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer 
                // connected to the same address as specified by the server, port
                // combination.
                Int32 port = 13000;
                TcpClient client = new TcpClient(server, port);
                isServerRunning = true; // Indicate that the client is connected to the server

                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // Get a client stream for reading and writing.
                //  Stream stream = client.GetStream();

                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);

                Console.WriteLine(">> {0}", message);

                // Receive the TcpServer.response.

                // Buffer to store the response bytes.
                data = new Byte[256];

                // String to store the response ASCII representation.
                String responseData = String.Empty;

                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                Console.WriteLine("Received: {0}", responseData);

                // Close everything.
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }

            Console.WriteLine("\n Press Enter to continue...");
            Console.Read();
        }

        private void DisconnectServer()
        {
            try
            {
                // For example, you can close the network stream and the client.
                if (client != null)
                {
                    stream.Close();
                    client.Close();
                    MessageBox.Show("Disconnected from the server.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Not connected to the server.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the disconnect process.
                MessageBox.Show("Error disconnecting from server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConnectServer()
        {
            // Ensure the server is running before attempting to connect
            if (isServerRunning)
            {
                try
                {
                    stream = client.GetStream();
                }

                catch (ArgumentNullException ex)
                {
                    MessageBox.Show($"Argument Null Exception: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (SocketException ex)
                {
                    MessageBox.Show($"Socket Exception: {ex.Message}");
                }

            }
            else
            {
                MessageBox.Show("Server is not running. Please start the server first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    

        private void ExitApplication()
        {
            try
            {
                // Close the main application window
                this.Close();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the exit process.
                MessageBox.Show("Error exiting application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
