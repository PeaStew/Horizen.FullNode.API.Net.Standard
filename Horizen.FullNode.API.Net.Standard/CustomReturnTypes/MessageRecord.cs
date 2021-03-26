using System;
using System.Collections.Generic;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard.CustomReturnTypes
{ 
    public class MessageRecord
    {
        public int BlockId { get; set; }
        public DateTime BlockTime { get; set; }
        public string BlockHash { get; set; }
        public string TransactionId { get; set; }
        public int vout { get; set; }
        public string MessageHex { get; set; }
        public string MessageText { get; set; }
    }
}
