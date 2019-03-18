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
            return GetRPCTypedResult<string>(ZendRPCCommand.AddMultisigAddress.GetDescription(), new object[] { nrequired, keysobject });
        }

        public string BackupWallet(string filename)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.BackupWallet.GetDescription(), new object[] { $"{filename}" });
        }

        public string DumpPrivKey(string t_addr)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.DumpPrivkey.GetDescription(), new object[] { $"{t_addr}" });
        }

        public string DumpWallet(string filename)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.DumpWallet.GetDescription(), new object[] { $"{filename}" });
        }

        public bool EncryptWallet(string passphrase)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommand.EncryptWallet.GetDescription(), new object[] { $"{passphrase}" });
        }

        public string GetAccount(string address)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.GetAccount.GetDescription(), new object[] { $"{address}" });
        }

        public string GetAccountAddress(string address = "")
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.GetAccountAddress.GetDescription(), new object[] { $"{address}" });
        }

        public IList<string> GetAddressesByAccount(string address = "")
        {
            return GetRPCTypedResult<List<string>>(ZendRPCCommand.GetAddressByAccount.GetDescription(), new object[] { $"{address}" });
        }

        public decimal GetBalance(string account = "", int minconf = 1, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<decimal>(ZendRPCCommand.GetBalance.GetDescription(), new object[] { $"{account}",minconf,includeWatchOnly });
        }

        public string GetNewAddress(string account = "")
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.GetNewAddress.GetDescription(), new object[] { $"{account}" });
        }

        public string GetRawChangeAddress()
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.GetRawChangeAddress.GetDescription(), new object[0]);
        }

        public decimal GetReceivedByAccount(string account = "", int minconf = 1)
        {
            return GetRPCTypedResult<decimal>(ZendRPCCommand.GetReceivedByAccount.GetDescription(), new object[] { $"{account}", minconf });
        }

        public decimal GetReceivedByAddress(string address, int minconf = 1)
        {
            return GetRPCTypedResult<decimal>(ZendRPCCommand.GetReceivedByAddress.GetDescription(), new object[] { $"{address}", minconf });
        }

        public GetTransactionResult GetTransaction(string txid, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<GetTransactionResult>(ZendRPCCommand.GetTransaction.GetDescription(), new object[] { $"{txid}", includeWatchOnly });
        }

        public decimal GetUnconfirmedBalance()
        {
            return GetRPCTypedResult<decimal>(ZendRPCCommand.GetUnconfirmedBalance.GetDescription(), new object[0]);
        }

        public GetWalletInfoResult GetWalletInfo()
        {
            return GetRPCTypedResult<GetWalletInfoResult>(ZendRPCCommand.GetWalletInfo.GetDescription(), new object[0]);
        }

        public bool ImportAddress(string address, string label = "", bool rescan = true)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommand.ImportAddress.GetDescription(), new object[] { $"{address}", $"{label}", rescan });
        }

        public bool ImportPrivKey(string privkey, string label = "", bool rescan = true)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommand.ImportPrivkey.GetDescription(), new object[] { $"{privkey}", $"{label}",rescan });
        }

        public bool ImportWallet(string filepath)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommand.ImportWallet.GetDescription(), new object[] { $"{filepath}" });
        }

        public bool KeyPoolRefill(int newsize)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommand.KeyPoolRefill.GetDescription(), new object[] { newsize });
        }

        public IList<ListAccountsResult> ListAccounts(int minconf = 1, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<List<ListAccountsResult>>(ZendRPCCommand.ListAccounts.GetDescription(), new object[] { minconf,includeWatchOnly });
        }

        public IList<string> ListAddresses()
        {
            return GetRPCTypedResult<List<string>>(ZendRPCCommand.ListAddresses.GetDescription(), new object[0]);
        }

        public object[][][] ListAddressGroupings()
        {
            return GetRPCTypedResult<object[][][]>(ZendRPCCommand.ListAddressGroupings.GetDescription(), new object[0]);
        }

        public IList<ListLockUnspentResult> ListLockUnspent()
        {
            return GetRPCTypedResult<List<ListLockUnspentResult>>(ZendRPCCommand.ListLockUnspent.GetDescription(), new object[0]);
        }

        public IList<ListReceivedByAccountResult> ListReceivedByAccount(int minconf = 1, bool includeEmpty = false, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<List<ListReceivedByAccountResult>>(ZendRPCCommand.ListReceivedByAccount.GetDescription(), new object[] { minconf,includeEmpty,includeWatchOnly });
        }

        public IList<ListReceivedByAddressResult> ListReceivedByAddress(int minconf = 1, bool includeEmpty = false, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<List<ListReceivedByAddressResult>>(ZendRPCCommand.ListReceivedByAddress.GetDescription(), new object[] { minconf, includeEmpty, includeWatchOnly });
        }

        public ListSinceBlockResult ListSinceBlock(string blockhash = null, int targetCOnfirmations = 1, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<ListSinceBlockResult>(ZendRPCCommand.ListSinceBlock.GetDescription(), new object[] { $"{blockhash}", targetCOnfirmations, includeWatchOnly });
        }

        public IList<ListTransactionsResult> ListTransactions(string account = "*", int count = 10, int from = 0, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<List<ListTransactionsResult>>(ZendRPCCommand.ListTransactions.GetDescription(), new object[] { $"{account}", count, from, includeWatchOnly });
        }

        public IList<ListUnspentResult> ListUnspent(int minconf = 1, int maxconf = 9999999, IList<string> addresses = null)
        {
            return GetRPCTypedResult<List<ListUnspentResult>>(ZendRPCCommand.ListUnspent.GetDescription(), new object[] { minconf, maxconf, addresses });
        }

        public bool LockUnspent(bool unlock, IList<LockUnspentInputTransaction> transactions)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommand.LockUnspent.GetDescription(), new object[] { unlock, transactions });
        }

        public bool Move(string fromAccount = "", string toAccount = "", decimal amount = decimal.Zero, int minconf = 1, string comment = null)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommand.Move.GetDescription(), new object[] { $"{fromAccount}", $"{toAccount}", amount, minconf, $"{comment}" });
        }

        public string SendFrom(string fromAccount = "", string toAccount = "", decimal amount = decimal.Zero, int minconf = 1, string comment = null)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.SendFrom.GetDescription(), new object[] { $"{fromAccount}", $"{toAccount}", amount, minconf, $"{comment}" });
        }

        public string SendMany(string address, IList<SendManyInput> outputs, int minconf = 1, string comment = null, IList<string> subtractfeefromamount = null)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.SendMany.GetDescription(), new object[] { $"{address}", outputs, minconf, $"{comment}", subtractfeefromamount });
        }

        public string SendToAddress(string address, decimal amount, string comment, string commentto,
            bool subtractfeefromamount = false)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.SendToAddress.GetDescription(), new object[] { $"{address}", amount, $"{comment}", $"{commentto}", subtractfeefromamount });
        }

        public void SetAccount(string address, string account = "")
        {
            new RPCConnection().RunCommand(ZendRPCCommand.SetAccount.GetDescription(), new object[] { $"{address}", $"{account}", });
        }

        public bool SetTxFee(decimal amount)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommand.SetTxFee.GetDescription(), new object[] { amount });
        }

        public string SignMessage(string taddr, string message)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.SignMessage.GetDescription(), new object[] { $"{taddr}", $"{message}" });
        }

        #endregion
    }
}
