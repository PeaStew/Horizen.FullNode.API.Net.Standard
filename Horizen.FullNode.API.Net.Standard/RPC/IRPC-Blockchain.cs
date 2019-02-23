using System.Collections.Generic;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;

namespace Horizen.FullNode.API.Net.Standard.RPC
{
    public partial interface IRPC
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

        GetBlockResult GetBlock(string hash, bool verbose = true);
        string GetBlockNotVerbose(string hash, bool verbose = false);
        GetBlockResult GetBlock(int height, bool verbose = true);
        string GetBlockNotVerbose(int height, bool verbose = false);

        GetBlockChainInfoResult GetBlockChainInfo();

        int GetBlockCount();

        Blockhash GetBlockHash(int index);

        GetBlockHeaderResult GetBlockHeader(string hash, bool verbose = true);
        string GetBlockHeaderNotVerbose(string hash, bool verbose = false);

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
