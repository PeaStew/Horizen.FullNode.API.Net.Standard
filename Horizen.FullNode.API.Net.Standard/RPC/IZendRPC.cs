using System;
using System.Collections.Generic;
using System.Xml.Linq;


namespace Horizen.FullNode.API.Net.Standard.RPC
{
    public interface IZendRPC: IZendRPCBlockchain, IZendRPCControl, IZendRPCDisclosure, IZendRPCGenerating, IZendRPCMining, IZendRPCNetwork, IZendRPCRawTransaction, IZendRPCUtil, IZendRPCWallet, IZendRPCZCommands
    {
        T GetRPCTypedResult<T>(string method, object[] _params);
    }
}
//        /* Commands
//         * == Blockchain ==
//getbestblockhash
//getblock "hash|height" ( verbose )
//getblockchaininfo
//getblockcount
//getblockhash index
//getblockheader "hash" ( verbose )
//getchaintips
//getdifficulty
//getmempoolinfo
//getrawmempool ( verbose )
//gettxout "txid" n ( includemempool )
//gettxoutproof ["txid",...] ( blockhash )
//gettxoutsetinfo
//verifychain ( checklevel numblocks )
//verifytxoutproof "proof"

//== Control ==
//getinfo
//help ( "command" )
//stop

//== Disclosure ==
//z_getpaymentdisclosure "txid" "js_index" "output_index" ("message")
//z_validatepaymentdisclosure "paymentdisclosure"

//== Generating ==
//generate numblocks
//getgenerate
//setgenerate generate ( genproclimit )

//== Mining ==
//getblocksubsidy height
//getblocktemplate ( "jsonrequestobject" )
//getlocalsolps
//getmininginfo
//getnetworkhashps ( blocks height )
//getnetworksolps ( blocks height )
//prioritisetransaction <txid> <priority delta> <fee delta>
//submitblock "hexdata" ( "jsonparametersobject" )

//== Network ==
//addnode "node" "add|remove|onetry"
//clearbanned
//disconnectnode "node"
//getaddednodeinfo dns ( "node" )
//getconnectioncount
//getnettotals
//getnetworkinfo
//getpeerinfo
//listbanned
//ping
//setban "ip(/netmask)" "add|remove" (bantime) (absolute)

//== Rawtransactions ==
//createrawtransaction [{"txid":"id","vout":n},...] {"address":amount,...}
//decoderawtransaction "hexstring"
//decodescript "hex"
//fundrawtransaction "hexstring"
//getrawtransaction "txid" ( verbose )
//sendrawtransaction "hexstring" ( allowhighfees )
//signrawtransaction "hexstring" ( [{"txid":"id","vout":n,"scriptPubKey":"hex","redeemScript":"hex"},...] ["privatekey1",...] sighashtype )

//== Util ==
//createmultisig nrequired ["key",...]
//estimatefee nblocks
//estimatepriority nblocks
//validateaddress "zcashaddress"
//verifymessage "zcashaddress" "signature" "message"
//z_validateaddress "zaddr"

//== Wallet ==
//addmultisigaddress nrequired ["key",...] ( "account" )
//backupwallet "destination"
//dumpprivkey "horizenaddress"
//dumpwallet "filename"
//encryptwallet "passphrase"
//getaccount "horizenaddress"
//getaccountaddress "account"
//getaddressesbyaccount "account"
//getbalance ( "account" minconf includeWatchonly )
//getnewaddress ( "account" )
//getrawchangeaddress
//getreceivedbyaccount "account" ( minconf )
//getreceivedbyaddress "horizenaddress" ( minconf )
//gettransaction "txid" ( includeWatchonly )
//getunconfirmedbalance
//getwalletinfo
//importaddress "address" ( "label" rescan )
//importprivkey "horizenprivkey" ( "label" rescan )
//importwallet "filename"
//keypoolrefill ( newsize )
//listaccounts ( minconf includeWatchonly)
//listaddresses
//listaddressgroupings
//listlockunspent
//listreceivedbyaccount ( minconf includeempty includeWatchonly)
//listreceivedbyaddress ( minconf includeempty includeWatchonly)
//listsinceblock ( "blockhash" target-confirmations includeWatchonly)
//listtransactions ( "account" count from includeWatchonly)
//listunspent ( minconf maxconf  ["address",...] )
//lockunspent unlock [{"txid":"txid","vout":n},...]
//move "fromaccount" "toaccount" amount ( minconf "comment" )
//sendfrom "fromaccount" "tohorizenaddress" amount ( minconf "comment" "comment-to" )
//sendmany "fromaccount" {"address":amount,...} ( minconf "comment" ["address",...] )
//sendtoaddress "horizenaddress" amount ( "comment" "comment-to" subtractfeefromamount )
//setaccount "horizenaddress" "account"
//settxfee amount
//signmessage "horizenaddress" "message"
//z_exportkey "zaddr"
//z_exportviewingkey "zaddr"
//z_exportwallet "filename"
//z_getbalance "address" ( minconf )
//z_getnewaddress
//z_getoperationresult (["operationid", ... ])
//z_getoperationstatus (["operationid", ... ])
//z_gettotalbalance ( minconf includeWatchonly )
//z_importkey "zkey" ( rescan startHeight )
//z_importviewingkey "vkey" ( rescan startHeight )
//z_importwallet "filename"
//z_listaddresses ( includeWatchonly )
//z_listoperationids
//z_listreceivedbyaddress "address" ( minconf )
//z_sendmany "fromaddress" [{"address":... ,"amount":...},...] ( minconf ) ( fee )
//z_shieldcoinbase "fromaddress" "tozaddress" ( fee ) ( limit )
//zcbenchmark benchmarktype samplecount
//zcrawjoinsplit rawtx inputs outputs vpub_old vpub_new
//zcrawkeygen
//zcrawreceive zcsecretkey encryptednote
//zcsamplejoinsplit
//*/
//        #region Blockchain
//        /* == Blockchain ==
//        getbestblockhash
//        getblock "hash|height" ( verbose )
//        getblockchaininfo
//        getblockcount
//        getblockhash index
//        getblockheader "hash" ( verbose )
//        getchaintips
//        getdifficulty
//        getmempoolinfo
//        getrawmempool ( verbose )
//        gettxout "txid" n ( includemempool )
//        gettxoutproof ["txid",...] ( blockhash )
//        gettxoutsetinfo
//        verifychain ( checklevel numblocks )
//        verifytxoutproof "proof"
//        */
//        string GetBestBlockHash();

//        GetBlockResult GetBlock(string hash, bool verbose = true);
//        string GetBlockNotVerbose(string hash, bool verbose = false);
//        GetBlockResult GetBlock(int height, bool verbose = true);
//        string GetBlockNotVerbose(int height, bool verbose = false);

//        GetBlockChainInfoResult GetBlockChainInfo();

//        int GetBlockCount();

//        string GetBlockHash(int index);

//        GetBlockHeaderResult GetBlockHeader(string hash, bool verbose = true);
//        string GetBlockHeaderNotVerbose(string hash, bool verbose = false);

//        float GetDifficulty();

//        GetMemPoolInfoResult GetMemPoolInfo();

//        IList<string> GetRawMemPool(bool verbose = true);

//        GetTxOutResult GetTxOut(string txid, int voutValue, bool includemempool = true);

//        string GetTxOutProof(IList<string> txids, string blockhash = null);

//        GetTxOutSetInfoResult GetTxOutSetInfo();

//        bool VerifyChain(int? checklevel = null, int? numblocks = null);

//        IList<string> VerifyTxtOutProof(string proof);

//        #endregion
//        #region Control
//        /* == Control ==
//        getinfo
//        help ( "command" )
//        stop
//        */
//        GetInfoResult GetInfo();

//        string Help();

//        void Stop();
//        #endregion
//        #region Disclosure
//        /* == Disclosure ==
//        z_getpaymentdisclosure "txid" "js_index" "output_index" ("message")
//        z_validatepaymentdisclosure "paymentdisclosure"
//        */

//        //jsindex and outputindex are only available from debug.log but also can test using increments in loops
//        string ZGetPaymentDisclosure(string txid, int jsIndex, int outputIndex, string message = null);
//        ZValidatePaymentDisclosureResult ZValidatePaymentDisclosure(string paymentDisclosure);
//        #endregion
//        #region Generating
//        /* == Generating ==
//        generate numblocks
//        getgenerate
//        setgenerate generate ( genproclimit )
//        */

//        #endregion
//        #region Mining
//        /* == Mining ==
//        getblocksubsidy height
//        getblocktemplate ( "jsonrequestobject" )
//        getlocalsolps
//        getmininginfo
//        getnetworkhashps ( blocks height )
//        getnetworksolps ( blocks height )
//        prioritisetransaction <txid> <priority delta> <fee delta>
//        submitblock "hexdata" ( "jsonparametersobject" )
//        */

//        GetBlockSubsidyResult GetBlockSubsidy(int? height);
//        GetBlockTemplateResult GetBlockTemplate(GetBlockTemplateInput jsonRequestObject = null);
//        int GetLocalSolps();
//        GetMiningInfoResult GetMiningInfo();
//        int GetNetworkHashPs(int? blocks = null, int? height = null);
//        int GetNetworkSolPs(int? blocks = null, int? height = null);
//        bool PrioritiseTransaction(string txid, double priorityDelta, int feeDelta);

//        #endregion
//        #region Network
//        /* == Network ==
//        addnode "node" "add|remove|onetry"
//        clearbanned
//        disconnectnode "node"
//        getaddednodeinfo dns ( "node" )
//        getconnectioncount
//        getnettotals
//        getnetworkinfo
//        getpeerinfo
//        listbanned
//        ping
//        setban "ip(/netmask)" "add|remove" (bantime) (absolute)
//        */

//        bool AddNode(string ipAddress, int port, AddNodeCommand command);
//        bool ClearBanned();
//        bool DisconnectNode(string ipAddress, int port);
//        IList<AddedNodeResult> GetAddedNodeInfo(bool dns, string ipAddress = null, int? port = null);
//        int GetConnectionCount();
//        GetNetTotalsResult GetNetTotals();
//        GetNetworkInfoResult GetNetworkInfo();
//        IList<PeerInfoResult> GetPeerInfo();
//        IList<BannedPeersResult> ListBanned();
//        bool Ping();
//        //"bantime"      (numeric, optional) time in seconds how long (or until when if [absolute] is set) the ip is banned (0 or empty means using the default time of 24h which can also be overwritten by the -bantime startup argument)
//        //"absolute"     (boolean, optional) If set, the bantime must be a absolute timestamp in seconds since epoch (Jan 1 1970 GMT)
//        bool SetBan(string ipaddress, int? netmask, SetBanCommand AddRemove, int? bantimeSeconds, bool absolute);
//        #endregion
//        #region Rawtransactions
//        /* == Rawtransactions ==
//        createrawtransaction [{"txid":"id","vout":n},...] {"address":amount,...}
//        decoderawtransaction "hexstring"
//        decodescript "hex"
//        fundrawtransaction "hexstring" //https://zcash-rpc.github.io/fundrawtransaction.html
//        getrawtransaction "txid" ( verbose )
//        sendrawtransaction "hexstring" ( allowhighfees )
//        signrawtransaction "hexstring" ( [{"txid":"id","vout":n,"scriptPubKey":"hex","redeemScript":"hex"},...] ["privatekey1",...] sighashtype )
//        */
//        string CreateRawTransaction(CreateRawTransactionInput arguments);
//        DecodeRawTransactionResult DecodeRawTransaction(string hexstring);
//        DecodeScriptResult DecodeScript(string hexstring);
//        FundTransactionResult FundTransaction(string hexstring);
//        GetRawTransactionVerboseResult GetRawTransaction(string txid, bool verbose = true);
//        string GetRawTransactionNonVerbose(string txid, bool verbose = false);
//        string SendRawTransaction(string hexstring, bool allowHighFees = false);
//        SignRawTransactionResult SendRawTransaction(string hexstring,
//            IList<SignRawTransactionInputPreviousTranscations> prevtxs = null, IList<string> privatekeys = null,
//            SignRawTransactionInputSigHashType sighashtype = SignRawTransactionInputSigHashType.ALL, string branchid = null);


//        #endregion
//        #region Util
//        /* == Util ==
//        createmultisig nrequired ["key",...] //(string, required) A json array of keys which are Zcash addresses or hex-encoded public keys
//        estimatefee nblocks
//        estimatepriority nblocks
//        validateaddress "zcashaddress"
//        verifymessage "zcashaddress" "signature" "message"
//        z_validateaddress "zaddr"
//        */
//        CreateMultiSigResult CreateMultiSig(int nrequired, IList<string> keys);
//        float EstimateFee(int nblocks);
//        int EstimatePriority(int nblocks);
//        ValidateAddressResult ValidateAddress(string address);
//        bool VerifyMessage(string address, string signature, string message);
//        ZValidateAddressResult zValidateAddress(string zaddress);

//        #endregion
//        #region Wallet
//        /*== Wallet ==
//        addmultisigaddress nrequired ["key",...] ( "account" )
//        backupwallet "destination"
//        dumpprivkey "horizenaddress"
//        dumpwallet "filename"
//        encryptwallet "passphrase"
//        getaccount "horizenaddress"
//        getaccountaddress "account"
//        getaddressesbyaccount "account"
//        getbalance ( "account" minconf includeWatchonly )
//        getnewaddress ( "account" )
//        getrawchangeaddress
//        getreceivedbyaccount "account" ( minconf )
//        getreceivedbyaddress "horizenaddress" ( minconf )
//        gettransaction "txid" ( includeWatchonly )
//        getunconfirmedbalance
//        getwalletinfo
//        importaddress "address" ( "label" rescan )
//        importprivkey "horizenprivkey" ( "label" rescan )
//        importwallet "filename"
//        keypoolrefill ( newsize )
//        listaccounts ( minconf includeWatchonly)
//        listaddresses
//        listaddressgroupings
//        listlockunspent
//        listreceivedbyaccount ( minconf includeempty includeWatchonly)
//        listreceivedbyaddress ( minconf includeempty includeWatchonly)
//        listsinceblock ( "blockhash" target-confirmations includeWatchonly)
//        listtransactions ( "account" count from includeWatchonly)
//        listunspent ( minconf maxconf  ["address",...] )
//        lockunspent unlock [{"txid":"txid","vout":n},...]
//        move "fromaccount" "toaccount" amount ( minconf "comment" )
//        sendfrom "fromaccount" "tohorizenaddress" amount ( minconf "comment" "comment-to" )
//        sendmany "fromaccount" {"address":amount,...} ( minconf "comment" ["address",...] )
//        sendtoaddress "horizenaddress" amount ( "comment" "comment-to" subtractfeefromamount )
//        setaccount "horizenaddress" "account"
//        settxfee amount
//        signmessage "horizenaddress" "message"
//        */
//        TAddress AddMultiSigAddress(int nrequired, IList<string> keysobject);
//        string BackupWallet(string filename); //filename
//        string DumpPrivKey(string t_addr);
//        string DumpWallet(string filename);
//        bool EncryptWallet(string passphrase);// https://zcash-rpc.github.io/encryptwallet.html
//        string GetAccount(string address); //returns null
//        TAddress GetAccountAddress(string address = "");
//        IList<string> GetAddressesByAccount(string address = "");
//        float GetBalance(string account = "", int minconf = 1, bool includeWatchOnly = false);
//        TAddress GetNewAddress(string account = "");
//        TAddress GetRawChangeAddress();
//        float GetReceivedByAccount(string account = "", int minconf =1);
//        float GetReceivedByAddress(string address, int minconf = 1);
//        GetTransactionResult GetTransaction(string txid, bool includeWatchOnly = false);
//        float GetUnconfirmedBalance();
//        GetWalletInfoResult GetWalletInfo();
//        bool ImportAddress(string address, string label = "", bool rescan = true);
//        bool ImportPrivKey(string privkey, string label = "", bool rescan = true);
//        bool ImportWallet(string filepath);
//        bool KeyPoolRefill(int newsize);
//        IList<ListAccountsResult> ListAccounts(int minconf =1, bool includeWatchOnly = false);
//        object[][][] ListAddressGroupings(); //[][][0] address, [][][1] balance, [][][2] account
//        IList<ListLockUnspentResult> ListLockUnspent();
//        IList<ListReceivedByAccountResult> ListReceivedByAccount(int minconf = 1, bool includeEmpty = false,
//            bool includeWatchOnly = false);
//        IList<ListReceivedByAddressResult> ListReceivedByAddress(int minconf = 1, bool includeEmpty = false,
//            bool includeWatchOnly = false);
//        ListSinceBlockResult ListSinceBlock(string blockhash = null, int targetCOnfirmations = 1,
//            bool includeWatchOnly = false);
//        IList<ListTransactionsResult> ListTransactions(string account = "*", int count = 10, int from = 0,
//            bool includeWatchOnly = false);
//        IList<ListUnspentResult> ListUnspent(int minconf = 1, int maxconf = 9999999, IList<string> addresses = null); // TODO: coincontrol
//        bool LockUnspent(bool unlock, IList<LockUnspentInputTransaction> transactions);// TODO: coincontrol
//        bool Move(string fromAccount = "", string toAccount = "", float amount = float.NaN, int minconf = 1,
//            string comment = null);//TODO: throw deprecated
//        TransactionId SendFrom(string fromAccount = "", string toAccount = "", float amount = float.NaN,
//            int minconf = 1, string comment = null);//TODO: throw deprecated




//        #region zCommands
//        /* z_exportkey "zaddr"
//        z_exportviewingkey "zaddr"
//        z_exportwallet "filename"
//        z_getbalance "address" ( minconf )
//        z_getnewaddress
//        z_getoperationresult (["operationid", ... ])
//        z_getoperationstatus (["operationid", ... ])
//        z_gettotalbalance ( minconf includeWatchonly )
//        z_importkey "zkey" ( rescan startHeight )
//        z_importviewingkey "vkey" ( rescan startHeight )
//        z_importwallet "filename"
//        z_listaddresses ( includeWatchonly )
//        z_listoperationids
//        z_listreceivedbyaddress "address" ( minconf )
//        z_sendmany "fromaddress" [{"address":... ,"amount":...},...] ( minconf ) ( fee )
//        z_shieldcoinbase "fromaddress" "tozaddress" ( fee ) ( limit )
//        zcbenchmark benchmarktype samplecount
//        zcrawjoinsplit rawtx inputs outputs vpub_old vpub_new
//        zcrawkeygen
//        zcrawreceive zcsecretkey encryptednote
//        zcsamplejoinsplit
//        */
//        #endregion
//        #endregion
//        double z_getbalance(string addr);
//        List<ZOperationStatusOrResult> z_getoperationresult(IEnumerable<string> opid);
//        List<ZOperationStatusOrResult> z_getoperationstatus(IEnumerable<string> opid);
//        List<string> z_listaddresses();
//        List<string> z_listoperationids();
//        string z_sendmany(string zaddr, double amts, double amt, double fee);
//    }
//}