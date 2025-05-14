using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Bestellsystem_Lieferdienst.Server
{
    public class Server
    {
        static TcpClient tcpClient = new TcpClient();
        public static void ConnectToServer()
        {
            //Generated
            tcpClient.BeginConnect("127.0.0.1", 5000, new AsyncCallback(ConnectCallback), tcpClient);
            void ConnectCallback(IAsyncResult ar)
            {
                try
                {
                    // Complete the connection
                    tcpClient.EndConnect(ar);
                    Console.WriteLine("Connected to the server.");

                    // Get the stream for reading and writing

                    // Send a message to the server
                    SendBytesAsync("Moin"u8.ToArray());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
        }
        static async void SendBytesAsync(byte[] bytes)
        {
            NetworkStream i = tcpClient.GetStream();
            await i.WriteAsync(bytes);
        }
    }
}
