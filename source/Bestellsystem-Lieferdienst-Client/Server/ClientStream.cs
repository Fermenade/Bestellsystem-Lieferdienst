using Bestellsystem_Lieferdienst.PL;
using Bestellsystem_Lieferdienst_Client;
using Client_Server_Code_Library;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;


namespace Bestellsystem_Lieferdienst.Server;

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
                        // Connection closed
                        break;
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

    async void SendBinaryAsync(byte[] bytes)
    {
        //So normally the client won't send any information just after starting, but just to make sure that this doesn't do any problems
        //in the future here is the fix.

        while (!InitializeFinished)
        {
            //TODO:fixme
            //Gud fix :thumbsup:
        }
        if (!Connected)
        {
            ServerDisconnected();
            return;
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
        Program.form.LoadView(new ConnectionLost());
    }

    public void MessageSendAsync(string message)
    {
        byte[] data = BinaryCoder.BinaryEncoder(message);
        SendBinaryAsync(data);
        Debug.WriteLine($"Sent message {message}");
    }

    public T SendAndReturn<T>(string command) => SendAndReturnAsync<T>(command).Result;
    //private async Task<T> SendAndReturnAsync<T>(string command)
    //{
    //    PendingPackage newPackage = new PendingPackage(command);
    //    MessageSendAsync(JsonSerialize.Serialize(newPackage));
    //    string i = await Task.Run(() =>
    //    {//It just works
    //        var x = newPackage.WaitForAnswer();
    //        int o = 0;
    //        while (!x.IsCompleted)
    //        {
    //            //TODO: Why does this work and not the other???
    //            Debug.WriteLine(o);
    //            o++;
    //        }

    //        return x.Result;
    //    });
    //    return JsonSerialize.Deserialize<T>(i);
    //}
    private Task<T> SendAndReturnAsync<T>(string command)
    {
        PendingPackage newPackage = new PendingPackage(command);
        MessageSendAsync(JsonSerialize.Serialize(newPackage));

        // Create a task that will complete when newPackage.WaitForAnswer() is done
        return Task.Run(() =>
        {
            var x = newPackage.WaitForAnswer();
            while (!x.IsCompleted)
            {
                // Optionally, you can add a small delay to prevent busy waiting
                Thread.Sleep(10); // Sleep for 10 milliseconds
            }

            return JsonSerialize.Deserialize<T>(x.Result);
        });
    }

    public event MessageDelegate MessageReceived;
    public delegate void MessageDelegate(string message);
}