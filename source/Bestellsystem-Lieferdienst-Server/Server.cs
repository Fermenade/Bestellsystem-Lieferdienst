using Bestellsystem_Lieferdienst_Server.BL;
using System.Net;
using System.Net.Sockets;

namespace Bestellsystem_Lieferdienst_server;

public class Server
{
    //https://codingvision.net/c-simple-tcp-server
    //https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/sockets/tcp-classes
    static TcpListener server = new(IPAddress.Any, 5000);
    public static List<Client> clients = new();
    public static void StartServerHandling()
    {
        server.Start();
        Console.WriteLine("Server started");
        while (true)
        {
            // Accept a client connection
            TcpClient client = server.AcceptTcpClient();
            Console.WriteLine("Client connected: " + client.Client.RemoteEndPoint);
            Client cl = new Client(client);
            clients.Add(cl);
            cl.StartHandeling();
        }

    }
}