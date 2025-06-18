using Client_Server_Code_Library;
using System.Diagnostics;
using System.Net.Sockets;

namespace Bestellsystem_Lieferdienst_Server.BL;

public class Client(Socket client) : ClientStream(client)
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
            OnClientDisconnected();
        }
    }
    void ProcessClientDisconnected()
    {
        MessageReceived -= ProcessReceiveMessages;
        ClientDisconnected -= ProcessClientDisconnected;
        // Remove the client from the list and close the connection
        Server.clients.Remove(this);
        Console.WriteLine("Client disconnected: " + client.RemoteEndPoint);
        Close();
    }


    void ProcessReceiveMessages(string message)
    {
        Console.WriteLine($"Received message '{message}' from '{client.RemoteEndPoint}'");
        Package request = JsonSerialize.Deserialize<Package>(message);

        if (!PendingPackage.isPendingPackage(request))
        {

            //This logic if this is not nativ request.
            string data = request.Data;
            request.Data = null;
            try
            {
                UserCommand command = new UserCommand(user, data);

                request.Data = JsonSerialize.Serialize(CommandManager.ExecuteCommand(command));

                string[] e = data.Split(" ");
                if (e[1] == "USER")
                {
                    if (e[0] == "GET")
                    {
                        if (request.Data != "null")
                            user = JsonSerialize.Deserialize<User>(request.Data);
                    }
                    else
                    {
                        user = JsonSerialize.Deserialize<User>(e[2]);
                    }
                }

            }
            catch (Exception ex)
            {
                switch (ex.Message)
                {
                    case "Not a valid Command":
                        Console.WriteLine($"Client {client.RemoteEndPoint} sent unknown command => Ignoring.");
                        request.ErrorMessage = "Unknown Command";
                        break;
                    default:
                        request.ErrorMessage = $"{ex}";
                        break;
                }
            }
            try
            {
                MessageSendAsync(request.ToString());
            }
            catch (IOException exception)
            {
                Debug.WriteLine("Connection to client was closed while processing a responce.");
                OnClientDisconnected();
            }
        }
    }
}