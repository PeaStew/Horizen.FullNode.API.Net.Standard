using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Horizen.FullNode.API.Net.Standard.RPC;
using Horizen.FullNode.API.Net.Standard.RPCInputTypes;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;
using Newtonsoft.Json;

namespace Horizen.FullNode.API.Net.Standard
{
    public partial class ZendRPC:IZendRPC
    {

        public T GetRPCTypedResult<T>(RPCConnection rpc, string commandName, object[] _params)
        {
            var result = rpc.RunCommand(commandName, _params);
            if (string.IsNullOrEmpty(result)) return default(T);
            if (string.IsNullOrEmpty(result)) throw new Exception("Result is null");
            if (typeof(T) == typeof(string)
                || typeof(T) == typeof(int)
                || typeof(T) == typeof(long)
                || typeof(T) == typeof(double)
                || typeof(T) == typeof(bool))
            {
                return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(result.Replace("\"", "")));
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(result);
            }
        }

        public T GetRPCTypedResult<T>(RPCConnection rpc, ZendRPCCommand commandName, object[] _params)
        {
            var result = rpc.RunCommand(commandName, _params);
            if (string.IsNullOrEmpty(result)) return default(T);

            if (typeof(T) == typeof(string)
                || typeof(T) == typeof(int)
                || typeof(T) == typeof(long)
                || typeof(T) == typeof(double)
                || typeof(T) == typeof(bool))
            {
                return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(result.Replace("\"", "")));
            }

            return JsonConvert.DeserializeObject<T>(result);

        }

        public T GetRPCTypedResult<T>(RPCConnection rpc, List<RPCData> data)
        {
            var result = rpc.RunCommand(data);
            return string.IsNullOrEmpty(result) ? default(T) : JsonConvert.DeserializeObject<T>(result);
        }

        public enum ZendRPCCommand
        {
            //Blockchain
            [Description("getbestblockhash")] GetBestBlockHash,
            [Description("getblock")] GetBlock,
            [Description("getblockchaininfo")] GetBlockchainInfo,
            [Description("getblockcount")] GetBlockCount,
            [Description("getblockhash")] GetBlockHash,
            [Description("getblockheader")] GetBlockHeader,
            [Description("getchaintips")] GetChainTips,
            [Description("getdifficulty")] GetDifficulty,
            [Description("getmempoolinfo")] GetMemPoolInfo,
            [Description("getrawmempool")] GetRawMemPool,
            [Description("gettxout")] GetTxOut,
            [Description("gettxoutproof")] GetTxOutProof,
            [Description("gettxoutsetinfo")] GetTxOutSetInfo,
            [Description("verifychain")] VerifyChain,
            [Description("verifytxoutproof")] VerifyTxOutProof,

            //Control
            [Description("getinfo")] GetInfo,
            [Description("help")] Help,
            [Description("stop")] Stop,

            //Disclosure
            [Description("z_getpaymentdisclosure")]
            ZGetPaymentDisclosure,

            [Description("z_validatepaymentdisclosure")]
            ZValidatePaymentDisclosure,

            //Generating
            [Description("generate")] Generate,
            [Description("getgenerate")] GetGenerate,
            [Description("setgenerate")] SetGenerate,

            //Mining
            [Description("getblocksubsidy")] GetBlockSubsidy,
            [Description("getblocktemplate")] GetBlockTemplate,
            [Description("getlocalsolps")] GetLocalSolPs,
            [Description("getmininginfo")] GetMiningInfo,
            [Description("getnetworkhashps")] GetNetworkHashPs,
            [Description("getnetworksolps")] GetNetworkSolPs,
            [Description("prioritisetransaction")] PrioritiseTransaction,
            [Description("submitblock")] SubmitBlock,

            //Network
            [Description("addnode")] AddNode,
            [Description("clearbanned")] ClearBanned,
            [Description("disconnectnode")] DisconnectNode,
            [Description("getaddednodeinfo")] GetAddedNodeInfo,
            [Description("getconnectioncount")] GetConnectionCount,
            [Description("getnettotals")] GetNetTotals,
            [Description("getnetworkinfo")] GetNetworkInfo,
            [Description("getpeerinfo")] GetPeerInfo,
            [Description("listbanned")] ListBanned,
            [Description("ping")] Ping,
            [Description("setban")] SetBan,

            //Raw Transactions
            [Description("createrawtransaction")] CreateRawTransaction,
            [Description("decoderawtransaction")] DecodeRawTransaction,
            [Description("decodescript")] DecodeScript,
            [Description("fundrawtransaction")] FundRawTransaction,
            [Description("getrawtransaction")] GetRawTransaction,
            [Description("sendrawtransaction")] SendRawTransaction,
            [Description("signrawtransaction")] SignRawTransaction,

            //Util
            [Description("createmultisig")] CreateMultisig,
            [Description("estimatefee")] EstimateFee,
            [Description("estimatepriority")] EstimatePriority,
            [Description("validateaddress")] ValidateAddress,
            [Description("verifymessage")] VerifyMessage,
            [Description("z_validateaddress")] ZValidateAddress,

            //Wallet
            [Description("addmultisigaddress")] AddMultisigAddress,
            [Description("backupwallet")] BackupWallet,
            [Description("dumpprivkey")] DumpPrivkey,
            [Description("dumpwallet")] DumpWallet,
            [Description("encryptwallet")] EncryptWallet,
            [Description("getaccount")] GetAccount,
            [Description("getaccountaddress")] GetAccountAddress,
            [Description("getaddressesbyaccount")] GetAddressByAccount,
            [Description("getbalance")] GetBalance,
            [Description("getnewaddress")] GetNewAddress,
            [Description("getrawchangeaddress")] GetRawChangeAddress,
            [Description("getreceivedbyaccount")] GetReceivedByAccount,
            [Description("getreceivedbyaddress")] GetReceivedByAddress,
            [Description("gettransaction")] GetTransaction,
            [Description("getunconfirmedbalance")] GetUnconfirmedBalance,
            [Description("getwalletinfo")] GetWalletInfo,
            [Description("importaddress")] ImportAddress,
            [Description("importprivkey")] ImportPrivkey,
            [Description("importwallet")] ImportWallet,
            [Description("keypoolrefill")] KeyPoolRefill,
            [Description("listaccounts")] ListAccounts,
            [Description("listaddresses")] ListAddresses,
            [Description("listaddressgroupings")] ListAddressGroupings,
            [Description("listlockunspent")] ListLockUnspent,
            [Description("listreceivedbyaccount")] ListReceivedByAccount,
            [Description("listreceivedbyaddress")] ListReceivedByAddress,
            [Description("listsinceblock")] ListSinceBlock,
            [Description("listtransactions")] ListTransactions,
            [Description("listunspent")] ListUnspent,
            [Description("lockunspent")] LockUnspent,
            [Description("move")] Move,
            [Description("sendfrom")] SendFrom,
            [Description("sendmany")] SendMany,
            [Description("sendtoaddress")] SendToAddress,
            [Description("setaccount")] SetAccount,
            [Description("settxfee")] SetTxFee,
            [Description("signmessage")] SignMessage,

            //Z Commands
            [Description("z_exportkey")] ZExportKey,
            [Description("z_exportviewingkey")] ZExportViewingKey,
            [Description("z_exportwallet")] ZExportWallet,
            [Description("z_getbalance")] ZGetBalance,
            [Description("z_getnewaddress")] ZGetNewAddress,
            [Description("z_getoperationresult")] ZGetOperationResult,
            [Description("z_getoperationstatus")] ZGetOperationStatus,
            [Description("z_gettotalbalance")] ZGetTotalBalance,
            [Description("z_importkey")] ZImportKey,
            [Description("z_importviewingkey")] ZImportViewingKey,
            [Description("z_importwallet")] ZImportWallet,
            [Description("z_listaddresses")] ZListAddresses,
            [Description("z_listoperationids")] ZListOperationIds,
            [Description("z_listreceivedbyaddress")]ZListReceivedByAddress,
            [Description("z_sendmany")] ZSendMany,
            [Description("z_shieldcoinbase")] ZShieldCoinbase,
            [Description("zcbenchmark")] ZCBenchmark,
            [Description("zcrawjoinsplit")] ZCRawJoinSplit,
            [Description("zcrawkeygen")] ZCRawKeyGen,
            [Description("zcrawreceive")] ZCRawReceive,
            [Description("zcsamplejoinsplit")] ZCSampleJoinSplit,

        }
    }
}
