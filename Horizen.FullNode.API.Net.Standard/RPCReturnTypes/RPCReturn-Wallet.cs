using System;
using System.Collections.Generic;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard.RPCReturnTypes
{
    public class GetTransactionResult
    {
        public double amount { get; set; }
        public int confirmations { get; set; }
        public string blockhash { get; set; }
        public int blockindex { get; set; }
        public int blocktime { get; set; }
        public string txid { get; set; }
        public int time { get; set; }
        public int timereceived { get; set; }
        public Detail[] details { get; set; }
        public Vjoinsplit[] vjoinsplit { get; set; }
        public string hex { get; set; }

        public class Detail
        {
            public string account { get; set; }
            public string address { get; set; }
            public string category { get; set; }
            public double amount { get; set; }
            public int vout { get; set; }
        }

        public class Vjoinsplit
        {
            public string anchor { get; set; }
            public string[] nullifiers { get; set; }
            public string[] commitments { get; set; }
            public string[] macs { get; set; }
            public double vpub_old { get; set; }
            public double vpub_new { get; set; }
        }
    }


    public class GetWalletInfoResult
    {
        public int walletversion { get; set; }
        public double balance { get; set; }
        public double unconfirmed_balance { get; set; }
        public double immature_balance { get; set; }
        public int txcount { get; set; }
        public int keypoololdest { get; set; }
        public int keypoolsize { get; set; }
        public double paytxfee { get; set; }
    }


    public class ListAccountsResult
    {
        public double balance { get; set; }
    }


    public class ListLockUnspentResult
    {
        public string txid { get; set; }
        public int vout { get; set; }
    }

    public class ListReceivedByAccountResult
    {
        public string account { get; set; }
        public double amount { get; set; }
        public int confirmations { get; set; }
    }

    public class ListReceivedByAddressResult
    {
        public string address { get; set; }
        public string account { get; set; }
        public double amount { get; set; }
        public int confirmations { get; set; }
        public string[] txids { get; set; }
    }


    public class ListSinceBlockResult
    {
        public Transaction[] transactions { get; set; }
        public string lastblock { get; set; }

        public class Transaction
        {
            public string account { get; set; }
            public string address { get; set; }
            public string category { get; set; }
            public double amount { get; set; }
            public int vout { get; set; }
            public double fee { get; set; }
            public int confirmations { get; set; }
            public string blockhash { get; set; }
            public int blockindex { get; set; }
            public int blocktime { get; set; }
            public string txid { get; set; }
            public object[] walletconflicts { get; set; }
            public int time { get; set; }
            public int timereceived { get; set; }
            public Vjoinsplit[] vjoinsplit { get; set; }
            public int size { get; set; }

            public class Vjoinsplit
            {
                public double vpub_old { get; set; }
                public double vpub_new { get; set; }
                public string anchor { get; set; }
                public string[] nullifiers { get; set; }
                public string[] commitments { get; set; }
                public string onetimePubKey { get; set; }
                public string randomSeed { get; set; }
                public string[] macs { get; set; }
                public string proof { get; set; }
                public string[] ciphertexts { get; set; }
            }
        }
    }

    public class ListTransactionsResult
    {
        public string account { get; set; }
        public string address { get; set; }
        public string category { get; set; }
        public double amount { get; set; }
        public int vout { get; set; }
        public double fee { get; set; }
        public int confirmations { get; set; }
        public string blockhash { get; set; }
        public int blockindex { get; set; }
        public int blocktime { get; set; }
        public string txid { get; set; }
        public object[] walletconflicts { get; set; }
        public int time { get; set; }
        public int timereceived { get; set; }
        public Vjoinsplit[] vjoinsplit { get; set; }
        public int size { get; set; }

        public class Vjoinsplit
        {
            public double vpub_old { get; set; }
            public double vpub_new { get; set; }
            public string anchor { get; set; }
            public string[] nullifiers { get; set; }
            public string[] commitments { get; set; }
            public string onetimePubKey { get; set; }
            public string randomSeed { get; set; }
            public string[] macs { get; set; }
            public string proof { get; set; }
            public string[] ciphertexts { get; set; }
        }
    }



    public class ListUnspentResult
    {
        public string txid { get; set; }
        public int vout { get; set; }
        public bool generated { get; set; }
        public string address { get; set; }
        public string account { get; set; }
        public string scriptPubKey { get; set; }
        public double amount { get; set; }
        public int confirmations { get; set; }
        public bool spendable { get; set; }
    }

    public class LockUnspentInputTransaction
    {
        public string txid { get; set; }
        public int vout { get; set; }
    }
}
