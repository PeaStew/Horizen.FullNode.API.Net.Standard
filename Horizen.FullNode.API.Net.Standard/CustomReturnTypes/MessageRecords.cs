using System;
using System.Collections.Generic;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard.CustomReturnTypes
{
    public class MessageRecords
    {
        public MessageRecords()
        {
            Messages = new List<MessageRecord>();
        }

        public int LastBlockId { get; set; }
        public string LastSearchedAt { get; set; }

        public List<MessageRecord> Messages { get; set; }
    }
}
