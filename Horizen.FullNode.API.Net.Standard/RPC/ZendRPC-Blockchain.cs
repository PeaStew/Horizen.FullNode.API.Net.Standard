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
        public string GetBestBlockHash(RPCConnection rpc)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.GetBestBlockHash, new object[0]);
        }

        public GetBlockResult GetBlock(RPCConnection rpc, string hash, int verbosity)
        {
            return GetRPCTypedResult<GetBlockResult>(rpc, ZendRPCCommand.GetBlock, new object[] { $"{hash}", true });
        }

        public string GetBlock(RPCConnection rpc, string hash)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.GetBlock, new object[] { $"{hash}", false });
        }

        public GetBlockResult GetBlock(RPCConnection rpc, int height, int verbosity)
        {
            var res = GetRPCTypedResult<GetBlockResult>(rpc, ZendRPCCommand.GetBlock, new object[] { $"{height}", true });
            return res;
        }

        public string GetBlock(RPCConnection rpc, int height)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.GetBlock, new object[] { $"{height}", true });
        }

        public GetBlockChainInfoResult GetBlockChainInfo(RPCConnection rpc)
        {
            return GetRPCTypedResult<GetBlockChainInfoResult>(rpc, ZendRPCCommand.GetBlockchainInfo, new object[0]);}

        public int GetBlockCount(RPCConnection rpc)
        {
            return GetRPCTypedResult<int>(rpc, ZendRPCCommand.GetBlockCount, new object[0]);
        }

        public string GetBlockHash(RPCConnection rpc, int index)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.GetBlockHash, new object[] { index });
        }

        public GetBlockHeaderResult GetBlockHeader(RPCConnection rpc, string hash, bool verbose)
        {
            return GetRPCTypedResult<GetBlockHeaderResult>(rpc, ZendRPCCommand.GetBlockHeader, new object[] { $"{hash}", true });
        }

        public string GetBlockHeader(RPCConnection rpc, string hash)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.GetBlockHeader, new object[] { $"{hash}", false });
        }

        public IList<GetChainTipsResult> GetChainTips(RPCConnection rpc)
        {
            return GetRPCTypedResult<List<GetChainTipsResult>>(rpc, ZendRPCCommand.GetChainTips,
                new object[0]);
        }

        public double GetDifficulty(RPCConnection rpc)
        {
            return GetRPCTypedResult<double>(rpc, ZendRPCCommand.GetDifficulty, new object[0]);
        }

        public GetMemPoolInfoResult GetMemPoolInfo(RPCConnection rpc)
        {
            return GetRPCTypedResult<GetMemPoolInfoResult>(rpc, ZendRPCCommand.GetMemPoolInfo, new object[0]);
        }

        public IList<string> GetRawMemPool(RPCConnection rpc)
        {
            return GetRPCTypedResult<List<string>>(rpc, ZendRPCCommand.GetRawMemPool, new object[0]);
        }

        public Dictionary<string,GetRawMemPoolResult> GetRawMemPool(RPCConnection rpc, bool verbose)
        {
            return GetRPCTypedResult<Dictionary<string, GetRawMemPoolResult>>(rpc, ZendRPCCommand.GetRawMemPool, new object[]{true});
        }

        public GetTxOutResult GetTxOut(RPCConnection rpc, string txid, int voutValue, bool includemempool = true)
        {
            return GetRPCTypedResult<GetTxOutResult>(rpc, ZendRPCCommand.GetTxOut, new object[] { $"{txid}",$"{voutValue}",includemempool});
        }

        public string GetTxOutProof(RPCConnection rpc, IList<string> txids, string blockhash = null)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.GetTxOutProof, new object[] { txids, blockhash });
        }

        public GetTxOutSetInfoResult GetTxOutSetInfo(RPCConnection rpc)
        {
            return GetRPCTypedResult<GetTxOutSetInfoResult>(rpc, ZendRPCCommand.GetTxOutSetInfo, new object[0]);
        }

        public bool VerifyChain(RPCConnection rpc, int checklevel = 3, int numblocks = 288)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.VerifyChain, new object []{checklevel,numblocks});
        }

        public IList<string> VerifyTxOutProof(RPCConnection rpc, string proof)
        {
            return GetRPCTypedResult<List<string>>(rpc, ZendRPCCommand.VerifyTxOutProof, new object[] { $"{proof}"});
        }
        #endregion

    }
}
