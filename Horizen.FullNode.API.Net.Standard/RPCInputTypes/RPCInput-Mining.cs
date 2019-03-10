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
        public string mode { get; set; } = "template";
        [JsonProperty(PropertyName = "capabilities", ItemConverterType = typeof(StringEnumConverter))]
        public IList<GetBlockTemplateInputCapabilitiesType> capabilities { get; set; }
    }

    public class SubmitBlockInput
    {
        public string workid { get; set; }
    }


}
