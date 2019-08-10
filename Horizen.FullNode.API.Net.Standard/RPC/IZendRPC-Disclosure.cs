using System;
using System.Collections.Generic;
using System.Text;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;

namespace Horizen.FullNode.API.Net.Standard.RPC
{
    public partial interface IZendRPCDisclosure
    {
        /* == Disclosure ==
z_getpaymentdisclosure "txid" "js_index" "output_index" ("message")
z_validatepaymentdisclosure "paymentdisclosure"
*/

        //jsindex and outputindex are only available from debug.log but also can test using increments in loops
        string ZGetPaymentDisclosure(RPCConnection rpc, string txid, int jsIndex, int outputIndex, string message = null);
        ZValidatePaymentDisclosureResult ZValidatePaymentDisclosure(RPCConnection rpc, string paymentDisclosure);
    }
}
