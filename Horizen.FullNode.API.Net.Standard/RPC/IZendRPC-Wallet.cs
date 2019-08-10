using System;
using System.Collections.Generic;
using System.Text;
using Horizen.FullNode.API.Net.Standard.RPCInputTypes;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;

namespace Horizen.FullNode.API.Net.Standard.RPC
{
    public partial interface IZendRPCWallet
    {
        /*== Wallet ==
        addmultisigaddress nrequired ["key",...] ( "account" )
        backupwallet "destination"
        dumpprivkey "horizenaddress"
        dumpwallet "filename"
        encryptwallet "passphrase"
        getaccount "horizenaddress"
        getaccountaddress "account"
        getaddressesbyaccount "account"
        getbalance ( "account" minconf includeWatchonly )
        getnewaddress ( "account" )
        getrawchangeaddress
        getreceivedbyaccount "account" ( minconf )
        getreceivedbyaddress "horizenaddress" ( minconf )
        gettransaction "txid" ( includeWatchonly )
        getunconfirmedbalance
        getwalletinfo
        importaddress "address" ( "label" rescan )
        importprivkey "horizenprivkey" ( "label" rescan )
        importwallet "filename"
        keypoolrefill ( newsize )
        listaccounts ( minconf includeWatchonly)
        listaddresses
        listaddressgroupings
        listlockunspent
        listreceivedbyaccount ( minconf includeempty includeWatchonly)
        listreceivedbyaddress ( minconf includeempty includeWatchonly)
        listsinceblock ( "blockhash" target-confirmations includeWatchonly)
        listtransactions ( "account" count from includeWatchonly)
        listunspent ( minconf maxconf  ["address",...] )
        lockunspent unlock [{"txid":"txid","vout":n},...]
        move "fromaccount" "toaccount" amount ( minconf "comment" )
        sendfrom "fromaccount" "tohorizenaddress" amount ( minconf "comment" "comment-to" )
        sendmany "fromaccount" {"address":amount,...} ( minconf "comment" ["address",...] )
        sendtoaddress "horizenaddress" amount ( "comment" "comment-to" subtractfeefromamount )
        setaccount "horizenaddress" "account"
        settxfee amount
        signmessage "horizenaddress" "message"
        */
        string AddMultiSigAddress(RPCConnection rpc,int nrequired, IList<string> keysobject);
        string BackupWallet(RPCConnection rpc,string filename); //filename
        string DumpPrivKey(RPCConnection rpc,string t_addr);
        string DumpWallet(RPCConnection rpc,string filename);
        bool EncryptWallet(RPCConnection rpc,string passphrase);// https://zcash-rpc.github.io/encryptwallet.html
        string GetAccount(RPCConnection rpc,string address); //returns null
        string GetAccountAddress(RPCConnection rpc,string address = "");
        IList<string> GetAddressesByAccount(RPCConnection rpc,string address = "");
        double GetBalance(RPCConnection rpc,string account = "", int minconf = 1, bool includeWatchOnly = false);
        string GetNewAddress(RPCConnection rpc,string account = "");
        string GetRawChangeAddress(RPCConnection rpc);
        double GetReceivedByAccount(RPCConnection rpc,string account = "", int minconf = 1);
        double GetReceivedByAddress(RPCConnection rpc,string address, int minconf = 1);
        GetTransactionResult GetTransaction(RPCConnection rpc,string txid, bool includeWatchOnly = false);
        double GetUnconfirmedBalance(RPCConnection rpc);
        GetWalletInfoResult GetWalletInfo(RPCConnection rpc);
        bool ImportAddress(RPCConnection rpc,string address, string label = "", bool rescan = true);
        bool ImportPrivKey(RPCConnection rpc,string privkey, string label = "", bool rescan = true);
        bool ImportWallet(RPCConnection rpc,string filepath);
        bool KeyPoolRefill(RPCConnection rpc,int newsize);
        IList<ListAccountsResult> ListAccounts(RPCConnection rpc,int minconf = 1, bool includeWatchOnly = false);
        IList<string> ListAddresses(RPCConnection rpc);
        object[][][] ListAddressGroupings(RPCConnection rpc); //[][][0] address, [][][1] balance, [][][2] account
        IList<ListLockUnspentResult> ListLockUnspent(RPCConnection rpc);
        IList<ListReceivedByAccountResult> ListReceivedByAccount(RPCConnection rpc,int minconf = 1, bool includeEmpty = false,
            bool includeWatchOnly = false);
        IList<ListReceivedByAddressResult> ListReceivedByAddress(RPCConnection rpc,int minconf = 1, bool includeEmpty = false,
            bool includeWatchOnly = false);
        ListSinceBlockResult ListSinceBlock(RPCConnection rpc,string blockhash = null, int targetCOnfirmations = 1,
            bool includeWatchOnly = false);
        IList<ListTransactionsResult> ListTransactions(RPCConnection rpc,string account = "*", int count = 10, int from = 0,
            bool includeWatchOnly = false);
        IList<ListUnspentResult> ListUnspent(RPCConnection rpc,int minconf = 1, int maxconf = 9999999, IList<string> addresses = null); // TODO: coincontrol
        bool LockUnspent(RPCConnection rpc,bool unlock, IList<LockUnspentInputTransaction> transactions);// TODO: coincontrol
        bool Move(RPCConnection rpc,string fromAccount = "", string toAccount = "", double amount = double.NaN, int minconf = 1,
            string comment = null);//TODO: throw deprecated
        string SendFrom(RPCConnection rpc,string fromAccount = "", string toAccount = "", double amount = double.NaN,
            int minconf = 1,
            string comment = null);
        string SendMany(RPCConnection rpc,string address, IList<SendManyInput> outputs, int minconf = 1, string comment = null, IList<string> subtractfeefromamount = null);
        string SendToAddress(RPCConnection rpc,string address, double amount, string comment, string commentto, bool subtractfeefromamount = false);
        void SetAccount(RPCConnection rpc,string address, string account = "");
        bool SetTxFee(RPCConnection rpc,double amount);
        string SignMessage(RPCConnection rpc,string taddr, string message);
    }
}
