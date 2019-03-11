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

        public CreateMultiSigResult CreateMultiSig(int nrequired, IList<string> keys)
        {
            return GetRPCTypedResult<CreateMultiSigResult>(ZendRPCCommands[ZendRPCCommand.CreateMultisig], new object[] { nrequired, keys });
        }

        public float EstimateFee(int nblocks)
        {
            return GetRPCTypedResult<float>(ZendRPCCommands[ZendRPCCommand.EstimateFee], new object[] { nblocks });
        }

        public int EstimatePriority(int nblocks)
        {
            return GetRPCTypedResult<int>(ZendRPCCommands[ZendRPCCommand.EstimatePriority], new object[] { nblocks });
        }

        public ValidateAddressResult ValidateAddress(string address)
        {
            return GetRPCTypedResult<ValidateAddressResult>(ZendRPCCommands[ZendRPCCommand.ValidateAddress], new object[] { $"{address}" });
        }

        public bool VerifyMessage(string address, string signature, string message)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommands[ZendRPCCommand.VerifyMessage],
                new object[] {$"{address}", $"{signature}", $"{message}"});
        }

        public ZValidateAddressResult zValidateAddress(string zaddress)
        {
            return GetRPCTypedResult<ZValidateAddressResult>(ZendRPCCommands[ZendRPCCommand.ZValidateAddress], new object[] { $"{zaddress}" });
        }

        #endregion
    }
}
