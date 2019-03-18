using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard.RPCReturnTypes
{
    #region Network

    public enum AddNodeCommand
    {
        [Description("ADD")]
        Add,
        [Description("REMOVE")]
        Remove,
        [Description("ONETRY")]
        Onetry
    }

    public class AddedNodeResult
    {
        public string addednode { get; set; }
        public bool connected { get; set; }
        public IList<Address> addresses { get; set; }

        public class Address
        {
            public string address { get; set; }
            public string connected { get; set; }
        }
    }

    public class GetNetTotalsResult
    {
        public int totalbytesrecv { get; set; }
        public int totalbytessent { get; set; }
        public long timemillis { get; set; }
    }


    public class GetNetworkInfoResult
    {
        public int version { get; set; }
        public string subversion { get; set; }
        public int protocolversion { get; set; }
        public string localservices { get; set; }
        public int timeoffset { get; set; }
        public int connections { get; set; }
        public bool tls_cert_verified { get; set; }
        public Network[] networks { get; set; }
        public double relayfee { get; set; }
        public Localaddress[] localaddresses { get; set; }
        public string warnings { get; set; }

        public class Network
        {
            public string name { get; set; }
            public bool limited { get; set; }
            public bool reachable { get; set; }
            public string proxy { get; set; }
            public bool proxy_randomize_credentials { get; set; }
        }

        public class Localaddress
        {
            public string address { get; set; }
            public int port { get; set; }
            public int score { get; set; }
        }
    }



    public class PeerInfoResult
    {
        public int id { get; set; }
        public string addr { get; set; }
        public string addrlocal { get; set; }
        public string services { get; set; }
        public bool tls_established { get; set; }
        public bool tls_verified { get; set; }
        public int lastsend { get; set; }
        public int lastrecv { get; set; }
        public int bytessent { get; set; }
        public int bytesrecv { get; set; }
        public int conntime { get; set; }
        public int timeoffset { get; set; }
        public double pingtime { get; set; }
        public int version { get; set; }
        public string subver { get; set; }
        public bool inbound { get; set; }
        public int startingheight { get; set; }
        public int banscore { get; set; }
        public int synced_headers { get; set; }
        public int synced_blocks { get; set; }
        public object[] inflight { get; set; }
        public bool whitelisted { get; set; }
    }

    public enum SetBanCommand
    {
        [Description("ADD")]
        Add,
        [Description("REMOVE")]
        Remove
    }


    public class BannedPeersResult
    {
        public string address { get; set; }
        public int banned_until { get; set; }
    }
    #endregion
}
