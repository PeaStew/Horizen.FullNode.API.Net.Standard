using System;
using System.Collections.Generic;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard.RPCInputTypes
{
    public class BannedPeers
    {
        public string address { get; set; }
        public int banned_until { get; set; }
    }
}
