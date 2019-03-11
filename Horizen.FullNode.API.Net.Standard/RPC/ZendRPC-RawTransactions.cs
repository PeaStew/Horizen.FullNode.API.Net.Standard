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
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.CreateRawTransaction], new object[] { arguments });
        }

        public DecodeRawTransactionResult DecodeRawTransaction(string hexstring)
        {
            return GetRPCTypedResult<DecodeRawTransactionResult>(ZendRPCCommands[ZendRPCCommand.DecodeRawTransaction], new object[] { $"{hexstring}" });
        }

        public DecodeScriptResult DecodeScript(string hexstring)
        {
            return GetRPCTypedResult<DecodeScriptResult>(ZendRPCCommands[ZendRPCCommand.DecodeScript], new object[] { $"{hexstring}" });
        }

        public FundRawTransactionResult FundRawTransaction(string hexstring)
        {
            return GetRPCTypedResult<FundRawTransactionResult>(ZendRPCCommands[ZendRPCCommand.FundRawTransaction], new object[] { $"{hexstring}" });
        }

        public GetRawTransactionVerboseResult GetRawTransaction(string txid, bool verbose = true)
        {
            return GetRPCTypedResult<GetRawTransactionVerboseResult>(ZendRPCCommands[ZendRPCCommand.GetRawTransaction], new object[] { $"{txid}", 1 });
        }

        public string GetRawTransactionNonVerbose(string txid, bool verbose = false)
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.GetRawTransaction], new object[] { $"{txid}", 0 });
        }

        public string SendRawTransaction(string hexstring, bool allowHighFees = false)
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.SendRawTransaction], new object[] { $"{hexstring}", allowHighFees });
        }

        public SignRawTransactionResult SendRawTransaction(string hexstring, IList<SignRawTransactionInputPreviousTranscations> prevtxs = null, IList<string> privatekeys = null, SignRawTransactionInputSigHashType sighashtype = SignRawTransactionInputSigHashType.All, string branchid = null)
        {
            return GetRPCTypedResult<SignRawTransactionResult>(ZendRPCCommands[ZendRPCCommand.SignRawTransaction], new object[] { $"{hexstring}", prevtxs, privatekeys, sighashtype, $"{branchid}" });
        }
        #endregion
    }
}
