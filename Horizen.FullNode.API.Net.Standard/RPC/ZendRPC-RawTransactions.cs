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
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.CreateRawTransaction, new object[] { arguments });
        }

        public DecodeRawTransactionResult DecodeRawTransaction(RPCConnection rpc, string hexstring)
        {
            return GetRPCTypedResult<DecodeRawTransactionResult>(rpc, ZendRPCCommand.DecodeRawTransaction, new object[] { $"{hexstring}" });
        }

        public DecodeScriptResult DecodeScript(RPCConnection rpc, string hexstring)
        {
            return GetRPCTypedResult<DecodeScriptResult>(rpc, ZendRPCCommand.DecodeScript, new object[] { $"{hexstring}" });
        }

        public FundRawTransactionResult FundRawTransaction(RPCConnection rpc, string hexstring)
        {
            return GetRPCTypedResult<FundRawTransactionResult>(rpc, ZendRPCCommand.FundRawTransaction, new object[] { $"{hexstring}" });
        }

        public GetRawTransactionVerboseResult GetRawTransaction(RPCConnection rpc, string txid, bool verbose = true)
        {
            return GetRPCTypedResult<GetRawTransactionVerboseResult>(rpc, ZendRPCCommand.GetRawTransaction, new object[] { $"{txid}", 1 });
        }

        public string GetRawTransactionNonVerbose(RPCConnection rpc, string txid, bool verbose = false)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.GetRawTransaction, new object[] { $"{txid}", 0 });
        }

        public string SendRawTransaction(RPCConnection rpc, string hexstring, bool allowHighFees = false)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.SendRawTransaction, new object[] { $"{hexstring}", allowHighFees });
        }

        public SignRawTransactionResult SendRawTransaction(RPCConnection rpc, string hexstring, IList<SignRawTransactionInputPreviousTransactions> prevtxs = null, IList<string> privatekeys = null, SignRawTransactionInputSigHashType sighashtype = SignRawTransactionInputSigHashType.All, string branchid = null)
        {
            return GetRPCTypedResult<SignRawTransactionResult>(rpc, ZendRPCCommand.SignRawTransaction, new object[] { $"{hexstring}", prevtxs, privatekeys, sighashtype, $"{branchid}" });
        }
        #endregion
    }
}
