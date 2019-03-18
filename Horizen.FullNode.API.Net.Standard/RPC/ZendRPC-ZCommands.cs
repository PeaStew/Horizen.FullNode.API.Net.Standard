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
        #region ZCommands

        #endregion

        public string ZExportKey(string address)
        {
            throw new NotImplementedException();
        }

        public string ZExportViewingKey(string address)
        {
            throw new NotImplementedException();
        }

        public string ZExportWallet(string address)
        {
            throw new NotImplementedException();
        }

        public decimal ZGetBalance(string address, int minconf = 1)
        {
            throw new NotImplementedException();
        }

        public string ZGetNewAddress()
        {
            throw new NotImplementedException();
        }

        public IList<ZOperationStatusOrResult> ZGetOperationResult(IEnumerable<string> opid)
        {
            throw new NotImplementedException();
        }

        public IList<ZOperationStatusOrResult> ZGetOperationStatus(IEnumerable<string> opid)
        {
            throw new NotImplementedException();
        }

        public ZGetTotalBalanceResult ZGetTotalBalance(int minconf = 1, bool includeWatchOnly = false)
        {
            throw new NotImplementedException();
        }

        public void ZImportKey(string zkey, ZImportKeyRescanType rescan, int startheight = 0)
        {
            throw new NotImplementedException();
        }

        public void ZImportViewingKey(string vkey, ZImportKeyRescanType rescan, int startheight = 0)
        {
            throw new NotImplementedException();
        }

        public void ZImportWallet(string filename)
        {
            throw new NotImplementedException();
        }

        public IList<string> ZListAddresses(bool includewatchonly)
        {
            throw new NotImplementedException();
        }

        public IList<string> ZListOperationIds(ZListOperationIdsStatusType status)
        {
            throw new NotImplementedException();
        }

        public IList<ZListReceivedByAddressResult> ZListReceivedByAddress(string address, int minconf = 1)
        {
            throw new NotImplementedException();
        }

        public string ZSendMany(string fromaddress, IList<ZSendManyAmountsInput> amounts, int minconf = 1, double fee = 0.0001)
        {
            throw new NotImplementedException();
        }

        public ZShieldCoinbase ZShieldCoinbase(string fromaddress, string toaddress, double fee = 0.0001, int limit = 50)
        {
            throw new NotImplementedException();
        }

        public IList<ZCBenchmarkResult> ZCBenchMark(ZCBenchmarkType benchmarktype, int samplecount = 1)
        {
            throw new NotImplementedException();
        }

        public ZCRawKeygen ZCRawKeygen()
        {
            throw new NotImplementedException();
        }

        public ZCRawReceive ZCRawReceive(string zcsecretkey, string encryptednote)
        {
            throw new NotImplementedException();
        }

        public string ZCSampleJoinsplit()
        {
            throw new NotImplementedException();
        }
    }
}
