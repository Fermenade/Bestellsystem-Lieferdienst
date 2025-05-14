using System.Net.Sockets;
using Bestellsystem_Lieferdienst_server;
using bestellsystem_lieferdienst_server.BL;
using Org.BouncyCastle.Tls;

namespace Bestellsystem_Lieferdienst_Server.BL;

public class Client(TcpClient client):ClientStream(client)
{
    private User? user;
    public void StartHandeling()
    {
        ReceiveMessages();
        Server.clients.Add(this);
        try
        {
            MessageReceived += ProcessReceiveMessages;
            ClientDisconnected += ProcessClientDisconnected;
            // Get the stream to read/write data
            // Send a response back to the client
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message + "\n Exiting...");
            ProcessClientDisconnected();
        }
    }

    void ProcessClientDisconnected()
    {
        MessageReceived -= ProcessReceiveMessages;
        ClientDisconnected -= ProcessClientDisconnected;
        // Remove the client from the list and close the connection
        Server.clients.Remove(this);
        Console.WriteLine("Client disconnected: " + client.Client.RemoteEndPoint);
        client.Close();
    }
    void ProcessReceiveMessages(string message)
    {
        Console.WriteLine($"Received message '{message}' from '{client.Client.RemoteEndPoint}'");
        try
        {
            UserCommand command = new UserCommand(message);
            CommandManager.ExecuteCommand(command);
        }
        catch (Exception ex)
        {
            if (ex.Message == "Not a valid Command")
            {
                Console.WriteLine($"Client {client.Client.RemoteEndPoint} sent unknown command => Ignoring.");
            }
        }
    }
}