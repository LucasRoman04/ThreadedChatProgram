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
            string message = messageTextBox.Text;

            if (!string.IsNullOrEmpty(message))
            {
                // Display the message in the chatTextBox.
                DisplayMessage(message);

                // Send the message to the server (if you are the client).
                if (!isServerRunning)
                {
                    SendMessageToServer(message);
                }

                // Clear the input box.
                messageTextBox.Text = "";
            }
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

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void convTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void disconnectMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DisplayMessage(string message)
        {
            if (convTextBox.InvokeRequired)
            {
                convTextBox.Invoke((MethodInvoker)(() =>
                {
                    convTextBox.AppendText(message + Environment.NewLine);
                }));
            }
            else
            {
                convTextBox.AppendText(message + Environment.NewLine);
            }
        }

        private void RunServer(int port = 13000)
        {
            Task.Run(() =>
            {
                try
                {
                    // Set the TcpListener on port 13000.
                    IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                    server = new TcpListener(localAddr, port);
                    server.Start();
                    isServerRunning = true; // Indicate that the server is running

                    Byte[] bytes = new Byte[256];
                    String data = null;

                    while (true)
                    {
                        Console.Write("Waiting for a connection... ");

                        TcpClient client = server.AcceptTcpClient();
                        Console.WriteLine("Connected!");

                        data = null;

                        stream = client.GetStream();

                        int i;

                        while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                            Console.WriteLine("Received: {0}", data);

                            // Process the data sent by the client.
                            data = data.ToUpper();

                            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                            // Display the received message in the chatTextBox.
                            DisplayMessage("Client: " + data + "\n");

                            // Send back a response.
                            stream.Write(msg, 0, msg.Length);
                            Console.WriteLine("Sent: {0}", data);
                        }

                        // Handle disconnection by breaking out of the inner loop
                        Console.WriteLine("Client disconnected.");
                    }
                }
                catch (SocketException e)
                {
                    Console.WriteLine("SocketException: {0}", e);
                }
                finally
                {
                    server.Stop();
                }
            });
        }

        private void RunClient(String server, String message)
        {
            try
            {
                Int32 port = 13000;
                TcpClient client = new TcpClient(server, port);
                isServerRunning = true; // Indicate that the client is connected to the server

                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                NetworkStream stream = client.GetStream();

                data = new Byte[256];

                // String to store the response ASCII representation.
                String responseData = String.Empty;

                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                Console.WriteLine("Received: {0}", responseData);

                // Send the message to the server.
                stream.Write(data, 0, data.Length);
                DisplayMessage("Client: " + message + "\n");

                Console.WriteLine(">> {0}", message);

                // Receive the server's response.
                while ((bytes = stream.Read(data, 0, data.Length)) != 0)
                {
                    responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                    DisplayMessage("Server: " + responseData);
                }

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
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Console.WriteLine("\n Press Enter to continue...");
            Console.Read();
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

        private void SendMessageToServer(string message)
        {
            try
            {
                // Translate the message into ASCII and send it to the server.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                if (stream != null)
                {
                    stream.Write(data, 0, data.Length);
                    DisplayMessage("You: " + message); // Display the sent message in the chat box
                }
                else
                {
                    MessageBox.Show("Not connected to the server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error sending message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
