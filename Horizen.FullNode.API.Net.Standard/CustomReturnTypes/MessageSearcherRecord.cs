using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Horizen.FullNode.API.Net.Standard.CustomReturnTypes;
using Newtonsoft.Json;

namespace Horizen.FullNode.API.Net.Standard.CustomReturnTypes
{
    public class MessageSearcherRecord
    {
        public MessageSearcherRecord()
        {
            SearchedAt = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss");
            SearchStartedAtBlockHeight = 0;
            FoundMessages = new List<MessageSearcher>();
        }
        public MessageSearcherRecord(int startBlockHeight, MessageSearcherRecord prevRecord)
        {
            SearchStartedAtBlockHeight = startBlockHeight;
            if (prevRecord.FoundMessages != null && prevRecord.FoundMessages.Any())
            {
                FoundMessages = prevRecord.FoundMessages;
            }
            SearchedAt = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss");
        }

        [JsonIgnore]
        public List<MessageSearcher> MessageSearchRange { get; set; } = new List<MessageSearcher>();
        public string SearchedAt { get; set; } 
        public int SearchStartedAtBlockHeight { get; set; }
        public List<MessageSearcher> FoundMessages { get; set; }

        public void AddMessage(OPReturnMessage message)
        {
            //TODO: using python script as basis, rewrite for C#
        }
        public string Serialize()
        {
            FoundMessages = FoundMessages.Where(a => a.messages.Any()).Distinct().OrderByDescending(a=>a.blockHeight).ToList();
            return JsonConvert.SerializeObject(this);
        }
    }
}
