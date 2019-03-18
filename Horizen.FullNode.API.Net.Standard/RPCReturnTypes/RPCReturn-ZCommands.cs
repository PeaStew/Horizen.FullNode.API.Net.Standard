using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Newtonsoft.Json;

namespace Horizen.FullNode.API.Net.Standard.RPCReturnTypes
{

    public class ZGetTotalBalanceResult
    {
        public float transparent { get; set; }
        [JsonProperty("private")]
        [Description("private")]
        public float _private { get; set; }
        public float total { get; set; }
    }

    public class ZListReceivedByAddressResult
    {
        public string txid { get; set; }
        public float amount { get; set; }
        public string memo { get; set; }
    }

    public class ZShieldCoinbase
    {
        public int remainingUTXOs { get; set; }
        public double remainingValue { get; set; }
        public int shieldingUTXOs { get; set; }
        public double shieldingValue { get; set; }
        public string opid { get; set; }
    }

    public class ZCBenchmarkResult
    {
        public string runningtime { get; set; }
    }

    public class ZCRawKeygen
    {
        public string zcaddress { get; set; }
        public string zcsecretkey { get; set; }
        public string zcviewingkey { get; set; }
    }

    public class ZCRawReceive
    {
        public double amount { get; set; }
        public string note { get; set; }
        public string exists { get; set; }
    }


}
