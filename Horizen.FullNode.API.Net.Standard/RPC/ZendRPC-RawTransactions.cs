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
        #region Raw Transactions
    public string CreateRawTransaction(CreateRawTransactionInput arguments)
        {
            throw new NotImplementedException();
        }

        public DecodeRawTransactionResult DecodeRawTransaction(string hexstring)
        {
            throw new NotImplementedException();
        }

        public DecodeScriptResult DecodeScript(string hexstring)
        {
            throw new NotImplementedException();
        }

        public FundTransactionResult FundTransaction(string hexstring)
        {
            throw new NotImplementedException();
        }

        public GetRawTransactionVerboseResult GetRawTransaction(string txid, bool verbose = true)
        {
            return JsonConvert.DeserializeObject<GetRawTransactionVerboseResult>(new RPCConnection().RunCommand("getrawtransaction", new object[] { $"{txid}", 1 }));
        }

        public string GetRawTransactionNonVerbose(string txid, bool verbose = false)
        {
            throw new NotImplementedException();
        }

        public string SendRawTransaction(string hexstring, bool allowHighFees = false)
        {
            throw new NotImplementedException();
        }

        public SignRawTransactionResult SendRawTransaction(string hexstring, IList<SignRawTransactionInputPreviousTranscations> prevtxs = null, IList<string> privatekeys = null, SignRawTransactionInputSigHashType sighashtype = SignRawTransactionInputSigHashType.All, string branchid = null)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
