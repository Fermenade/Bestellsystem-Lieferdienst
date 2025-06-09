using Client_Server_Code_Library;
using System.Net.Sockets;
using System.Text;

namespace Bestellsystem_Lieferdienst_Server.BL;

public class ClientStream(Socket client) : NetworkStream(client, true)
{

    private bool _clientReceiveHandlingStarted = false;
    /// <summary>
    /// Starts the server client receiver.
    /// </summary>
    /// <param name="stream"></param>
    public void ReceiveMessages()
    {

        if (_clientReceiveHandlingStarted) throw new Exception("Client receive handling already started.");
        _clientReceiveHandlingStarted = true;
        byte[] responseBuffer = new byte[10000]; //TODO: check if this is long enough.
        Task.Run(() =>
        {
            while (true)
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
        string i = await newPackage.WaitForAnswerAsync();//RequestRecieve
        return JsonSerialize.Deserialize<T>(i);
    }

    public event MessageDelegate MessageReceived;
    public delegate void MessageDelegate(string message);
    public event DisconnectedDelegate ClientDisconnected;
    public delegate void DisconnectedDelegate();
}