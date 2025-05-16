using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Bestellsystem_Lieferdienst_server.BL;

namespace Bestellsystem_Lieferdienst_Server
{

    class PendingRequest
    {
        static HashSet<PendingRequest> pendingRequests;
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
        public PendingRequest(string data)
        {
            UID = Guid.NewGuid();
            Data = data;
            
            pendingRequests.Add(this);
        }
        PendingRequest(Guid uID, string data, bool recieved)
        {
            UID = uID;
            Data = data;
            if (recieved)
            {
                pendingRequests.Remove(this);
            }
            else
            {
                //It assumes it's at the opposite 
                recieved = true;
            }
        }

        public Guid UID;
        public string Data;
        public bool Recieved = false;

        public override string ToString()
        {
            return JsonSerialize.Serialize(this);
        }
    }
}
