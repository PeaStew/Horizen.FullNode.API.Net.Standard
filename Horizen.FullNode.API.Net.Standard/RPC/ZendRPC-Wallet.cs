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
        #region Wallet
        public PublicAddress AddMultiSigAddress(int nrequired, IList<string> keysobject)
        {
            throw new NotImplementedException();
        }

        public string BackupWallet(string filename)
        {
            throw new NotImplementedException();
        }

        public string DumpPrivKey(string t_addr)
        {
            throw new NotImplementedException();
        }

        public string DumpWallet(string filename)
        {
            throw new NotImplementedException();
        }

        public bool EncryptWallet(string passphrase)
        {
            throw new NotImplementedException();
        }

        public string GetAccount(string address)
        {
            throw new NotImplementedException();
        }

        public PublicAddress GetAccountAddress(string address = "")
        {
            throw new NotImplementedException();
        }

        public IList<string> GetAddressesByAccount(string address = "")
        {
            throw new NotImplementedException();
        }

        public float GetBalance(string account = "", int minconf = 1, bool includeWatchOnly = false)
        {
            throw new NotImplementedException();
        }

        public PublicAddress GetNewAddress(string account = "")
        {
            throw new NotImplementedException();
        }

        public PublicAddress GetRawChangeAddress()
        {
            throw new NotImplementedException();
        }

        public float GetReceivedByAccount(string account = "", int minconf = 1)
        {
            throw new NotImplementedException();
        }

        public float GetReceivedByAddress(string address, int minconf = 1)
        {
            throw new NotImplementedException();
        }

        public GetTransactionResult GetTransaction(string txid, bool includeWatchOnly = false)
        {
            throw new NotImplementedException();
        }

        public float GetUnconfirmedBalance()
        {
            throw new NotImplementedException();
        }

        public GetWalletInfoResult GetWalletInfo()
        {
            throw new NotImplementedException();
        }

        public bool ImportAddress(string address, string label = "", bool rescan = true)
        {
            throw new NotImplementedException();
        }

        public bool ImportPrivKey(string privkey, string label = "", bool rescan = true)
        {
            throw new NotImplementedException();
        }

        public bool ImportWallet(string filepath)
        {
            throw new NotImplementedException();
        }

        public bool KeyPoolRefill(int newsize)
        {
            throw new NotImplementedException();
        }

        public IList<ListAccountsResult> ListAccounts(int minconf = 1, bool includeWatchOnly = false)
        {
            throw new NotImplementedException();
        }

        public object[][][] ListAddressGroupings()
        {
            throw new NotImplementedException();
        }

        public IList<ListLockUnspentResult> ListLockUnspent()
        {
            throw new NotImplementedException();
        }

        public IList<ListReceivedByAccountResult> ListReceivedByAccount(int minconf = 1, bool includeEmpty = false, bool includeWatchOnly = false)
        {
            throw new NotImplementedException();
        }

        public IList<ListReceivedByAddressResult> ListReceivedByAddress(int minconf = 1, bool includeEmpty = false, bool includeWatchOnly = false)
        {
            throw new NotImplementedException();
        }

        public ListSinceBlockResult ListSinceBlock(string blockhash = null, int targetCOnfirmations = 1, bool includeWatchOnly = false)
        {
            throw new NotImplementedException();
        }

        public IList<ListTransactionsResult> ListTransactions(string account = "*", int count = 10, int from = 0, bool includeWatchOnly = false)
        {
            throw new NotImplementedException();
        }

        public IList<ListUnspentResult> ListUnspent(int minconf = 1, int maxconf = 9999999, IList<string> addresses = null)
        {
            throw new NotImplementedException();
        }

        public bool LockUnspent(bool unlock, IList<LockUnspentInputTransaction> transactions)
        {
            throw new NotImplementedException();
        }

        public bool Move(string fromAccount = "", string toAccount = "", float amount = float.NaN, int minconf = 1, string comment = null)
        {
            throw new NotImplementedException();
        }

        public TransactionId SendFrom(string fromAccount = "", string toAccount = "", float amount = float.NaN, int minconf = 1, string comment = null)
        {
            throw new NotImplementedException();
        }

        public TransactionId SendMany(PublicAddress address, IList<SendManyInput> outputs, int minconf = 1, string comment = null, IList<string> subtractfeefromamount = null)
        {
            throw new NotImplementedException();
        }

        
        #endregion
    }
}
