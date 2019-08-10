using System;
using System.Collections.Generic;
using System.Text;
using Horizen.FullNode.API.Net.Standard.RPCInputTypes;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;


namespace Horizen.FullNode.API.Net.Standard.RPC
{
    public partial interface IZendRPCRawTransaction
    {
        /* == Rawtransactions ==
        createrawtransaction [{"txid":"id","vout":n},...] {"address":amount,...}
        decoderawtransaction "hexstring"
        decodescript "hex"
        fundrawtransaction "hexstring" //https://zcash-rpc.github.io/fundrawtransaction.html
        getrawtransaction "txid" ( verbose )
        sendrawtransaction "hexstring" ( allowhighfees )
        signrawtransaction "hexstring" ( [{"txid":"id","vout":n,"scriptPubKey":"hex","redeemScript":"hex"},...] ["privatekey1",...] sighashtype )
        */
        string CreateRawTransaction(RPCConnection rpc, CreateRawTransactionInput arguments);
        DecodeRawTransactionResult DecodeRawTransaction(RPCConnection rpc, string hexstring);
        DecodeScriptResult DecodeScript(RPCConnection rpc, string hexstring);
        FundRawTransactionResult FundRawTransaction(RPCConnection rpc, string hexstring);
        GetRawTransactionVerboseResult GetRawTransaction(RPCConnection rpc, string txid, bool verbose = true);
        string GetRawTransactionNonVerbose(RPCConnection rpc, string txid, bool verbose = false);
        string SendRawTransaction(RPCConnection rpc, string hexstring, bool allowHighFees = false);
        SignRawTransactionResult SendRawTransaction(RPCConnection rpc, string hexstring,
            IList<SignRawTransactionInputPreviousTransactions> prevtxs = null, IList<string> privatekeys = null,
            SignRawTransactionInputSigHashType sighashtype = SignRawTransactionInputSigHashType.All, string branchid = null);
    }
}
