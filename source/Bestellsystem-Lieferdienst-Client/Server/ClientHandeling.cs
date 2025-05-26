using Client_Server_Code_Library;
using System.Diagnostics;


namespace Bestellsystem_Lieferdienst.Server;

public class Client : ClientStream
{
    public static Client client = new("127.0.0.1", 5000);
    private static bool connection = true;
    public string ip { get; private set; }
    public int port { get; private set; }
    public Client(string ip, Int32 port)
    {
        this.ip = ip;
        this.port = port;
    }

    public void ConnectToServer() => ConnectToServer(ip, port);
    public void ConnectToServer(string ip, int port)
    {
        //Generated
        BeginConnect(ip, port, ConnectCallback, this);
        void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Complete the connection
                EndConnect(ar);
                Debug.WriteLine("Connected to the server. Starting handling.");

                StartHandling();

                //TODO: Client/Server must receive a notice of the other that it got the message, else it will try again.
            }
            catch (System.Net.Sockets.SocketException)
            {
                Debug.WriteLine("Couldn't establish connection with server.");
                connection = false;
                ServerDisconnected();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    void StartHandling()
    {
        ReceiveMessages();

        try
        {
            MessageReceived += ProcessReceiveMessages;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
    void ProcessReceiveMessages(string message)
    {
        Console.WriteLine($"Received message '{message}' from server");

        Package request = JsonSerialize.Deserialize<Package>(message);

        if (!PendingPackage.isPendingPackage(request))
        {

            //This logic if this is not nativ request.
            string data = request.Data;
            try
            {
                //UserCommand command = new UserCommand(user, data);

                //request.Data = JsonSerialize.Serialize(CommandManager.ExecuteCommand(command));

                //if (request.Data == "UserHappened")
                //{
                //    string[] i = data.Split(" ");
                //    if (i[1] == "USER")
                //        user = JsonSerialize.Deserialize<User>(i[2]);
                //}
            }
            catch (Exception ex)
            {
                switch (ex.Message)
                {
                    case "Not a valid Command":
                        Console.WriteLine($"Server sent unknown command => Ignoring.");
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