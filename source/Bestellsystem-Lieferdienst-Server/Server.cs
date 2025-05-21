using Bestellsystem_Lieferdienst_Server.BL;
using System.Net;
using System.Net.Sockets;

namespace Bestellsystem_Lieferdienst_Server;

public class Server
{
    //https://codingvision.net/c-simple-tcp-server
    //https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/sockets/tcp-classes
    static TcpListener server = new(IPAddress.Any, 5000);
    public static HashSet<Client> clients = new();
    public static void StartServerHandling()
    {
        server.Start();
        Console.WriteLine("Server started");
        while (true)
        {
            Client cl = new(server.AcceptSocket());
            // Accept a client connection
            Console.WriteLine("Client connected: " + cl.Socket.RemoteEndPoint);

            clients.Add(cl);
            cl.StartHandeling();
        }

    }
}