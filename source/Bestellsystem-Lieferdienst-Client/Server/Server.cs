using Bestellsystem_Lieferdienst_server.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem_Lieferdienst.Server
{
    public class Server
    {
        static TcpClient tcpClient = new TcpClient();
        public static void ConnectToServer()
        {
            //Generated
            tcpClient.BeginConnect(IPAddress.Broadcast, 9999, ar => {
                if (ar.IsCompleted)
                {
                    // Connection established successfully
                    NetworkStream networkStream = tcpClient.GetStream();

                    byte[] buffer = Encoding.ASCII.GetBytes("Ping");
                    networkStream.BeginWrite(buffer, 0, buffer.Length, ar2 => {
                        // Write operation completed
                        Console.WriteLine("Data sent.");
                        tcpClient.Close();
                    }, null);
                }
                else
                {
                    Console.WriteLine("Connection failed");
                }
            }, null);
        }
        static async void SendBytesAsync(byte[] bytes)
        {
            NetworkStream i = tcpClient.GetStream();
            await i.WriteAsync(bytes);
        }
    }
}
