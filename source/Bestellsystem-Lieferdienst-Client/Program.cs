using Bestellsystem_Lieferdienst;
using Bestellsystem_Lieferdienst.Server;

namespace Bestellsystem_Lieferdienst_Client
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static Form form = new MainForm();

        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Client.client.ConnectToServer();

            Application.Run(form);

            // // Connect to the server on localhost and port 5000
            // TcpClient tcpclient = new TcpClient("127.0.0.1", 5000);
            // Console.WriteLine("Connected to server.");
            //
            // // Get the stream to read/write data
            // NetworkStream stream = tcpclient.GetStream();
            //
            // // Send a message to the server
            // string message = "Hello from tcpclient!";
            // byte[] data = Encoding.UTF8.GetBytes(message);
            // stream.Write(data, 0, data.Length);
            // Console.WriteLine("Message sent: " + message);
            //
            // // Read the response from the server
            // byte[] buffer = new byte[1024];
            // int bytesRead = stream.Read(buffer, 0, buffer.Length);
            // string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            // Console.WriteLine("Received from server: " + response);
            //
            // // Close the connection
            // tcpclient.Close();
        }
    }
}