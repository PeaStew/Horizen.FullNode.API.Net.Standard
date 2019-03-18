using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard.RPCReturnTypes
{

    #region Blockchain

    public class GetBlockResult
    {
        public string hash { get; set; }
        public int confirmations { get; set; }
        public int size { get; set; }
        public int height { get; set; }
        public int version { get; set; }
        public string merkleroot { get; set; }
        public string[] tx { get; set; }
        public int time { get; set; }
        public string nonce { get; set; }
        public string solution { get; set; }
        public string bits { get; set; }
        public decimal difficulty { get; set; }
        public string chainwork { get; set; }
        public string anchor { get; set; }
        public string previousblockhash { get; set; }
    }


    public class GetBlockChainInfoResult
    {
        public string chain { get; set; }
        public int blocks { get; set; }
        public int headers { get; set; }
        public string bestblockhash { get; set; }
        public decimal difficulty { get; set; }
        public decimal verificationprogress { get; set; }
        public string chainwork { get; set; }
        public bool pruned { get; set; }
        public int commitments { get; set; }
        public Valuepool[] valuePools { get; set; }
        public Softfork[] softforks { get; set; }
        public Bip9_Softforks bip9_softforks { get; set; }

        public class Bip9_Softforks
        {
        }

        public class Valuepool
        {
            public string id { get; set; }
            public bool monitored { get; set; }
        }

        public class Softfork
        {
            public string id { get; set; }
            public int version { get; set; }
            public Enforce enforce { get; set; }
            public Reject reject { get; set; }
        }

        public class Enforce
        {
            public bool status { get; set; }
            public int found { get; set; }
            public int required { get; set; }
            public int window { get; set; }
        }

        public class Reject
        {
            public bool status { get; set; }
            public int found { get; set; }
            public int required { get; set; }
            public int window { get; set; }
        }
    }


    public class GetBlockHeaderResult
    {
        public string hash { get; set; }
        public int confirmations { get; set; }
        public int height { get; set; }
        public int version { get; set; }
        public string merkleroot { get; set; }
        public int time { get; set; }
        public string nonce { get; set; }
        public string solution { get; set; }
        public string bits { get; set; }
        public decimal difficulty { get; set; }
        public string chainwork { get; set; }
        public string previousblockhash { get; set; }
        public string nextblockhash { get; set; }
    }


    public class GetChainTipsResult
    {
        public IList<ChainTip> ChainTips { get; set; }

        public class ChainTip
        {
            public int height { get; set; }
            public string hash { get; set; }
            public int branchlen { get; set; }
            public string status { get; set; }
        }
    }


    public class GetMemPoolInfoResult
    {
        public int size { get; set; }
        public int bytes { get; set; }
        public int usage { get; set; }
    }


    public class GetRawMemPoolResult
    {
        public int size { get; set; }
        public decimal fee { get; set; }
        public int time { get; set; }
        public int height { get; set; }
        public decimal startingpriority { get; set; }
        public decimal currentpriority { get; set; }
        public string[] depends { get; set; }
    }

    public class GetTxOutResult
    {
        public string bestblock { get; set; }
        public int confirmations { get; set; }
        public decimal value { get; set; }
        public Scriptpubkey scriptPubKey { get; set; }
        public int version { get; set; }
        public bool coinbase { get; set; }

        public class Scriptpubkey
        {
            public string asm { get; set; }
            public string hex { get; set; }
            public int reqSigs { get; set; }
            public string type { get; set; }
            public string[] addresses { get; set; }
        }
    }


    public class GetTxOutSetInfoResult
    {
        public int height { get; set; }
        public string bestblock { get; set; }
        public int transactions { get; set; }
        public int txouts { get; set; }
        public int bytes_serialized { get; set; }
        public string hash_serialized { get; set; }
        public decimal total_amount { get; set; }
    }

    #endregion


}
