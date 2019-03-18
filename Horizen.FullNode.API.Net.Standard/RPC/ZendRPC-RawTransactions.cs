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
            return GetRPCTypedResult<string>(ZendRPCCommand.CreateRawTransaction.GetDescription(), new object[] { arguments });
        }

        public DecodeRawTransactionResult DecodeRawTransaction(string hexstring)
        {
            return GetRPCTypedResult<DecodeRawTransactionResult>(ZendRPCCommand.DecodeRawTransaction.GetDescription(), new object[] { $"{hexstring}" });
        }

        public DecodeScriptResult DecodeScript(string hexstring)
        {
            return GetRPCTypedResult<DecodeScriptResult>(ZendRPCCommand.DecodeScript.GetDescription(), new object[] { $"{hexstring}" });
        }

        public FundRawTransactionResult FundRawTransaction(string hexstring)
        {
            return GetRPCTypedResult<FundRawTransactionResult>(ZendRPCCommand.FundRawTransaction.GetDescription(), new object[] { $"{hexstring}" });
        }

        public GetRawTransactionVerboseResult GetRawTransaction(string txid, bool verbose = true)
        {
            return GetRPCTypedResult<GetRawTransactionVerboseResult>(ZendRPCCommand.GetRawTransaction.GetDescription(), new object[] { $"{txid}", 1 });
        }

        public string GetRawTransactionNonVerbose(string txid, bool verbose = false)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.GetRawTransaction.GetDescription(), new object[] { $"{txid}", 0 });
        }

        public string SendRawTransaction(string hexstring, bool allowHighFees = false)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.SendRawTransaction.GetDescription(), new object[] { $"{hexstring}", allowHighFees });
        }

        public SignRawTransactionResult SendRawTransaction(string hexstring, IList<SignRawTransactionInputPreviousTranscations> prevtxs = null, IList<string> privatekeys = null, SignRawTransactionInputSigHashType sighashtype = SignRawTransactionInputSigHashType.All, string branchid = null)
        {
            return GetRPCTypedResult<SignRawTransactionResult>(ZendRPCCommand.SignRawTransaction.GetDescription(), new object[] { $"{hexstring}", prevtxs, privatekeys, sighashtype, $"{branchid}" });
        }
        #endregion
    }
}
