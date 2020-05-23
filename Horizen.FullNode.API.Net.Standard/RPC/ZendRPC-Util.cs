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
        #region Util

        public CreateMultiSigResult CreateMultiSig(RPCConnection rpc, int nrequired, IList<string> keys)
        {
            return GetRPCTypedResult<CreateMultiSigResult>(rpc, ZendRPCCommand.CreateMultisig, new object[] { nrequired, keys });
        }

        public double EstimateFee(RPCConnection rpc, int nblocks)
        {
            return GetRPCTypedResult<double>(rpc, ZendRPCCommand.EstimateFee, new object[] { nblocks });
        }

        public int EstimatePriority(RPCConnection rpc, int nblocks)
        {
            return GetRPCTypedResult<int>(rpc, ZendRPCCommand.EstimatePriority, new object[] { nblocks });
        }

        public ValidateAddressResult ValidateAddress(RPCConnection rpc, string address)
        {
            return GetRPCTypedResult<ValidateAddressResult>(rpc, ZendRPCCommand.ValidateAddress, new object[] { $"{address}" });
        }

        public bool VerifyMessage(RPCConnection rpc, string address, string signature, string message)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.VerifyMessage,
                new object[] {$"{address}", $"{signature}", $"{message}"});
        }

        public ZValidateAddressResult zValidateAddress(RPCConnection rpc, string zaddress)
        {
            return GetRPCTypedResult<ZValidateAddressResult>(rpc, ZendRPCCommand.ZValidateAddress, new object[] { $"{zaddress}" });
        }

        #endregion
    }
}
