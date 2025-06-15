using Bestellsystem_Lieferdienst_Client.BL;
using Bestellsystem_Lieferdienst_Client.PL;
using Client_Server_Code_Library;
using System.Diagnostics;


namespace Bestellsystem_Lieferdienst_Client.Server;

public class Client : ClientStream
{
    public static Client client = new("127.0.0.1", 5000);
    public User? User = null;
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

                Task.Run(ServerConnected);
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
    void ServerConnected()
    {
        while (!Program.form.IsHandleCreated)//This crazy hack is needed so that a cross thread exception is solved out of whatever reason.
        { } //Btw. this one line took only 5 days to figure out.
        if (Program.form.InvokeRequired)
        {
            try
            {
                Program.form.Invoke(ServerConnected); // Use Action delegate
            }
            catch (System.ObjectDisposedException)
            {
                // Handle the case where the form is disposed
            }
        }
        else
        {

            Program.form.LoadView(new StartForm());
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
        Debug.WriteLine($"Received message '{message}' from server");
        Package request;
        try
        {
            request = JsonSerialize.Deserialize<Package>(message);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return;
        }

        bool isPendingPackage;
        try
        {
            isPendingPackage = PendingPackage.isPendingPackage(request);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return;
        }

        if (!isPendingPackage)
        {
            //This logic if this is not nativ request.
            string data = request.Data;
            try
            {
                //UserCommand command = new UserCommand(user, data);

                //request.ServerData = JsonSerialize.Serialize(CommandManager.ExecuteCommand(command));

                //if (request.ServerData == "UserHappened")
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

            MessageSend(request.ToString());
        }

    }
}