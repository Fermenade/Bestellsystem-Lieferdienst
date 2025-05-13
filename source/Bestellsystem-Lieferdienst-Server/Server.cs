using System.Net;
using System.Net.Sockets;
using System.Text;
using bestellsystem_lieferdienst_server.BL;
using Bestellsystem_Lieferdienst_Server.BL;
using Bestellsystem_Lieferdienst_server.DAL;
using Google.Protobuf.Reflection;

namespace Bestellsystem_Lieferdienst_server;

public class Server
{
    //https://codingvision.net/c-simple-tcp-server
    //https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/sockets/tcp-classes
    static TcpListener server = new TcpListener(IPAddress.Any, 9999);
    public static List<Client> clients = new();
    public static void StartServerHandling()
    {
        server.Start();
        Console.WriteLine("Server started");
        server.AcceptTcpClient();
        while (true)
        {
            // Accept a client connection
            TcpClient client = server.AcceptTcpClient();
            Console.WriteLine("Client connected: " + client.Client.RemoteEndPoint);
            Client cl = new Client(client);
            cl.StartHandeling();
        }
        
    }
}