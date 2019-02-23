using System;
using System.Collections.Generic;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard
{
    public class Address
    {
        public virtual string address { get; set; }
    }

    public class TAddress: Address
    {
        
    }

    public class ZAddress: Address
    {
        
    }

    public class TransactionId
    {
        public string txid { get; set; }
    }

    public class Blockhash
    {
        public string blockhash { get; set; }
    }
}
