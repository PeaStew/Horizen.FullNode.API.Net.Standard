using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard.RPCInputTypes
{
    public class CreateRawTransactionInput
    {
        public IList<Transaction> transactions { get; set; }
        public IDictionary<string, double> addresses { get; set; }

        public class Transaction
        {
            public string txid { get; set; }
            public int vout { get; set; }
            public int sequence { get; set; }
        }

    }

    public class SignRawTransactionInputPreviousTransactions
    {
        public string txid { get; set; }
        public int vout { get; set; }
        public string scriptPubKey { get; set; }
        public string redeemScript { get; set; }
        public double amount { get; set; }
    }

    public enum SignRawTransactionInputSigHashType
    {
        [EnumMember(Value = "All")]
        [Description("ALL")]
        All,
        [EnumMember(Value = "NONE")]
        [Description("NONE")]
        None,
        [EnumMember(Value = "SINGLE")]
        [Description("SINGLE")]
        Single,
        [EnumMember(Value = "ALL|ANYONECANPAY")]
        [Description("ALL|ANYONECANPAY")]
        AllAnyonecanpay,
        [EnumMember(Value = "NONE|ANYONECANPAY")]
        [Description("NONE|ANYONECANPAY")]
        NoneAnyonecanpay,
        [EnumMember(Value = "SINGLE|ANYONECANPAY")]
        [Description("SINGLE|ANYONECANPAY")]
        SingleAnyonecanpay
    }
}
