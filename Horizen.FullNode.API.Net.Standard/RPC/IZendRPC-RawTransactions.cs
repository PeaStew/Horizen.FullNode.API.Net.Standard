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
        string CreateRawTransaction(CreateRawTransactionInput arguments);
        DecodeRawTransactionResult DecodeRawTransaction(string hexstring);
        DecodeScriptResult DecodeScript(string hexstring);
        FundRawTransactionResult FundRawTransaction(string hexstring);
        GetRawTransactionVerboseResult GetRawTransaction(string txid, bool verbose = true);
        string GetRawTransactionNonVerbose(string txid, bool verbose = false);
        string SendRawTransaction(string hexstring, bool allowHighFees = false);
        SignRawTransactionResult SendRawTransaction(string hexstring,
            IList<SignRawTransactionInputPreviousTranscations> prevtxs = null, IList<string> privatekeys = null,
            SignRawTransactionInputSigHashType sighashtype = SignRawTransactionInputSigHashType.All, string branchid = null);
    }
}
