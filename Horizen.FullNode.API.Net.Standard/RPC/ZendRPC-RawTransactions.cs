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
        public string CreateRawTransaction(RPCConnection rpc, CreateRawTransactionInput arguments)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.CreateRawTransaction.GetDescription(), new object[] { arguments });
        }

        public DecodeRawTransactionResult DecodeRawTransaction(RPCConnection rpc, string hexstring)
        {
            return GetRPCTypedResult<DecodeRawTransactionResult>(rpc, ZendRPCCommand.DecodeRawTransaction.GetDescription(), new object[] { $"{hexstring}" });
        }

        public DecodeScriptResult DecodeScript(RPCConnection rpc, string hexstring)
        {
            return GetRPCTypedResult<DecodeScriptResult>(rpc, ZendRPCCommand.DecodeScript.GetDescription(), new object[] { $"{hexstring}" });
        }

        public FundRawTransactionResult FundRawTransaction(RPCConnection rpc, string hexstring)
        {
            return GetRPCTypedResult<FundRawTransactionResult>(rpc, ZendRPCCommand.FundRawTransaction.GetDescription(), new object[] { $"{hexstring}" });
        }

        public GetRawTransactionVerboseResult GetRawTransaction(RPCConnection rpc, string txid, bool verbose = true)
        {
            return GetRPCTypedResult<GetRawTransactionVerboseResult>(rpc, ZendRPCCommand.GetRawTransaction.GetDescription(), new object[] { $"{txid}", 1 });
        }

        public string GetRawTransactionNonVerbose(RPCConnection rpc, string txid, bool verbose = false)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.GetRawTransaction.GetDescription(), new object[] { $"{txid}", 0 });
        }

        public string SendRawTransaction(RPCConnection rpc, string hexstring, bool allowHighFees = false)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.SendRawTransaction.GetDescription(), new object[] { $"{hexstring}", allowHighFees });
        }

        public SignRawTransactionResult SendRawTransaction(RPCConnection rpc, string hexstring, IList<SignRawTransactionInputPreviousTransactions> prevtxs = null, IList<string> privatekeys = null, SignRawTransactionInputSigHashType sighashtype = SignRawTransactionInputSigHashType.All, string branchid = null)
        {
            return GetRPCTypedResult<SignRawTransactionResult>(rpc, ZendRPCCommand.SignRawTransaction.GetDescription(), new object[] { $"{hexstring}", prevtxs, privatekeys, sighashtype, $"{branchid}" });
        }
        #endregion
    }
}
