using System;
using System.Collections.Generic;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard.RPCReturnTypes
{
    #region Disclosure
    /* == Disclosure ==
        z_getpaymentdisclosure "txid" "js_index" "output_index" ("message")
        z_validatepaymentdisclosure "paymentdisclosure"
        */
    public class ZValidatePaymentDisclosureResult
    {
        public string txid { get; set; }
        public int jsIndex { get; set; }
        public int outputIndex { get; set; }
        public int version { get; set; }
        public string onetimePrivKey { get; set; }
        public string message { get; set; }
        public string joinSplitPubKey { get; set; }
        public bool signatureVerified { get; set; }
        public string paymentAddress { get; set; }
        public string memo { get; set; }
        public double value { get; set; }
        public bool commitmentMatch { get; set; }
        public bool valid { get; set; }
    }

    #endregion
}
