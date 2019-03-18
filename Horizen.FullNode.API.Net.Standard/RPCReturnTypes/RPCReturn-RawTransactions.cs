using System;
using System.Collections.Generic;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard.RPCReturnTypes
{
    #region RawTransactions

    public class DecodeRawTransactionResult
    {
        public string txid { get; set; }
        public bool overwintered { get; set; }
        public int version { get; set; }
        public string versiongroupid { get; set; }
        public int locktime { get; set; }
        public int expiryheight { get; set; }
        public IList<Vin> vin { get; set; }
        public IList<Vout> vout { get; set; }
        public IList<Vjoinsplit> vjoinsplit { get; set; }

        public class Vin
        {
            public string txid { get; set; }
            public int vout { get; set; }
            public Scriptsig scriptSig { get; set; }
            public long sequence { get; set; }

            public class Scriptsig
            {
                public string asm { get; set; }
                public string hex { get; set; }
            }
        }

        public class Vout
        {
            public double value { get; set; }
            public int n { get; set; }
            public Scriptpubkey scriptPubKey { get; set; }

            public class Scriptpubkey
            {
                public string asm { get; set; }
                public string hex { get; set; }
                public int reqSigs { get; set; }
                public string type { get; set; }
                public IList<string> addresses { get; set; }
            }
        }

        public class Vjoinsplit
        {
            public double vpub_old { get; set; }
            public double vpub_new { get; set; }
            public string anchor { get; set; }
            public IList<string> nullifiers { get; set; }
            public IList<string> commitments { get; set; }
            public string onetimePubKey { get; set; }
            public string randomSeed { get; set; }
            public IList<string> macs { get; set; }
            public string proof { get; set; }
            public IList<string> ciphertexts { get; set; }
        }
    }

    public class DecodeScriptResult
    {
        public string asm { get; set; }
        public string hex { get; set; }
        public string type { get; set; }
        public int reqSigs { get; set; }
        public IList<string> addresses { get; set; }
        public string p2sh { get; set; }
    }

    public class FundRawTransactionResult
    {
        public string hex { get; set; }
        public double fee { get; set; }
        public int changepos { get; set; }
    }

    public class GetRawTransactionVerboseResult
    {

        public string hex { get; set; }
        public string txid { get; set; }
        public int version { get; set; }
        public int locktime { get; set; }
        public int expiryheight { get; set; }
        public Vin[] vin { get; set; }
        public Vout[] vout { get; set; }
        public Vjoinsplit[] vjoinsplit { get; set; }
        public string blockhash { get; set; }
        public int confirmations { get; set; }
        public int time { get; set; }
        public int blocktime { get; set; }


        public class Vin
        {
            public string txid { get; set; }
            public int vout { get; set; }
            public Scriptsig scriptSig { get; set; }
            public long sequence { get; set; }
        }

        public class Scriptsig
        {
            public string asm { get; set; }
            public string hex { get; set; }
        }

        public class Vout
        {
            public double value { get; set; }
            public int n { get; set; }
            public Scriptpubkey scriptPubKey { get; set; }
        }

        public class Scriptpubkey
        {
            public string asm { get; set; }
            public string hex { get; set; }
            public int reqSigs { get; set; }
            public string type { get; set; }
            public string[] addresses { get; set; }
        }

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


    public class SignRawTransactionResult
    {
        public string hex { get; set; }
        public bool complete { get; set; }
        public Error[] errors { get; set; }

        public class Error
        {
            public string txid { get; set; }
            public int vout { get; set; }
            public string scriptSig { get; set; }
            public long sequence { get; set; }
            public string error { get; set; }
        }
    }
    #endregion
}
