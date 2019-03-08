using System;
using System.Collections.Generic;
using System.Text;
using Horizen.FullNode.API.Net.Standard.RPC;
using Horizen.FullNode.API.Net.Standard.RPCInputTypes;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;
using Newtonsoft.Json;

namespace Horizen.FullNode.API.Net.Standard
{
    public class ZendRPC:IRPCBlockchain, IRPCControl, IRPCDisclosure, IRPCGenerating, IRPCMining, IRPCNetwork, IRPCRawTransaction, IRPCUtil, IRPCWallet, IRPCZCommands
    {
        public RPCConnection RpcConnection { get; private set; }

        public ZendRPC(RPCConnection rpcConnection)
        {
            RpcConnection = rpcConnection;
        }

        private string RunCommand(string commandName, object[] _params)
        {
            //TODO: Check for error
            var result = RpcConnection.GetRPCResult(new RPCData(Guid.NewGuid().ToString(), commandName, _params));
            Console.WriteLine(JsonConvert.SerializeObject(result.error));
            return JsonConvert.SerializeObject(result.result);
        }

        #region Blockchain
        public string GetBestBlockHash()
        {
            return RunCommand("getbestblockhash", new object[0]);
        }

        public GetBlockResult GetBlock(string hash, int verbosity)
        {
            return JsonConvert.DeserializeObject<GetBlockResult>(RunCommand("getblock", new object[] { $"{hash}", true }));
        }

        public string GetBlock(string hash)
        {
            return RunCommand("getblock", new object[] {$"{hash}", false});
        }

        public GetBlockResult GetBlock(int height, int verbosity)
        {
            return JsonConvert.DeserializeObject<GetBlockResult>(RunCommand("getblock", new object[] { $"{height}", true }));
        }

        public string GetBlock(int height)
        {
            return RunCommand("getblock", new object[] { $"{height}", false });
        }

        public GetBlockChainInfoResult GetBlockChainInfo()
        {
            return JsonConvert.DeserializeObject<GetBlockChainInfoResult>(RunCommand("getblockchaininfo", new object[0]));
        }

        public int GetBlockCount()
        {
            return int.Parse(RunCommand("getblockcount", new object[0]));
        }

        public string GetBlockHash(int index)
        {

            return RunCommand("getblockhash", new object[] { index });
        }

        public GetBlockHeaderResult GetBlockHeader(string hash, bool verbose)
        {
            throw new NotImplementedException();
        }

        public string GetBlockHeader(string hash)
        {
            throw new NotImplementedException();
        }

        public float GetDifficulty()
        {
            throw new NotImplementedException();
        }

        public GetMemPoolInfoResult GetMemPoolInfo()
        {
            throw new NotImplementedException();
        }

        public IList<string> GetRawMemPool(bool verbose = true)
        {
            throw new NotImplementedException();
        }

        public GetTxOutResult GetTxOut(string txid, int voutValue, bool includemempool = true)
        {
            throw new NotImplementedException();
        }

        public string GetTxOutProof(IList<string> txids, string blockhash = null)
        {
            throw new NotImplementedException();
        }

        public GetTxOutSetInfoResult GetTxOutSetInfo()
        {
            throw new NotImplementedException();
        }

        public bool VerifyChain(int? checklevel = null, int? numblocks = null)
        {
            throw new NotImplementedException();
        }

        public IList<string> VerifyTxtOutProof(string proof)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Control
        public GetInfoResult GetInfo()
        {
            return JsonConvert.DeserializeObject<GetInfoResult>(RunCommand("getinfo", new object[0]));
        }

        public string Help()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Disclosure
        public string ZGetPaymentDisclosure(string txid, int jsIndex, int outputIndex, string message = null)
        {
            throw new NotImplementedException();
        }

        public ZValidatePaymentDisclosureResult ZValidatePaymentDisclosure(string paymentDisclosure)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Generating
        #endregion
        #region Mining
        public GetBlockSubsidyResult GetBlockSubsidy(int? height)
        {
            throw new NotImplementedException();
        }

        public GetBlockTemplateResult GetBlockTemplate(GetBlockTemplateInput jsonRequestObject = null)
        {
            throw new NotImplementedException();
        }

        public int GetLocalSolps()
        {
            throw new NotImplementedException();
        }

        public GetMiningInfoResult GetMiningInfo()
        {
            throw new NotImplementedException();
        }

        public int GetNetworkHashPs(int? blocks = null, int? height = null)
        {
            throw new NotImplementedException();
        }

        public int GetNetworkSolPs(int? blocks = null, int? height = null)
        {
            throw new NotImplementedException();
        }

        public bool PrioritiseTransaction(string txid, double priorityDelta, int feeDelta)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Network
        public bool AddNode(string ipAddress, int port, AddNodeCommand command)
        {
            throw new NotImplementedException();
        }

        public bool ClearBanned()
        {
            throw new NotImplementedException();
        }

        public bool DisconnectNode(string ipAddress, int port)
        {
            throw new NotImplementedException();
        }

        public IList<AddedNodeResult> GetAddedNodeInfo(bool dns, string ipAddress = null, int? port = null)
        {
            throw new NotImplementedException();
        }

        public int GetConnectionCount()
        {
            throw new NotImplementedException();
        }

        public GetNetTotalsResult GetNetTotals()
        {
            throw new NotImplementedException();
        }

        public GetNetworkInfoResult GetNetworkInfo()
        {
            throw new NotImplementedException();
        }

        public IList<PeerInfoResult> GetPeerInfo()
        {
            throw new NotImplementedException();
        }

        public IList<BannedPeersResult> ListBanned()
        {
            throw new NotImplementedException();
        }

        public bool Ping()
        {
            throw new NotImplementedException();
        }

        public bool SetBan(string ipaddress, int? netmask, SetBanCommand AddRemove, int? bantimeSeconds, bool absolute)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Raw Transactions
        public string CreateRawTransaction(CreateRawTransactionInput arguments)
        {
            throw new NotImplementedException();
        }

        public DecodeRawTransactionResult DecodeRawTransaction(string hexstring)
        {
            throw new NotImplementedException();
        }

        public DecodeScriptResult DecodeScript(string hexstring)
        {
            throw new NotImplementedException();
        }

        public FundTransactionResult FundTransaction(string hexstring)
        {
            throw new NotImplementedException();
        }

        public GetRawTransactionVerboseResult GetRawTransaction(string txid, bool verbose = true)
        {
            return JsonConvert.DeserializeObject<GetRawTransactionVerboseResult>(RunCommand("getrawtransaction", new object[] { $"{txid}", 1 }));
        }

        public string GetRawTransactionNonVerbose(string txid, bool verbose = false)
        {
            throw new NotImplementedException();
        }

        public string SendRawTransaction(string hexstring, bool allowHighFees = false)
        {
            throw new NotImplementedException();
        }

        public SignRawTransactionResult SendRawTransaction(string hexstring, IList<SignRawTransactionInputPreviousTranscations> prevtxs = null, IList<string> privatekeys = null, SignRawTransactionInputSigHashType sighashtype = SignRawTransactionInputSigHashType.All, string branchid = null)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Util
        public CreateMultiSigResult CreateMultiSig(int nrequired, IList<string> keys)
        {
            throw new NotImplementedException();
        }

        public float EstimateFee(int nblocks)
        {
            throw new NotImplementedException();
        }

        public int EstimatePriority(int nblocks)
        {
            throw new NotImplementedException();
        }

        public ValidateAddressResult ValidateAddress(string address)
        {
            throw new NotImplementedException();
        }

        public bool VerifyMessage(string address, string signature, string message)
        {
            throw new NotImplementedException();
        }

        public ZValidateAddressResult zValidateAddress(string zaddress)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Wallet
        public PublicAddress AddMultiSigAddress(int nrequired, IList<string> keysobject)
        {
            throw new NotImplementedException();
        }

        public string BackupWallet(string filename)
        {
            throw new NotImplementedException();
        }

        public string DumpPrivKey(string t_addr)
        {
            throw new NotImplementedException();
        }

        public string DumpWallet(string filename)
        {
            throw new NotImplementedException();
        }

        public bool EncryptWallet(string passphrase)
        {
            throw new NotImplementedException();
        }

        public string GetAccount(string address)
        {
            throw new NotImplementedException();
        }

        public PublicAddress GetAccountAddress(string address = "")
        {
            throw new NotImplementedException();
        }

        public IList<string> GetAddressesByAccount(string address = "")
        {
            throw new NotImplementedException();
        }

        public float GetBalance(string account = "", int minconf = 1, bool includeWatchOnly = false)
        {
            throw new NotImplementedException();
        }

        public PublicAddress GetNewAddress(string account = "")
        {
            throw new NotImplementedException();
        }

        public PublicAddress GetRawChangeAddress()
        {
            throw new NotImplementedException();
        }

        public float GetReceivedByAccount(string account = "", int minconf = 1)
        {
            throw new NotImplementedException();
        }

        public float GetReceivedByAddress(string address, int minconf = 1)
        {
            throw new NotImplementedException();
        }

        public GetTransactionResult GetTransaction(string txid, bool includeWatchOnly = false)
        {
            throw new NotImplementedException();
        }

        public float GetUnconfirmedBalance()
        {
            throw new NotImplementedException();
        }

        public GetWalletInfoResult GetWalletInfo()
        {
            throw new NotImplementedException();
        }

        public bool ImportAddress(string address, string label = "", bool rescan = true)
        {
            throw new NotImplementedException();
        }

        public bool ImportPrivKey(string privkey, string label = "", bool rescan = true)
        {
            throw new NotImplementedException();
        }

        public bool ImportWallet(string filepath)
        {
            throw new NotImplementedException();
        }

        public bool KeyPoolRefill(int newsize)
        {
            throw new NotImplementedException();
        }

        public IList<ListAccountsResult> ListAccounts(int minconf = 1, bool includeWatchOnly = false)
        {
            throw new NotImplementedException();
        }

        public object[][][] ListAddressGroupings()
        {
            throw new NotImplementedException();
        }

        public IList<ListLockUnspentResult> ListLockUnspent()
        {
            throw new NotImplementedException();
        }

        public IList<ListReceivedByAccountResult> ListReceivedByAccount(int minconf = 1, bool includeEmpty = false, bool includeWatchOnly = false)
        {
            throw new NotImplementedException();
        }

        public IList<ListReceivedByAddressResult> ListReceivedByAddress(int minconf = 1, bool includeEmpty = false, bool includeWatchOnly = false)
        {
            throw new NotImplementedException();
        }

        public ListSinceBlockResult ListSinceBlock(string blockhash = null, int targetCOnfirmations = 1, bool includeWatchOnly = false)
        {
            throw new NotImplementedException();
        }

        public IList<ListTransactionsResult> ListTransactions(string account = "*", int count = 10, int from = 0, bool includeWatchOnly = false)
        {
            throw new NotImplementedException();
        }

        public IList<ListUnspentResult> ListUnspent(int minconf = 1, int maxconf = 9999999, IList<string> addresses = null)
        {
            throw new NotImplementedException();
        }

        public bool LockUnspent(bool unlock, IList<LockUnspentInputTransaction> transactions)
        {
            throw new NotImplementedException();
        }

        public bool Move(string fromAccount = "", string toAccount = "", float amount = float.NaN, int minconf = 1, string comment = null)
        {
            throw new NotImplementedException();
        }

        public TransactionId SendFrom(string fromAccount = "", string toAccount = "", float amount = float.NaN, int minconf = 1, string comment = null)
        {
            throw new NotImplementedException();
        }

        public TransactionId SendMany(PublicAddress address, IList<SendManyInput> outputs, int minconf = 1, string comment = null, IList<string> subtractfeefromamount = null)
        {
            throw new NotImplementedException();
        }

        
        #endregion
        #region ZCommands
        #endregion

    }
}
