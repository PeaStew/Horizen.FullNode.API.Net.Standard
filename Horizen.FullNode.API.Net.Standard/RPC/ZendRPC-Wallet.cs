﻿using System;
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
        public string AddMultiSigAddress(RPCConnection rpc, int nrequired, IList<string> keysobject)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.AddMultisigAddress.GetDescription(), new object[] { nrequired, keysobject });
        }

        public string BackupWallet(RPCConnection rpc, string filename)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.BackupWallet.GetDescription(), new object[] { $"{filename}" });
        }

        public string DumpPrivKey(RPCConnection rpc, string t_addr)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.DumpPrivkey.GetDescription(), new object[] { $"{t_addr}" });
        }

        public string DumpWallet(RPCConnection rpc, string filename)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.DumpWallet.GetDescription(), new object[] { $"{filename}" });
        }

        public bool EncryptWallet(RPCConnection rpc, string passphrase)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.EncryptWallet.GetDescription(), new object[] { $"{passphrase}" });
        }

        public string GetAccount(RPCConnection rpc, string address)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.GetAccount.GetDescription(), new object[] { $"{address}" });
        }

        public string GetAccountAddress(RPCConnection rpc, string address = "")
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.GetAccountAddress.GetDescription(), new object[] { $"{address}" });
        }

        public IList<string> GetAddressesByAccount(RPCConnection rpc, string address = "")
        {
            return GetRPCTypedResult<List<string>>(rpc, ZendRPCCommand.GetAddressByAccount.GetDescription(), new object[] { $"{address}" });
        }

        public double GetBalance(RPCConnection rpc, string account = "", int minconf = 1, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<double>(rpc, ZendRPCCommand.GetBalance.GetDescription(), new object[] { $"{account}",minconf,includeWatchOnly });
        }

        public string GetNewAddress(RPCConnection rpc, string account = "")
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.GetNewAddress.GetDescription(), new object[] { $"{account}" });
        }

        public string GetRawChangeAddress(RPCConnection rpc)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.GetRawChangeAddress.GetDescription(), new object[0]);
        }

        public double GetReceivedByAccount(RPCConnection rpc, string account = "", int minconf = 1)
        {
            return GetRPCTypedResult<double>(rpc, ZendRPCCommand.GetReceivedByAccount.GetDescription(), new object[] { $"{account}", minconf });
        }

        public double GetReceivedByAddress(RPCConnection rpc, string address, int minconf = 1)
        {
            return GetRPCTypedResult<double>(rpc, ZendRPCCommand.GetReceivedByAddress.GetDescription(), new object[] { $"{address}", minconf });
        }

        public GetTransactionResult GetTransaction(RPCConnection rpc, string txid, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<GetTransactionResult>(rpc, ZendRPCCommand.GetTransaction.GetDescription(), new object[] { $"{txid}", includeWatchOnly });
        }

        public double GetUnconfirmedBalance(RPCConnection rpc)
        {
            return GetRPCTypedResult<double>(rpc, ZendRPCCommand.GetUnconfirmedBalance.GetDescription(), new object[0]);
        }

        public GetWalletInfoResult GetWalletInfo(RPCConnection rpc)
        {
            return GetRPCTypedResult<GetWalletInfoResult>(rpc, ZendRPCCommand.GetWalletInfo.GetDescription(), new object[0]);
        }

        public bool ImportAddress(RPCConnection rpc, string address, string label = "", bool rescan = true)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.ImportAddress.GetDescription(), new object[] { $"{address}", $"{label}", rescan });
        }

        public bool ImportPrivKey(RPCConnection rpc, string privkey, string label = "", bool rescan = true)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.ImportPrivkey.GetDescription(), new object[] { $"{privkey}", $"{label}",rescan });
        }

        public bool ImportWallet(RPCConnection rpc, string filepath)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.ImportWallet.GetDescription(), new object[] { $"{filepath}" });
        }

        public bool KeyPoolRefill(RPCConnection rpc, int newsize)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.KeyPoolRefill.GetDescription(), new object[] { newsize });
        }

        public IList<ListAccountsResult> ListAccounts(RPCConnection rpc, int minconf = 1, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<List<ListAccountsResult>>(rpc, ZendRPCCommand.ListAccounts.GetDescription(), new object[] { minconf,includeWatchOnly });
        }

        public IList<string> ListAddresses(RPCConnection rpc)
        {
            return GetRPCTypedResult<List<string>>(rpc, ZendRPCCommand.ListAddresses.GetDescription(), new object[0]);
        }

        public object[][][] ListAddressGroupings(RPCConnection rpc)
        {
            return GetRPCTypedResult<object[][][]>(rpc, ZendRPCCommand.ListAddressGroupings.GetDescription(), new object[0]);
        }

        public IList<ListLockUnspentResult> ListLockUnspent(RPCConnection rpc)
        {
            return GetRPCTypedResult<List<ListLockUnspentResult>>(rpc, ZendRPCCommand.ListLockUnspent.GetDescription(), new object[0]);
        }

        public IList<ListReceivedByAccountResult> ListReceivedByAccount(RPCConnection rpc, int minconf = 1, bool includeEmpty = false, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<List<ListReceivedByAccountResult>>(rpc, ZendRPCCommand.ListReceivedByAccount.GetDescription(), new object[] { minconf,includeEmpty,includeWatchOnly });
        }

        public IList<ListReceivedByAddressResult> ListReceivedByAddress(RPCConnection rpc, int minconf = 1, bool includeEmpty = false, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<List<ListReceivedByAddressResult>>(rpc, ZendRPCCommand.ListReceivedByAddress.GetDescription(), new object[] { minconf, includeEmpty, includeWatchOnly });
        }

        public ListSinceBlockResult ListSinceBlock(RPCConnection rpc, string blockhash = null, int targetCOnfirmations = 1, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<ListSinceBlockResult>(rpc, ZendRPCCommand.ListSinceBlock.GetDescription(), new object[] { $"{blockhash}", targetCOnfirmations, includeWatchOnly });
        }

        public IList<ListTransactionsResult> ListTransactions(RPCConnection rpc, string account = "*", int count = 10, int from = 0, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<List<ListTransactionsResult>>(rpc, ZendRPCCommand.ListTransactions.GetDescription(), new object[] { $"{account}", count, from, includeWatchOnly });
        }

        public IList<ListUnspentResult> ListUnspent(RPCConnection rpc, int minconf = 1, int maxconf = 9999999, IList<string> addresses = null)
        {
            return GetRPCTypedResult<List<ListUnspentResult>>(rpc, ZendRPCCommand.ListUnspent.GetDescription(), new object[] { minconf, maxconf, addresses });
        }

        public bool LockUnspent(RPCConnection rpc, bool unlock, IList<LockUnspentInputTransaction> transactions)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.LockUnspent.GetDescription(), new object[] { unlock, transactions });
        }

        public bool Move(RPCConnection rpc, string fromAccount = "", string toAccount = "", double amount = double.NaN, int minconf = 1, string comment = null)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.Move.GetDescription(), new object[] { $"{fromAccount}", $"{toAccount}", amount, minconf, $"{comment}" });
        }

        public string SendFrom(RPCConnection rpc, string fromAccount = "", string toAccount = "", double amount = double.NaN, int minconf = 1, string comment = null)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.SendFrom.GetDescription(), new object[] { $"{fromAccount}", $"{toAccount}", amount, minconf, $"{comment}" });
        }

        public string SendMany(RPCConnection rpc, string address, IList<SendManyInput> outputs, int minconf = 1, string comment = null, IList<string> subtractfeefromamount = null)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.SendMany.GetDescription(), new object[] { $"{address}", outputs, minconf, $"{comment}", subtractfeefromamount });
        }

        public string SendToAddress(RPCConnection rpc, string address, double amount, string comment, string commentto,
            bool subtractfeefromamount = false)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.SendToAddress.GetDescription(), new object[] { $"{address}", amount, $"{comment}", $"{commentto}", subtractfeefromamount });
        }

        public void SetAccount(RPCConnection rpc, string address, string account = "")
        {
            GetRPCTypedResult<object>(rpc, ZendRPCCommand.SetAccount.GetDescription(), new object[] { $"{address}", $"{account}", });
        }

        public bool SetTxFee(RPCConnection rpc, double amount)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.SetTxFee.GetDescription(), new object[] { amount });
        }

        public string SignMessage(RPCConnection rpc, string taddr, string message)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.SignMessage.GetDescription(), new object[] { $"{taddr}", $"{message}" });
        }

        #endregion
    }
}
