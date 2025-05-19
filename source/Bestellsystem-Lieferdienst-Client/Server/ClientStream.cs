using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using Client_Server_Code_Library;


namespace Bestellsystem_Lieferdienst.Server;

public class ClientStream : TcpClient
{
    private NetworkStream stream;


    private bool _clientReceiveHandlingStarted = false;
    private bool InitializeFinished = false;

    /// <summary>
    /// Starts the server tcpclient receiver.
    /// </summary>
    /// <param name="stream"></param>
    public void ReceiveMessages()
    {
        stream = GetStream();

        if (_clientReceiveHandlingStarted) throw new Exception("Client receive handling already started.");
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
                        // Connection closed
                        break;
                    }

                    string response = Encoding.UTF8.GetString(responseBuffer, 0, bytesRead);
                    MessageReceived?.Invoke(response);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error when receiving message: {ex.Message}");

                    if (ex.Message == "Unable to read data from the transport connection: An existing connection was forcibly closed by the remote host..")
                    {
                        Debug.WriteLine("Connection forcefully closed.");
                        break;
                    }
                    else
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
            }
        });
        InitializeFinished = true;
    }

    async void SendBinaryAsync(byte[] bytes)
    {
        //So normally the client won't send any information just after starting, but just to make sure that this doesn't do any problems
        //in the future here is the fix. 
        while (!InitializeFinished)
        {
            //Gud fix :thumbsup:
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

    public void MessageSendAsync(string message)
    {
        byte[] data = BinaryCoder.BinaryEncoder(message);
        SendBinaryAsync(data);
        Debug.WriteLine($"Sent message {message}");
    }
    public async Task<T> SendAndReturn<T>(string command)
    {
        PendingPackage newPackage = new PendingPackage(command);
        MessageSendAsync(JsonSerialize.Serialize(newPackage));
        string i = await newPackage.WaitForAnswer();//RequestRecieve
        return JsonSerialize.Deserialize<T>(i);
    }

    public event MessageDelegate MessageReceived;
    public delegate void MessageDelegate(string message);
}