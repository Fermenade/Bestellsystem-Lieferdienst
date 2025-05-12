using System.Net.Sockets;
using System.Text;
using Bestellsystem_Lieferdienst_server.BL;

namespace Bestellsystem_Lieferdienst_Server.BL;

public class ClientStream(TcpClient client)
{
    private NetworkStream stream = client.GetStream();
    
    private bool _clientReceiveHandlingStarted = false;
    /// <summary>
    /// Starts the server client receiver.
    /// </summary>
    /// <param name="stream"></param>
    public void ReceiveMessages()
    {
        if(_clientReceiveHandlingStarted)throw new Exception("Client receive handling already started.");
        _clientReceiveHandlingStarted = true;
        byte[] responseBuffer = new byte[1024]; //TODO: check if this is long enough.
        Task.Run(() =>
        {
            while (true)
            {
                try
                {
                    int bytesRead = stream.Read(responseBuffer, 0, responseBuffer.Length);
                    if (bytesRead == 0)
                    {
                        ClientDisconnected.Invoke();
                        // Connection closed
                        break;
                    }

                    string response = Encoding.UTF8.GetString(responseBuffer, 0, bytesRead);
                    MessageReceived?.Invoke(response);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fehler beim Empfangen von Nachrichten: {ex.Message}");
                }
            }
        });
    }

    async void SendBinaryAsync(byte[] bytes)
    {
        await stream.WriteAsync(bytes);
    }

    public void MessageSendAsync(string message)
    {
        byte[] data = BinaryCoder.BinaryEncoder(message);
        SendBinaryAsync(data);
        Console.WriteLine($"Sent message '{message}' to '{client.Client.RemoteEndPoint}'");
    }

    public event MessageDelegate MessageReceived;
    public delegate void MessageDelegate(string message);
    public event DisconnectedDelegate ClientDisconnected;
    public delegate void DisconnectedDelegate();
}