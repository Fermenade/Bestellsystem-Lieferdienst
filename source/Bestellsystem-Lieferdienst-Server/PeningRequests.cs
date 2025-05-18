using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Bestellsystem_Lieferdienst_server.BL;
using Bestellsystem_Lieferdienst_Server.BL;
using Org.BouncyCastle.Asn1.Ocsp;

namespace Bestellsystem_Lieferdienst_Server
{
    //Generated
    class PendingPackage:Package
    {
        static Dictionary<Guid, TaskCompletionSource<string>> pendingPackages = new Dictionary<Guid, TaskCompletionSource<string>>();
        private DateTime now = DateTime.Now;

        public PendingPackage(string data):base(data)
        {
            pendingPackages.Add(this.UID,new TaskCompletionSource<string>());
        }

        public static bool isPendingPackage(Package data)
        {
            if (pendingPackages.TryGetValue(data.UID,out var value))
            {
                value.SetResult(data.Data);
                return false;
            }
            else
            {
                return true;
            }
        }

        public Task<string> WaitForAnswer()
        {
            var tcs = new TaskCompletionSource<string>();
            pendingPackages[this.UID] = tcs;
            return tcs.Task;
        }
    }
    public class Package
    {
        public Guid UID
        {
            get;
        }

        //TODO: add time out if the other does not respond within a specified time frame the package will be sent again. if that fails too connection will
        //be set into crisis mode (e.g. popup that tells user that connection was lost.)


        //TODO: fixme


        //Ok here is the basic idea:

        //Since I want to get sure that the client and server are operating in *cooperation* every package the

        //client/server sends get signed, so that multiple packages can be sent and the client/client won't get confused about which

        //package belongs to which client/server request.

        //Horrible explained ik. but idc.


        //So how is my approach?

        //Well currently I don't really have a correct solution in my head. (maybe some sleep will help)

        //The plan is this: (but I have no idea if this will work)

        //The flow would look something like this:
        //Information should be sent -> Information gets packed into a package which has a guid to identify.
        //-> Information gets sent - code will await the return -> client/server gets the package -> checks if its one of its own pending packages
        //-> if not it will execute the command -> information like package purpose was success or failure (maybe even error message)
        //-> server/client send the updated package back -> client/server checks if it's one of its own pending packages
        //-> if it is, it will give the waiting code the promised values and dispose the package.


        //Update: So, past me wasn't so stupid as I thought.

        //However, I still don't have a completely thought out approach. Maybe look at some Stackoverflow.

        public Package(string data)
        {
            UID = Guid.NewGuid();
            Data = data;
        }


        //This logic assumes that Data will only write NOT read by the sender and the receiver will only read not write.
        //Ok past me was an Idiot. When the receiver has to send data back it will write into the data.
        public string Data;

        public string? ErrorMessage;

        public override string ToString()
        {
            return JsonSerialize.Serialize(this);
        }
    }
}