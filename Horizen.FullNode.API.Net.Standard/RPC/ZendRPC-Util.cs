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
            throw new NotImplementedException();
        }

        public float EstimateFee(int nblocks)
        {
            throw new NotImplementedException();
        }

        public int EstimatePriority(int nblocks)
        {
            throw new NotImplementedException();
        }

        public ValidateAddressResult ValidateAddress(string address)
        {
            throw new NotImplementedException();
        }

        public bool VerifyMessage(string address, string signature, string message)
        {
            throw new NotImplementedException();
        }

        public ZValidateAddressResult zValidateAddress(string zaddress)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
