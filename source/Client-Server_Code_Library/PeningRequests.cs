using Newtonsoft.Json;

namespace Client_Server_Code_Library;
//Generated
public class PendingPackage : Package
{
    static Dictionary<Guid, TaskCompletionSource<string>> pendingPackages = new();
    public PendingPackage(string data) : base(data)
    {
        pendingPackages.Add(this.UID, new TaskCompletionSource<string>());
    }

    public static bool isPendingPackage(Package data)
    {
        if (pendingPackages.TryGetValue(data.UID, out TaskCompletionSource<string> value))
        {
            value.SetResult(data.Data);
            //Result is set
            pendingPackages.Remove(data.UID);
            return true;
        }
        return false;
    }

    public Task<string> WaitForAnswerAsync()
    {
        return pendingPackages[this.UID].Task; // Return the existing Task
    }
}
public class Package
{
    public Guid UID;


    //Ok here is the basic idea:

    //Since I want to get sure that the tcpclient and server are operating in *cooperation* every package the

    //tcpclient/server sends get signed, so that multiple packages can be sent and the tcpclient/tcpclient won't get confused about which

    //package belongs to which tcpclient/server request.

    //Horrible explained ik. but idc.


    //So how is my approach?

    //Well currently I don't really have a correct solution in my head. (maybe some sleep will help)

    //The plan is this: (but I have no idea if this will work)

    //The flow would look something like this:
    //Information should be sent -> Information gets packed into a package which has a guid to identify.
    //-> Information gets sent - code will await the return -> tcpclient/server gets the package -> checks if its one of its own pending packages
    //-> if not it will execute the command -> information like package purpose was success or failure (maybe even error message)
    //-> server/tcpclient send the updated package back -> tcpclient/server checks if it's one of its own pending packages
    //-> if it is, it will give the waiting code the promised values and dispose the package.


    //Update: So, past me wasn't so stupid as I thought.

    //However, I still don't have a completely thought out approach. Maybe look at some Stackoverflow.

    public Package(string data)
    {
        UID = Guid.NewGuid();
        Data = data;
    }

    [JsonConstructor]
    public Package(Guid guid, string data, string errorMessage)
    {
        this.UID = guid;
        this.Data = data;
        this.ErrorMessage = errorMessage;
    }


    //This logic assumes that Data will only write NOT read by the sender and the receiver will only read not write.
    //Ok past me was an Idiot. When the receiver has to send data back it will write into the data.
    public string? Data;

    public string? ErrorMessage;

    public override string ToString()
    {
        return JsonSerialize.Serialize(this);
    }
}