using System.Collections.Generic;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;

namespace Horizen.FullNode.API.Net.Standard.RPC
{
    public partial interface IRPCBlockchain
    {
        /* == Blockchain ==
        getbestblockhash
        getblock "hash|height" ( verbose )
        getblockchaininfo
        getblockcount
        getblockhash index
        getblockheader "hash" ( verbose )
        getchaintips
        getdifficulty
        getmempoolinfo
        getrawmempool ( verbose )
        gettxout "txid" n ( includemempool )
        gettxoutproof ["txid",...] ( blockhash )
        gettxoutsetinfo
        verifychain ( checklevel numblocks )
        verifytxoutproof "proof"
        */
        string GetBestBlockHash();

        GetBlockResult GetBlock(string hash, int verbosity);
        string GetBlock(string hash);
        GetBlockResult GetBlock(int height, int verbosity);
        string GetBlock(int height);

        GetBlockChainInfoResult GetBlockChainInfo();

        int GetBlockCount();

        string GetBlockHash(int index);

        GetBlockHeaderResult GetBlockHeader(string hash, bool verbose = true);
        string GetBlockHeader(string hash);

        float GetDifficulty();

        GetMemPoolInfoResult GetMemPoolInfo();

        IList<string> GetRawMemPool(bool verbose = true);

        GetTxOutResult GetTxOut(string txid, int voutValue, bool includemempool = true);

        string GetTxOutProof(IList<string> txids, string blockhash = null);

        GetTxOutSetInfoResult GetTxOutSetInfo();

        bool VerifyChain(int? checklevel = null, int? numblocks = null);

        IList<string> VerifyTxtOutProof(string proof);
    }
}
