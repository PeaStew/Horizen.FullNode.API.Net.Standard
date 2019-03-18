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
            return GetRPCTypedResult<CreateMultiSigResult>(ZendRPCCommand.CreateMultisig.GetDescription(), new object[] { nrequired, keys });
        }

        public double EstimateFee(int nblocks)
        {
            return GetRPCTypedResult<double>(ZendRPCCommand.EstimateFee.GetDescription(), new object[] { nblocks });
        }

        public int EstimatePriority(int nblocks)
        {
            return GetRPCTypedResult<int>(ZendRPCCommand.EstimatePriority.GetDescription(), new object[] { nblocks });
        }

        public ValidateAddressResult ValidateAddress(string address)
        {
            return GetRPCTypedResult<ValidateAddressResult>(ZendRPCCommand.ValidateAddress.GetDescription(), new object[] { $"{address}" });
        }

        public bool VerifyMessage(string address, string signature, string message)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommand.VerifyMessage.GetDescription(),
                new object[] {$"{address}", $"{signature}", $"{message}"});
        }

        public ZValidateAddressResult zValidateAddress(string zaddress)
        {
            return GetRPCTypedResult<ZValidateAddressResult>(ZendRPCCommand.ZValidateAddress.GetDescription(), new object[] { $"{zaddress}" });
        }

        #endregion
    }
}
