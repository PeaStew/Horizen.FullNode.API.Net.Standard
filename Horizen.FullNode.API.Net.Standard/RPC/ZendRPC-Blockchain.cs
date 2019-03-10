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
        #region Blockchain
        public string GetBestBlockHash()
        {
            return GetRPCTypedResult<string>("getbestblockhash", new object[0]);
        }

        public GetBlockResult GetBlock(string hash, int verbosity)
        {
            return GetRPCTypedResult<GetBlockResult>("getblock", new object[] { $"{hash}", true });
        }

        public string GetBlock(string hash)
        {
            return GetRPCTypedResult<string>("getblock", new object[] { $"{hash}", false });
        }

        public GetBlockResult GetBlock(int height, int verbosity)
        {
            return GetRPCTypedResult<GetBlockResult>("getblock", new object[] { $"{height}", true });
        }

        public string GetBlock(int height)
        {
            return GetRPCTypedResult<string>("getblock", new object[] { $"{height}", false });
        }

        public GetBlockChainInfoResult GetBlockChainInfo()
        {
            return GetRPCTypedResult<GetBlockChainInfoResult>("getblockchaininfo", new object[0]);}

        public int GetBlockCount()
        {
            return GetRPCTypedResult<int>("getblockcount", new object[0]);
        }

        public string GetBlockHash(int index)
        {
            return GetRPCTypedResult<string>("getblockhash", new object[] { index });
        }

        public GetBlockHeaderResult GetBlockHeader(string hash, bool verbose)
        {
            return GetRPCTypedResult<GetBlockHeaderResult>("getblockheader", new object[] { $"{hash}", true });
        }

        public string GetBlockHeader(string hash)
        {
            return GetRPCTypedResult<string>("getblockheader", new object[] { $"{hash}", false });
        }

        public float GetDifficulty()
        {
            return GetRPCTypedResult<float>("getdifficulty", new object[0]);
        }

        public GetMemPoolInfoResult GetMemPoolInfo()
        {
            return GetRPCTypedResult<GetMemPoolInfoResult>("getmempoolinforesult", new object[0]);
        }

        public IList<string> GetRawMemPool()
        {
            return GetRPCTypedResult<List<string>>("getrawmempool", new object[0]);
        }

        public Dictionary<string,GetRawMemPoolResult> GetRawMemPool(bool verbose)
        {
            return GetRPCTypedResult<Dictionary<string, GetRawMemPoolResult>>("getrawmempool", new object[]{true});
        }

        public GetTxOutResult GetTxOut(string txid, int voutValue, bool includemempool = true)
        {
            return GetRPCTypedResult<GetTxOutResult>("gettxout", new object[] { $"{txid}",$"{voutValue}",includemempool});
        }

        public string GetTxOutProof(IList<string> txids, string blockhash = null)
        {
            return GetRPCTypedResult<string>("gettxoutproof", new object[] { txids, blockhash });
        }

        public GetTxOutSetInfoResult GetTxOutSetInfo()
        {
            return GetRPCTypedResult<GetTxOutSetInfoResult>("gettxoutsetinfo", new object[0]);
        }

        public bool VerifyChain(int checklevel = 3, int numblocks = 288)
        {
            return GetRPCTypedResult<bool>("verifychain", new object []{checklevel,numblocks});
        }

        public IList<string> VerifyTxOutProof(string proof)
        {
            return GetRPCTypedResult<List<string>>("verifytxoutproof", new object[] { $"{proof}"});
        }
        #endregion

    }
}
