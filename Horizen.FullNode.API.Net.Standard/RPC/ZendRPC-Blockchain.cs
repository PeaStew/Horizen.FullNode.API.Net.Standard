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
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.GetBestBlockHash], new object[0]);
        }

        public GetBlockResult GetBlock(string hash, int verbosity)
        {
            return GetRPCTypedResult<GetBlockResult>(ZendRPCCommands[ZendRPCCommand.GetBlock], new object[] { $"{hash}", true });
        }

        public string GetBlock(string hash)
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.GetBlock], new object[] { $"{hash}", false });
        }

        public GetBlockResult GetBlock(int height, int verbosity)
        {
            return GetRPCTypedResult<GetBlockResult>(ZendRPCCommands[ZendRPCCommand.GetBlock], new object[] { $"{height}", true });
        }

        public string GetBlock(int height)
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.GetBlock], new object[] { $"{height}", false });
        }

        public GetBlockChainInfoResult GetBlockChainInfo()
        {
            return GetRPCTypedResult<GetBlockChainInfoResult>(ZendRPCCommands[ZendRPCCommand.GetBlockchainInfo], new object[0]);}

        public int GetBlockCount()
        {
            return GetRPCTypedResult<int>(ZendRPCCommands[ZendRPCCommand.GetBlockCount], new object[0]);
        }

        public string GetBlockHash(int index)
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.GetBlockHash], new object[] { index });
        }

        public GetBlockHeaderResult GetBlockHeader(string hash, bool verbose)
        {
            return GetRPCTypedResult<GetBlockHeaderResult>(ZendRPCCommands[ZendRPCCommand.GetBlockHeader], new object[] { $"{hash}", true });
        }

        public string GetBlockHeader(string hash)
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.GetBlockHeader], new object[] { $"{hash}", false });
        }

        public float GetDifficulty()
        {
            return GetRPCTypedResult<float>(ZendRPCCommands[ZendRPCCommand.GetDifficulty], new object[0]);
        }

        public GetMemPoolInfoResult GetMemPoolInfo()
        {
            return GetRPCTypedResult<GetMemPoolInfoResult>(ZendRPCCommands[ZendRPCCommand.GetMemPoolInfo], new object[0]);
        }

        public IList<string> GetRawMemPool()
        {
            return GetRPCTypedResult<List<string>>(ZendRPCCommands[ZendRPCCommand.GetRawMemPool], new object[0]);
        }

        public Dictionary<string,GetRawMemPoolResult> GetRawMemPool(bool verbose)
        {
            return GetRPCTypedResult<Dictionary<string, GetRawMemPoolResult>>(ZendRPCCommands[ZendRPCCommand.GetRawMemPool], new object[]{true});
        }

        public GetTxOutResult GetTxOut(string txid, int voutValue, bool includemempool = true)
        {
            return GetRPCTypedResult<GetTxOutResult>(ZendRPCCommands[ZendRPCCommand.GetTxOut], new object[] { $"{txid}",$"{voutValue}",includemempool});
        }

        public string GetTxOutProof(IList<string> txids, string blockhash = null)
        {
            return GetRPCTypedResult<string>(ZendRPCCommands[ZendRPCCommand.GetTxOutProof], new object[] { txids, blockhash });
        }

        public GetTxOutSetInfoResult GetTxOutSetInfo()
        {
            return GetRPCTypedResult<GetTxOutSetInfoResult>(ZendRPCCommands[ZendRPCCommand.GetTxOutSetInfo], new object[0]);
        }

        public bool VerifyChain(int checklevel = 3, int numblocks = 288)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommands[ZendRPCCommand.VerifyChain], new object []{checklevel,numblocks});
        }

        public IList<string> VerifyTxOutProof(string proof)
        {
            return GetRPCTypedResult<List<string>>(ZendRPCCommands[ZendRPCCommand.VerifyTxOutProof], new object[] { $"{proof}"});
        }
        #endregion

    }
}
