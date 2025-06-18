using Bestellsystem_Lieferdienst_Client.BL;
using Bestellsystem_Lieferdienst_Client.PL;
using Client_Server_Code_Library;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;


namespace Bestellsystem_Lieferdienst_Client.Server;

public class ClientStream : TcpClient
{
    private NetworkStream stream;


    private bool _clientReceiveHandlingStarted = false;
    public bool InitializeFinished = false;

    /// <summary>
    /// Starts the server tcpclient receiver.
    /// </summary>
    /// <param name="stream"></param>
    public void ReceiveMessages()
    {
        stream = GetStream();

        if (_clientReceiveHandlingStarted) throw new Exception("Client receive handling already started.");
        _clientReceiveHandlingStarted = true;
        byte[] responseBuffer = new byte[10000]; //TODO: check if this is long enough.
        Task.Run(() =>
        {
            while (true)
            {
                try
                {
                    int bytesRead = stream.Read(responseBuffer, 0, responseBuffer.Length);
                    if (bytesRead == 0)
                    {
                        throw new IOException();
                    }

                    string response = Encoding.UTF8.GetString(responseBuffer, 0, bytesRead);
                    MessageReceived?.Invoke(response);
                }
                catch (IOException ex)
                {
                    Debug.WriteLine("Connection forcefully closed.");
                    ServerDisconnected();
                    //TODO:fixme
                    break;
                }
            }
        });
        InitializeFinished = true;
    }
    async void SendBinary(byte[] bytes)
    {
        //So normally the client won't send any information just after starting, but just to make sure that this doesn't do any problems
        //in the future here is the fix.
        if (!Client.Connected) return;
        while (!InitializeFinished)
        {
        }


        try
        {
            await stream.WriteAsync(bytes);
        }
        catch (Exception e)
        {
            throw; // TODO handle exception
        }
    }

    public void ServerDisconnected()
    {
        if (Program.form.InvokeRequired)
        {
            try
            {
                Program.form.Invoke(ServerDisconnected); //This is because, a call of ServerDisconnected would cause a cross thread exception.
            }
            catch (System.ObjectDisposedException)
            {
            }
        }
        else
        {
            Program.form.LoadView(new ConnectionLost());
        }
    }

    public void MessageSend(string message)
    {
        byte[] data = BinaryCoder.BinaryEncoder(message);
        SendBinary(data);
        Debug.WriteLine($"Sent message {message}");
    }

    //public T SendAndReturn<T>(string command) => Task.Run(() => SendAndReturnAsync<T>(command)).Result;


    public async Task<T> SendAndReturnAsync<T>(string command)
    {
        PendingPackage newPackage = new PendingPackage(command);
        MessageSend(JsonSerialize.Serialize(newPackage));

        Package package = await newPackage.WaitForAnswerAsync().ConfigureAwait(false);
        if (package.ErrorMessage != null)
        {
            if (package.Data != null)
            {
                throw new Exception("Package error and package data was not null");
            }
        }
        if (package.ErrorMessage != null)
        {
            if (package.ErrorMessage.Substring(0,
                    "MySql.Data.MySqlClient.MySqlException (0x80004005): Unable to connect to any of the specified MySQL hosts\r\n ---> System.Net.Sockets.SocketException (10061): No connection could be made because the target machine actively refused it."
                        .Length) ==
                "MySql.Data.MySqlClient.MySqlException (0x80004005): Unable to connect to any of the specified MySQL hosts\r\n ---> System.Net.Sockets.SocketException (10061): No connection could be made because the target machine actively refused it.")
            {
                MessageBox.Show("Database connection connte nicht hergestellt werden.");
                return default;
            }
            throw new Exception(package.ErrorMessage);
        }
        if (package.ErrorMessage == null)
        {
            if (package.Data == null)
            {
                throw new Exception("Package error and package data was null");
            }
        }
        return JsonSerialize.Deserialize<T>(package.Data);
    }

    public event MessageDelegate MessageReceived;
    public delegate void MessageDelegate(string message);
}