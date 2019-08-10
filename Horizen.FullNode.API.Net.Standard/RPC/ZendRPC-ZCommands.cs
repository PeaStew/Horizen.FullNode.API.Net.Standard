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

        public string ZExportKey(RPCConnection rpc, string address)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.ZExportKey.GetDescription(), new object[]{ $"{address}" });
        }

        public string ZExportViewingKey(RPCConnection rpc, string address)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.ZExportViewingKey.GetDescription(), new object[] { $"{address}" });
        }

        public string ZExportWallet(RPCConnection rpc, string address)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.ZExportWallet.GetDescription(), new object[] { $"{address}" });
        }

        public double ZGetBalance(RPCConnection rpc, string address, int minconf = 1)
        {
            return GetRPCTypedResult<double>(rpc, ZendRPCCommand.ZGetBalance.GetDescription(), new object[] { $"{address}", minconf });
        }

        public string ZGetNewAddress(RPCConnection rpc)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.ZGetNewAddress.GetDescription(), new object[0]);
        }

        public IList<ZOperationStatusOrResult> ZGetOperationResult(RPCConnection rpc, IEnumerable<string> opids)
        {
            return GetRPCTypedResult<List<ZOperationStatusOrResult>>(rpc, ZendRPCCommand.ZGetOperationResult.GetDescription(), new object[] { opids });
        }

        public IList<ZOperationStatusOrResult> ZGetOperationStatus(RPCConnection rpc, IEnumerable<string> opids)
        {
            return GetRPCTypedResult<List<ZOperationStatusOrResult>>(rpc, ZendRPCCommand.ZGetOperationStatus.GetDescription(), new object[] { opids });
        }

        public ZGetTotalBalanceResult ZGetTotalBalance(RPCConnection rpc, int minconf = 1, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<ZGetTotalBalanceResult>(rpc, ZendRPCCommand.ZGetBalance.GetDescription(), new object[] { minconf, includeWatchOnly });
        }

        public void ZImportKey(RPCConnection rpc, string zkey, ZImportKeyRescanType rescan, int startheight = 0)
        {
            GetRPCTypedResult<object>(rpc, ZendRPCCommand.ZImportKey.GetDescription(), new object[] { zkey, $"{rescan.GetDescription()}", startheight });
        }

        public void ZImportViewingKey(RPCConnection rpc, string vkey, ZImportKeyRescanType rescan, int startheight = 0)
        {
            GetRPCTypedResult<object>(rpc, ZendRPCCommand.ZImportViewingKey.GetDescription(), new object[] { vkey, $"{rescan.GetDescription()}", startheight });
        }

        public void ZImportWallet(RPCConnection rpc, string filename)
        {
            GetRPCTypedResult<object>(rpc, ZendRPCCommand.ZImportWallet.GetDescription(), new object[] { $"{filename}" });
        }

        public IList<string> ZListAddresses(RPCConnection rpc, bool includewatchonly)
        {
            return GetRPCTypedResult<List<string>>(rpc, ZendRPCCommand.ZListAddresses.GetDescription(), new object[] { includewatchonly });
        }

        public IList<string> ZListOperationIds(RPCConnection rpc, ZListOperationIdsStatusType status)
        {
            var description = status == ZListOperationIdsStatusType.All ? "" : status.GetDescription();
            return GetRPCTypedResult<List<string>>(rpc, ZendRPCCommand.ZListOperationIds.GetDescription(), new object[] { description });
        }

        public IList<ZListReceivedByAddressResult> ZListReceivedByAddress(RPCConnection rpc, string address, int minconf = 1)
        {
            return GetRPCTypedResult<List<ZListReceivedByAddressResult>>(rpc, ZendRPCCommand.ZListReceivedByAddress.GetDescription(), new object[] { $"{address}", minconf });
        }

        public string ZSendMany(RPCConnection rpc, string fromaddress, IList<ZSendManyAmountsInput> amounts, int minconf = 1, double fee = 0.0001)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.ZSendMany.GetDescription(), new object[] { $"{fromaddress}", amounts, minconf, fee });
        }

        public ZShieldCoinbase ZShieldCoinbase(RPCConnection rpc, string fromaddress, string toaddress, double fee = 0.0001, int limit = 50)
        {
            return GetRPCTypedResult<ZShieldCoinbase>(rpc, ZendRPCCommand.ZShieldCoinbase.GetDescription(), new object[] { $"{fromaddress}", $"{toaddress}", fee, limit });
        }

        public IList<ZCBenchmarkResult> ZCBenchMark(RPCConnection rpc, ZCBenchmarkType benchmarktype, int samplecount = 1)
        {
            return GetRPCTypedResult<List<ZCBenchmarkResult>>(rpc, ZendRPCCommand.ZCBenchmark.GetDescription(), new object[] { $"{benchmarktype.GetDescription()}", samplecount });
        }

        public ZCRawKeygen ZCRawKeygen(RPCConnection rpc)
        {
            return GetRPCTypedResult<ZCRawKeygen>(rpc, ZendRPCCommand.ZCRawKeyGen.GetDescription(), new object[0]);
        }

        public ZCRawReceive ZCRawReceive(RPCConnection rpc, string zcsecretkey, string encryptednote)
        {
            return GetRPCTypedResult<ZCRawReceive>(rpc, ZendRPCCommand.ZCRawReceive.GetDescription(), new object[] { $"{zcsecretkey}", $"{encryptednote}" });
        }

        public string ZCSampleJoinsplit(RPCConnection rpc)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.ZCSampleJoinSplit.GetDescription(), new object[0]);
        }
        #endregion

    }
}
