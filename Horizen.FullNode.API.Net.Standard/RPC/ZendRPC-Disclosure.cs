using System;
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

    public string ZGetPaymentDisclosure(RPCConnection rpc, string txid, int jsIndex, int outputIndex, string message = null)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.ZGetPaymentDisclosure,
                new object[] {$"{txid}", jsIndex, outputIndex, $"{message}"});
        }

        public ZValidatePaymentDisclosureResult ZValidatePaymentDisclosure(RPCConnection rpc, string paymentDisclosure)
        {
            return GetRPCTypedResult<ZValidatePaymentDisclosureResult>(rpc, ZendRPCCommand.ZValidatePaymentDisclosure,
                new object[] {$"{paymentDisclosure}"});

            #endregion

        }
    }
}
