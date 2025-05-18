using bestellsystem_lieferdienst_server.BL;
using Bestellsystem_Lieferdienst_server;
using System.Net.Sockets;
using Bestellsystem_Lieferdienst_server.BL;
using System.Collections.Generic;

namespace Bestellsystem_Lieferdienst_Server.BL;

public class Client(TcpClient client) : ClientStream(client)
{
    public User? user = null;
    public void StartHandeling()
    {
        ReceiveMessages();
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

        Package request = JsonSerialize.Deserialize<Package>(message);

        if (PendingPackage.isPendingPackage(request))
        {

            //This logic if this is not nativ request.
            string data = request.Data;
            try
            {
                UserCommand command = new UserCommand(user, data);

                request.Data = JsonSerialize.Serialize(CommandManager.ExecuteCommand(command));

                if (request.Data == "UserHappened")
                {
                    string[] i = data.Split(" ");
                    if (i[1] == "USER")
                        user = JsonSerialize.Deserialize<User>(i[2]);
                }
            }
            catch (Exception ex)
            {
                switch (ex.Message)
                {
                    case "Not a valid Command":
                        Console.WriteLine($"Client {client.Client.RemoteEndPoint} sent unknown command => Ignoring.");
                        break;
                    default:
                        request.ErrorMessage = $"{ex}\n{ex.Message}";
                        break;
                }
            }

            MessageSendAsync(request.ToString());
        }
    }
}