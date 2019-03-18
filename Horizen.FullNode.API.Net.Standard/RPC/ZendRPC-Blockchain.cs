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
            return GetRPCTypedResult<string>(ZendRPCCommand.GetBestBlockHash.GetDescription(), new object[0]);
        }

        public GetBlockResult GetBlock(string hash, int verbosity)
        {
            return GetRPCTypedResult<GetBlockResult>(ZendRPCCommand.GetBlock.GetDescription(), new object[] { $"{hash}", true });
        }

        public string GetBlock(string hash)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.GetBlock.GetDescription(), new object[] { $"{hash}", false });
        }

        public GetBlockResult GetBlock(int height, int verbosity)
        {
            return GetRPCTypedResult<GetBlockResult>(ZendRPCCommand.GetBlock.GetDescription(), new object[] { $"{height}", true });
        }

        public string GetBlock(int height)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.GetBlock.GetDescription(), new object[] { $"{height}", false });
        }

        public GetBlockChainInfoResult GetBlockChainInfo()
        {
            return GetRPCTypedResult<GetBlockChainInfoResult>(ZendRPCCommand.GetBlockchainInfo.GetDescription(), new object[0]);}

        public int GetBlockCount()
        {
            return GetRPCTypedResult<int>(ZendRPCCommand.GetBlockCount.GetDescription(), new object[0]);
        }

        public string GetBlockHash(int index)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.GetBlockHash.GetDescription(), new object[] { index });
        }

        public GetBlockHeaderResult GetBlockHeader(string hash, bool verbose)
        {
            return GetRPCTypedResult<GetBlockHeaderResult>(ZendRPCCommand.GetBlockHeader.GetDescription(), new object[] { $"{hash}", true });
        }

        public string GetBlockHeader(string hash)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.GetBlockHeader.GetDescription(), new object[] { $"{hash}", false });
        }

        public IList<GetChainTipsResult> GetChainTips()
        {
            return GetRPCTypedResult<List<GetChainTipsResult>>(ZendRPCCommand.GetChainTips.GetDescription(),
                new object[0]);
        }

        public decimal GetDifficulty()
        {
            return GetRPCTypedResult<decimal>(ZendRPCCommand.GetDifficulty.GetDescription(), new object[0]);
        }

        public GetMemPoolInfoResult GetMemPoolInfo()
        {
            return GetRPCTypedResult<GetMemPoolInfoResult>(ZendRPCCommand.GetMemPoolInfo.GetDescription(), new object[0]);
        }

        public IList<string> GetRawMemPool()
        {
            return GetRPCTypedResult<List<string>>(ZendRPCCommand.GetRawMemPool.GetDescription(), new object[0]);
        }

        public Dictionary<string,GetRawMemPoolResult> GetRawMemPool(bool verbose)
        {
            return GetRPCTypedResult<Dictionary<string, GetRawMemPoolResult>>(ZendRPCCommand.GetRawMemPool.GetDescription(), new object[]{true});
        }

        public GetTxOutResult GetTxOut(string txid, int voutValue, bool includemempool = true)
        {
            return GetRPCTypedResult<GetTxOutResult>(ZendRPCCommand.GetTxOut.GetDescription(), new object[] { $"{txid}",$"{voutValue}",includemempool});
        }

        public string GetTxOutProof(IList<string> txids, string blockhash = null)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.GetTxOutProof.GetDescription(), new object[] { txids, blockhash });
        }

        public GetTxOutSetInfoResult GetTxOutSetInfo()
        {
            return GetRPCTypedResult<GetTxOutSetInfoResult>(ZendRPCCommand.GetTxOutSetInfo.GetDescription(), new object[0]);
        }

        public bool VerifyChain(int checklevel = 3, int numblocks = 288)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommand.VerifyChain.GetDescription(), new object []{checklevel,numblocks});
        }

        public IList<string> VerifyTxOutProof(string proof)
        {
            return GetRPCTypedResult<List<string>>(ZendRPCCommand.VerifyTxOutProof.GetDescription(), new object[] { $"{proof}"});
        }
        #endregion

    }
}
