using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Horizen.FullNode.API.Net.Standard.RPCInputTypes
{
    public enum GetBlockTemplateInputCapabilitiesType
    {
        [EnumMember(Value = "longpoll")]
        [Description("longpoll")]
        Longpoll,
        [EnumMember(Value = "coinbasetxn")]
        [Description("coinbasetxn")]
        Coinbasetxn,
        [EnumMember(Value = "coinbasevalue")]
        [Description("coinbasevalue")]
        Coinbasevalue,
        [EnumMember(Value = "proposal")]
        [Description("proposal")]
        Proposal,
        [EnumMember(Value = "serverlist")]
        [Description("serverlist")]
        Serverlist,
        [EnumMember(Value = "workid")]
        [Description("workid")]
        Workid

    }

    public class GetBlockTemplateInput
    {
        public GetBlockTemplateInput(string _mode, IList<GetBlockTemplateInputCapabilitiesType> _capabilities)
        {
            mode = _mode;
            capabilities =  new List<string>();
            foreach (var capability in _capabilities)
            {
                capabilities.Add(capability.GetDescription());
            }
        }
        public string mode { get; set; } = "template";
        public IList<string> capabilities { get; set; }
    }

    public class SubmitBlockInput
    {
        public string workid { get; set; }
    }


}
