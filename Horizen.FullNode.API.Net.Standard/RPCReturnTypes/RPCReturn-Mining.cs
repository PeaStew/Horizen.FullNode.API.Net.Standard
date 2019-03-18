using System;
using System.Collections.Generic;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard.RPCReturnTypes
{
    #region Mining

    public class GetBlockSubsidyResult
    {
        public double miner { get; set; }
        public double community { get; set; }
        public double securenodes { get; set; }
        public double supernodes { get; set; }
    }


    public class GetBlockTemplateResult
    {
        public string[] capabilities { get; set; }
        public int version { get; set; }
        public string previousblockhash { get; set; }
        public Transaction[] transactions { get; set; }
        public Coinbasetxn coinbasetxn { get; set; }
        public string longpollid { get; set; }
        public string target { get; set; }
        public int mintime { get; set; }
        public string[] mutable { get; set; }
        public string noncerange { get; set; }
        public int sigoplimit { get; set; }
        public int sizelimit { get; set; }
        public int curtime { get; set; }
        public string bits { get; set; }
        public int height { get; set; }

        public class Coinbasetxn
        {
            public string data { get; set; }
            public string hash { get; set; }
            public object[] depends { get; set; }
            public int fee { get; set; }
            public int sigops { get; set; }
            public int communityfund { get; set; }
            public int securenodes { get; set; }
            public int supernodes { get; set; }
            public bool required { get; set; }
        }

        public class Transaction
        {
            public string data { get; set; }
            public string hash { get; set; }
            public int?[] depends { get; set; }
            public int fee { get; set; }
            public int sigops { get; set; }
        }
    }


    public class GetMiningInfoResult
    {
        public int blocks { get; set; }
        public int currentblocksize { get; set; }
        public int currentblocktx { get; set; }
        public double difficulty { get; set; }
        public string errors { get; set; }
        public int genproclimit { get; set; }
        public int localsolps { get; set; }
        public int networksolps { get; set; }
        public int networkhashps { get; set; }
        public int pooledtx { get; set; }
        public bool testnet { get; set; }
        public string chain { get; set; }
        public bool generate { get; set; }
    }

    #endregion
}
