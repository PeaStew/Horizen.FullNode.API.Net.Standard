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
        public string AddMultiSigAddress(int nrequired, IList<string> keysobject)
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.AddMultisigAddress], new object[] { nrequired, keysobject });
        }

        public string BackupWallet(string filename)
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { $"{filename}" });
        }

        public string DumpPrivKey(string t_addr)
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.DumpPrivkey], new object[] { $"{t_addr}" });
        }

        public string DumpWallet(string filename)
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.DumpWallet], new object[] { $"{filename}" });
        }

        public bool EncryptWallet(string passphrase)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommands[ZendRPCCommand.EncryptWallet], new object[] { $"{passphrase}" });
        }

        public string GetAccount(string address)
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.GetAccount], new object[] { $"{address}" });
        }

        public string GetAccountAddress(string address = "")
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.GetAccountAddress], new object[] { $"{address}" });
        }

        public IList<string> GetAddressesByAccount(string address = "")
        {
            return GetRPCTypedResult<List<string>>(ZendRPCCommands[ZendRPCCommand.GetAddressByAccount], new object[] { $"{address}" });
        }

        public float GetBalance(string account = "", int minconf = 1, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<float>(ZendRPCCommands[ZendRPCCommand.GetBalance], new object[] { $"{account}",minconf,includeWatchOnly });
        }

        public string GetNewAddress(string account = "")
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { $"{account}" });
        }

        public string GetRawChangeAddress()
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[0]);
        }

        public float GetReceivedByAccount(string account = "", int minconf = 1)
        {
            return GetRPCTypedResult<float>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { $"{account}", minconf });
        }

        public float GetReceivedByAddress(string address, int minconf = 1)
        {
            return GetRPCTypedResult<float>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { $"{address}", minconf });
        }

        public GetTransactionResult GetTransaction(string txid, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<GetTransactionResult>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { $"{txid}", includeWatchOnly });
        }

        public float GetUnconfirmedBalance()
        {
            return GetRPCTypedResult<float>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[0]);
        }

        public GetWalletInfoResult GetWalletInfo()
        {
            return GetRPCTypedResult<GetWalletInfoResult>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[0]);
        }

        public bool ImportAddress(string address, string label = "", bool rescan = true)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { $"{address}", $"{label}", rescan });
        }

        public bool ImportPrivKey(string privkey, string label = "", bool rescan = true)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { $"{privkey}", $"{label}",rescan });
        }

        public bool ImportWallet(string filepath)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { $"{filepath}" });
        }

        public bool KeyPoolRefill(int newsize)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { newsize });
        }

        public IList<ListAccountsResult> ListAccounts(int minconf = 1, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<List<ListAccountsResult>>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { minconf,includeWatchOnly });
        }

        public object[][][] ListAddressGroupings()
        {
            return GetRPCTypedResult<object[][][]>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[0]);
        }

        public IList<ListLockUnspentResult> ListLockUnspent()
        {
            return GetRPCTypedResult<List<ListLockUnspentResult>>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[0]);
        }

        public IList<ListReceivedByAccountResult> ListReceivedByAccount(int minconf = 1, bool includeEmpty = false, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<List<ListReceivedByAccountResult>>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { minconf,includeEmpty,includeWatchOnly });
        }

        public IList<ListReceivedByAddressResult> ListReceivedByAddress(int minconf = 1, bool includeEmpty = false, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<List<ListReceivedByAddressResult>>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { minconf, includeEmpty, includeWatchOnly });
        }

        public ListSinceBlockResult ListSinceBlock(string blockhash = null, int targetCOnfirmations = 1, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<ListSinceBlockResult>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { $"{blockhash}", targetCOnfirmations, includeWatchOnly });
        }

        public IList<ListTransactionsResult> ListTransactions(string account = "*", int count = 10, int from = 0, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<List<ListTransactionsResult>>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { $"{account}", count, from, includeWatchOnly });
        }

        public IList<ListUnspentResult> ListUnspent(int minconf = 1, int maxconf = 9999999, IList<string> addresses = null)
        {
            return GetRPCTypedResult<List<ListUnspentResult>>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { minconf, maxconf, addresses });
        }

        public bool LockUnspent(bool unlock, IList<LockUnspentInputTransaction> transactions)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { unlock, transactions });
        }

        public bool Move(string fromAccount = "", string toAccount = "", float amount = float.NaN, int minconf = 1, string comment = null)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { $"{fromAccount}", $"{toAccount}", amount, minconf, $"{comment}" });
        }

        public string SendFrom(string fromAccount = "", string toAccount = "", float amount = float.NaN, int minconf = 1, string comment = null)
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { $"{fromAccount}", $"{toAccount}", amount, minconf, $"{comment}" });
        }

        public string SendMany(string address, IList<SendManyInput> outputs, int minconf = 1, string comment = null, IList<string> subtractfeefromamount = null)
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.BackupWallet], new object[] { $"{address}", outputs, minconf, $"{comment}", subtractfeefromamount });
        }

        public string SendToAddress(string address, float amount, string comment, string commentto,
            bool subtractfeefromamount = false)
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.SendToAddress], new object[] { $"{address}", amount, $"{comment}", $"{commentto}", subtractfeefromamount });
        }

        public void SetAccount(string address, string account = "")
        {
            new RPCConnection().RunCommand(ZendRPCCommands[ZendRPCCommand.SetAccount], new object[] { $"{address}", $"{account}", });
        }

        public bool SetTxFee(float amount)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommands[ZendRPCCommand.SetTxFee], new object[] { amount });
        }

        public string SignMessage(string taddr, string message)
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.SignMessage], new object[] { $"{taddr}", $"{message}" });
        }

        #endregion
    }
}
