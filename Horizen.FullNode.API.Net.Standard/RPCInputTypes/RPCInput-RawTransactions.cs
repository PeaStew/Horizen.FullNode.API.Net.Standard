using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard.RPCInputTypes
{
    public class CreateRawTransactionInput
    {
        public IList<Transaction> transactions { get; set; }
        public IDictionary<string, float> addresses { get; set; }

        public class Transaction
        {
            public string txid { get; set; }
            public int vout { get; set; }
            public int sequence { get; set; }
        }

    }

    public class SignRawTransactionInputPreviousTranscations
    {
        public string txid { get; set; }
        public int vout { get; set; }
        public string scriptPubKey { get; set; }
        public string redeemScript { get; set; }
        public float amount { get; set; }
    }

    public enum SignRawTransactionInputSigHashType
    {
        [Description("ALL")]
        All,
        [Description("NONE")]
        None,
        [Description("SINGLE")]
        Single,
        [Description("ALL|ANYONECANPAY")]
        AllAnyonecanpay,
        [Description("NONE|ANYONECANPAY")]
        NoneAnyonecanpay,
        [Description("SINGLE|ANYONECANPAY")]
        SingleAnyonecanpay
    }
}
