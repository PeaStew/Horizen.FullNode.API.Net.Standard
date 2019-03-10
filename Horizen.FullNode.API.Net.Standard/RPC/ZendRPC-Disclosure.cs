﻿using System;
using System.Collections.Generic;
using System.Text;
using Horizen.FullNode.API.Net.Standard.RPC;
using Horizen.FullNode.API.Net.Standard.RPCInputTypes;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;
using Newtonsoft.Json;

namespace Horizen.FullNode.API.Net.Standard
{
    public partial class ZendRPC : IZendRPC
    { 

        #region Disclosure

    public string ZGetPaymentDisclosure(string txid, int jsIndex, int outputIndex, string message = null)
        {
            return GetRPCTypedResult<string>("z_getpaymentdisclosure",
                new object[] {$"{txid}", jsIndex, outputIndex, $"{message}"});
        }

        public ZValidatePaymentDisclosureResult ZValidatePaymentDisclosure(string paymentDisclosure)
        {
            return GetRPCTypedResult<ZValidatePaymentDisclosureResult>("z_validatepaymentdisclosure",
                new object[] {$"{paymentDisclosure}"});

            #endregion

        }
    }
}