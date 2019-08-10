using System.Collections.Generic;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;

namespace Horizen.FullNode.API.Net.Standard.RPC
{
    public partial interface IZendRPCBlockchain
    {
        /* == Blockchain ==
        getbestblockhash
        getblock "hash|height" (RPCConnection rpc, verbose )
        getblockchaininfo
        getblockcount
        getblockhash index
        getblockheader "hash" (RPCConnection rpc, verbose )
        getchaintips
        getdifficulty
        getmempoolinfo
        getrawmempool (RPCConnection rpc, verbose )
        gettxout "txid" n (RPCConnection rpc, includemempool )
        gettxoutproof ["txid",...] (RPCConnection rpc, blockhash )
        gettxoutsetinfo
        verifychain (RPCConnection rpc, checklevel numblocks )
        verifytxoutproof "proof"
        */
        string GetBestBlockHash(RPCConnection rpc);

        GetBlockResult GetBlock(RPCConnection rpc,string hash, int verbosity);
        string GetBlock(RPCConnection rpc,string hash);
        GetBlockResult GetBlock(RPCConnection rpc,int height, int verbosity);
        string GetBlock(RPCConnection rpc,int height);

        GetBlockChainInfoResult GetBlockChainInfo(RPCConnection rpc);

        int GetBlockCount(RPCConnection rpc);

        string GetBlockHash(RPCConnection rpc,int index);

        GetBlockHeaderResult GetBlockHeader(RPCConnection rpc,string hash, bool verbose = true);
        string GetBlockHeader(RPCConnection rpc,string hash);
        IList<GetChainTipsResult> GetChainTips(RPCConnection rpc);

        double GetDifficulty(RPCConnection rpc);

        GetMemPoolInfoResult GetMemPoolInfo(RPCConnection rpc);

        IList<string> GetRawMemPool(RPCConnection rpc);
        Dictionary<string, GetRawMemPoolResult> GetRawMemPool(RPCConnection rpc,bool verbose = true);

        GetTxOutResult GetTxOut(RPCConnection rpc,string txid, int voutValue, bool includemempool = true);

        string GetTxOutProof(RPCConnection rpc,IList<string> txids, string blockhash = null);

        GetTxOutSetInfoResult GetTxOutSetInfo(RPCConnection rpc);

        bool VerifyChain(RPCConnection rpc,int checklevel = 3, int numblocks = 288);

        IList<string> VerifyTxOutProof(RPCConnection rpc,string proof);
    }
}
