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

        public string ZExportKey(string address)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.ZExportKey.GetDescription(), new object[]{ $"{address}" });
        }

        public string ZExportViewingKey(string address)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.ZExportViewingKey.GetDescription(), new object[] { $"{address}" });
        }

        public string ZExportWallet(string address)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.ZExportWallet.GetDescription(), new object[] { $"{address}" });
        }

        public double ZGetBalance(string address, int minconf = 1)
        {
            return GetRPCTypedResult<double>(ZendRPCCommand.ZGetBalance.GetDescription(), new object[] { $"{address}", minconf });
        }

        public string ZGetNewAddress()
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.ZGetNewAddress.GetDescription(), new object[0]);
        }

        public IList<ZOperationStatusOrResult> ZGetOperationResult(IEnumerable<string> opids)
        {
            return GetRPCTypedResult<List<ZOperationStatusOrResult>>(ZendRPCCommand.ZGetOperationResult.GetDescription(), new object[] { opids });
        }

        public IList<ZOperationStatusOrResult> ZGetOperationStatus(IEnumerable<string> opids)
        {
            return GetRPCTypedResult<List<ZOperationStatusOrResult>>(ZendRPCCommand.ZGetOperationStatus.GetDescription(), new object[] { opids });
        }

        public ZGetTotalBalanceResult ZGetTotalBalance(int minconf = 1, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<ZGetTotalBalanceResult>(ZendRPCCommand.ZGetBalance.GetDescription(), new object[] { minconf, includeWatchOnly });
        }

        public void ZImportKey(string zkey, ZImportKeyRescanType rescan, int startheight = 0)
        {
            new RPCConnection().RunCommand(ZendRPCCommand.ZImportKey.GetDescription(), new object[] { zkey, $"{rescan.GetDescription()}", startheight });
        }

        public void ZImportViewingKey(string vkey, ZImportKeyRescanType rescan, int startheight = 0)
        {
            new RPCConnection().RunCommand(ZendRPCCommand.ZImportViewingKey.GetDescription(), new object[] { vkey, $"{rescan.GetDescription()}", startheight });
        }

        public void ZImportWallet(string filename)
        {
            new RPCConnection().RunCommand(ZendRPCCommand.ZImportWallet.GetDescription(), new object[] { $"{filename}" });
        }

        public IList<string> ZListAddresses(bool includewatchonly)
        {
            return GetRPCTypedResult<List<string>>(ZendRPCCommand.ZListAddresses.GetDescription(), new object[] { includewatchonly });
        }

        public IList<string> ZListOperationIds(ZListOperationIdsStatusType status)
        {
            var description = status == ZListOperationIdsStatusType.All ? "" : status.GetDescription();
            return GetRPCTypedResult<List<string>>(ZendRPCCommand.ZListOperationIds.GetDescription(), new object[] { description });
        }

        public IList<ZListReceivedByAddressResult> ZListReceivedByAddress(string address, int minconf = 1)
        {
            return GetRPCTypedResult<List<ZListReceivedByAddressResult>>(ZendRPCCommand.ZListReceivedByAddress.GetDescription(), new object[] { $"{address}", minconf });
        }

        public string ZSendMany(string fromaddress, IList<ZSendManyAmountsInput> amounts, int minconf = 1, double fee = 0.0001)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.ZSendMany.GetDescription(), new object[] { $"{fromaddress}", amounts, minconf, fee });
        }

        public ZShieldCoinbase ZShieldCoinbase(string fromaddress, string toaddress, double fee = 0.0001, int limit = 50)
        {
            return GetRPCTypedResult<ZShieldCoinbase>(ZendRPCCommand.ZShieldCoinbase.GetDescription(), new object[] { $"{fromaddress}", $"{toaddress}", fee, limit });
        }

        public IList<ZCBenchmarkResult> ZCBenchMark(ZCBenchmarkType benchmarktype, int samplecount = 1)
        {
            return GetRPCTypedResult<List<ZCBenchmarkResult>>(ZendRPCCommand.ZCBenchmark.GetDescription(), new object[] { $"{benchmarktype.GetDescription()}", samplecount });
        }

        public ZCRawKeygen ZCRawKeygen()
        {
            return GetRPCTypedResult<ZCRawKeygen>(ZendRPCCommand.ZCRawKeyGen.GetDescription(), new object[0]);
        }

        public ZCRawReceive ZCRawReceive(string zcsecretkey, string encryptednote)
        {
            return GetRPCTypedResult<ZCRawReceive>(ZendRPCCommand.ZCRawReceive.GetDescription(), new object[] { $"{zcsecretkey}", $"{encryptednote}" });
        }

        public string ZCSampleJoinsplit()
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.ZCSampleJoinSplit.GetDescription(), new object[0]);
        }
        #endregion

    }
}
