using System;
using System.Collections.Generic;
using System.Text;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;

namespace Horizen.FullNode.API.Net.Standard.RPC
{
    public partial interface IRPCUtil
    {
        /* == Util ==
        createmultisig nrequired ["key",...] //(string, required) A json array of keys which are Zcash addresses or hex-encoded public keys
        estimatefee nblocks
        estimatepriority nblocks
        validateaddress "zcashaddress"
        verifymessage "zcashaddress" "signature" "message"
        z_validateaddress "zaddr"
        */
        CreateMultiSigResult CreateMultiSig(int nrequired, IList<string> keys);
        float EstimateFee(int nblocks);
        int EstimatePriority(int nblocks);
        ValidateAddressResult ValidateAddress(string address);
        bool VerifyMessage(string address, string signature, string message);
        ZValidateAddressResult zValidateAddress(string zaddress);
    }
}
