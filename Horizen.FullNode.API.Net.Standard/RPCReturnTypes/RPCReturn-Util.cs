using System;
using System.Collections.Generic;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard.RPCReturnTypes
{
    #region Util

    public class CreateMultiSigResult
    {
        public string address { get; set; }
        public string redeemScript { get; set; }
    }


    public class ValidateAddressResult
    {
        public bool isvalid { get; set; }
        public string address { get; set; }
        public string scriptPubKey { get; set; }
        public bool ismine { get; set; }
        public bool isscript { get; set; }
        public string pubkey { get; set; }
        public bool iscompressed { get; set; }
        public string account { get; set; }
    }

    public class ZValidateAddressResult
    {
        public bool isvalid { get; set; }
        public string address { get; set; }
        public string type { get; set; }
        public string payingkey { get; set; } //sprout
        public string transmissionkey { get; set; } //sprout
        //TODO: Sapling for ZCash
        public string diversifier { get; set; } //sapling
        public string diversifiedtransmissionkey { get; set; } //sapling
    }
    #endregion
}
