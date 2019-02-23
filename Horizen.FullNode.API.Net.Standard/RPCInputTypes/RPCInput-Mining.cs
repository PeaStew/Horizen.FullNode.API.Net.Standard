using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard.RPCInputTypes
{
    public enum GetBlockTemplateInputCapabilitiesType
    {
        [Description("longpoll")]
        Longpoll,
        [Description("coinbasetxn")]
        Coinbasetxn,
        [Description("coinbasevalue")]
        Coinbasevalue,
        [Description("proposal")]
        Proposal,
        [Description("serverlist")]
        Serverlist,
        [Description("workid")]
        Workid

    }

    public class GetBlockTemplateInput
    {
        public string mode { get; set; }
        public IList<GetBlockTemplateInputCapabilitiesType> capabilities { get; set; }
    }
}
