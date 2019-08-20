using System;
using System.Collections.Generic;
using System.Text;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;

namespace Horizen.FullNode.API.Net.Standard.RPC
{
    public partial interface IZendRPCUtil
    {
        /* == Util ==
        createmultisig nrequired ["key",...] //(string, required) A json array of keys which are Zcash addresses or hex-encoded public keys
        estimatefee nblocks
        estimatepriority nblocks
        validateaddress "zcashaddress"
        verifymessage "zcashaddress" "signature" "message"
        z_validateaddress "zaddr"
        */
        CreateMultiSigResult CreateMultiSig(RPCConnection rpc, int nrequired, IList<string> keys);
        double EstimateFee(RPCConnection rpc, int nblocks);
        int EstimatePriority(RPCConnection rpc, int nblocks);
        ValidateAddressResult ValidateAddress(RPCConnection rpc, string address);
        bool VerifyMessage(RPCConnection rpc, string address, string signature, string message);
        ZValidateAddressResult zValidateAddress(RPCConnection rpc, string zaddress);
    }
}
