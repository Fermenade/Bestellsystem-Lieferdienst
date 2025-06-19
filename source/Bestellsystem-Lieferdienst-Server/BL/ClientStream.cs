using Client_Server_Code_Library;
using System.Net.Sockets;
using System.Text;

namespace Bestellsystem_Lieferdienst_Server.BL;

public class ClientStream(Socket client) : NetworkStream(client, true)
{
    public bool handleClient = true;
    private bool _clientReceiveHandlingStarted = false;
    /// <summary>
    /// Starts the server client receiver.
    /// </summary>
    /// <param name="stream"></param>
    public void ReceiveMessages()
    {

        if (_clientReceiveHandlingStarted) throw new Exception("Client receive handling already started.");
        _clientReceiveHandlingStarted = true;
        byte[] responseBuffer = new byte[ServerClientConfig.streamsize];
        Task.Run(() =>
        {
            while (handleClient)
            {
                try
                {
                    int bytesRead = Read(responseBuffer, 0, responseBuffer.Length);
                    if (bytesRead == 0)
                    {
                        ClientDisconnected.Invoke();
                        // Connection closed
                        break;
                    }

                    string response = Encoding.UTF8.GetString(responseBuffer, 0, bytesRead);
                    MessageReceived?.Invoke(response);
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Error when receiving message: {ex.Message}");

                    Console.WriteLine("Client forcibly close the connection.\nExiting..");
                    ClientDisconnected.Invoke();
                    break;
                }
            }
        });
    }


    async void SendBinaryAsync(byte[] bytes)
    {
        await WriteAsync(bytes);
    }

    public void MessageSendAsync(string message)
    {
        byte[] data = BinaryCoder.BinaryEncoder(message);
        SendBinaryAsync(data);
        Console.WriteLine(BinaryCoder.BinaryDecoder(data));
        Console.WriteLine($"Sent message '{message}' to '{client.RemoteEndPoint}'");
    }
    public async Task<T> SendAndReturn<T>(string command)
    {
        PendingPackage newPackage = new PendingPackage(command);
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

    protected void OnClientDisconnected()
    {
        ClientDisconnected.Invoke();
    }

    public event MessageDelegate MessageReceived;
    public delegate void MessageDelegate(string message);
    public event DisconnectedDelegate ClientDisconnected;
    public delegate void DisconnectedDelegate();
}