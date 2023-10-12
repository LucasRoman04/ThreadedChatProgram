using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        // Fields for handling server and client connections
        private TcpListener server;
        private TcpClient client;
        private NetworkStream clientStream;
        private bool isServerRunning = false;

        public Form1()
        {
            InitializeComponent();
            // Attach event handlers
            exitMenuOption.Click += exitMenuOption_Click;  // Handle the exitMenuOption click event
            disconnectMenuItem.Click += disconnectMenuItem_Click;  // Handle the disconnectMenuItem click event
        }

        private void exitMenuOption_Click(object sender, EventArgs e)
        {
            ExitApplication();  // Call the method to exit the application
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text;

            if (!string.IsNullOrEmpty(message))
            {
                DisplayMessage("You: " + message);

                if (!isServerRunning)
                {
                    await SendMessageToServer(message);  // Send the message to the server
                }
                else
                {
                    await SendMessageToClient(message);  // Send the message to the client
                }

                messageTextBox.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void serverMenuOption_Click(object sender, EventArgs ea)
        {
            await RunServerAsync();  // Call the method to run the server asynchronously
        }

        private async void clientMenuOption_Click(object sender, EventArgs e)
        {
            await RunClientAsync("127.0.0.1");  // Call the method to run the client asynchronously with the specified server address
        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void convTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void disconnectMenuItem_Click(object sender, EventArgs e)
        {
            DisconnectClient();  // Call the method to disconnect the client
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

        private async Task RunServerAsync(int port = 13000)
        {
            if (!isServerRunning)
            {
                isServerRunning = true;
                server = new TcpListener(IPAddress.Parse("127.0.0.1"), 13000);
                server.Start();

                client = await server.AcceptTcpClientAsync();  // Accept a client connection asynchronously
                clientStream = client.GetStream();

                _ = HandleClientAsync();  // Start handling client messages asynchronously
            }
        }

        private async Task HandleClientAsync()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            try
            {
                while ((bytesRead = await clientStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    DisplayMessage("Client: " + message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                client.Close();  // Close the client connection
                isServerRunning = false;  // Update the server status
            }
        }

        private async Task RunClientAsync(string server)
        {
            client = new TcpClient();
            await client.ConnectAsync(server, 13000);  // Connect to the specified server asynchronously
            clientStream = client.GetStream();

            _ = HandleServerAsync();  // Start handling server messages asynchronously
        }

        private async Task HandleServerAsync()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            try
            {
                while ((bytesRead = await clientStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    DisplayMessage("Server: " + message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void ExitApplication()
        {
            isServerRunning = false;
            server?.Stop();  // Stop the server
            client?.Close();  // Close the client connection
            this.Close();  // Close the application
        }

        private void DisconnectClient()
        {
            if (client != null)
            {
                client.Close();  // Close the client connection
                isServerRunning = false;  // Update the server status
                client = null;  // Set the client to null
                clientStream = null;  // Set the clientStream to null
            }
        }

        private async Task SendMessageToServer(string message)
        {
            try
            {
                if (clientStream != null)
                {
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    await clientStream.WriteAsync(data, 0, data.Length);  // Send the message to the server asynchronously
                }
                else
                {
                    MessageBox.Show("Not connected to the server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending message: " + ex.Message);
            }
        }

        private async Task SendMessageToClient(string message)
        {
            try
            {
                if (clientStream != null)
                {
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    await clientStream.WriteAsync(data, 0, data.Length);  // Send the message to the client asynchronously
                }
                else
                {
                    MessageBox.Show("Not connected to the client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending message: " + ex.Message);
            }
        }
    }
}