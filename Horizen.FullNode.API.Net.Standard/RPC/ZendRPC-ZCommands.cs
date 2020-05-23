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
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.ZExportKey, new object[]{ $"{address}" });
        }

        public string ZExportViewingKey(RPCConnection rpc, string address)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.ZExportViewingKey, new object[] { $"{address}" });
        }

        public string ZExportWallet(RPCConnection rpc, string address)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.ZExportWallet, new object[] { $"{address}" });
        }

        public double ZGetBalance(RPCConnection rpc, string address, int minconf = 1)
        {
            return GetRPCTypedResult<double>(rpc, ZendRPCCommand.ZGetBalance, new object[] { $"{address}", minconf });
        }

        public string ZGetNewAddress(RPCConnection rpc)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.ZGetNewAddress, new object[0]);
        }

        public IList<ZOperationStatusOrResult> ZGetOperationResult(RPCConnection rpc, IEnumerable<string> opids)
        {
            return GetRPCTypedResult<List<ZOperationStatusOrResult>>(rpc, ZendRPCCommand.ZGetOperationResult, new object[] { opids });
        }

        public IList<ZOperationStatusOrResult> ZGetOperationStatus(RPCConnection rpc, IEnumerable<string> opids)
        {
            return GetRPCTypedResult<List<ZOperationStatusOrResult>>(rpc, ZendRPCCommand.ZGetOperationStatus, new object[] { opids });
        }

        public ZGetTotalBalanceResult ZGetTotalBalance(RPCConnection rpc, int minconf = 1, bool includeWatchOnly = false)
        {
            return GetRPCTypedResult<ZGetTotalBalanceResult>(rpc, ZendRPCCommand.ZGetBalance, new object[] { minconf, includeWatchOnly });
        }

        public void ZImportKey(RPCConnection rpc, string zkey, ZImportKeyRescanType rescan, int startheight = 0)
        {
            GetRPCTypedResult<object>(rpc, ZendRPCCommand.ZImportKey, new object[] { zkey, $"{rescan}", startheight });
        }

        public void ZImportViewingKey(RPCConnection rpc, string vkey, ZImportKeyRescanType rescan, int startheight = 0)
        {
            GetRPCTypedResult<object>(rpc, ZendRPCCommand.ZImportViewingKey, new object[] { vkey, $"{rescan}", startheight });
        }

        public void ZImportWallet(RPCConnection rpc, string filename)
        {
            GetRPCTypedResult<object>(rpc, ZendRPCCommand.ZImportWallet, new object[] { $"{filename}" });
        }

        public IList<string> ZListAddresses(RPCConnection rpc, bool includewatchonly)
        {
            return GetRPCTypedResult<List<string>>(rpc, ZendRPCCommand.ZListAddresses, new object[] { includewatchonly });
        }

        public IList<string> ZListOperationIds(RPCConnection rpc, ZListOperationIdsStatusType status)
        {
            var description = status == ZListOperationIdsStatusType.All ? "" : status.GetDescription();
            return GetRPCTypedResult<List<string>>(rpc, ZendRPCCommand.ZListOperationIds, new object[] { description });
        }

        public IList<ZListReceivedByAddressResult> ZListReceivedByAddress(RPCConnection rpc, string address, int minconf = 1)
        {
            return GetRPCTypedResult<List<ZListReceivedByAddressResult>>(rpc, ZendRPCCommand.ZListReceivedByAddress, new object[] { $"{address}", minconf });
        }

        public string ZSendMany(RPCConnection rpc, string fromaddress, IList<ZSendManyAmountsInput> amounts, int minconf = 1, double fee = 0.0001)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.ZSendMany, new object[] { $"{fromaddress}", amounts, minconf, fee });
        }

        public ZShieldCoinbase ZShieldCoinbase(RPCConnection rpc, string fromaddress, string toaddress, double fee = 0.0001, int limit = 50)
        {
            return GetRPCTypedResult<ZShieldCoinbase>(rpc, ZendRPCCommand.ZShieldCoinbase, new object[] { $"{fromaddress}", $"{toaddress}", fee, limit });
        }

        public IList<ZCBenchmarkResult> ZCBenchMark(RPCConnection rpc, ZCBenchmarkType benchmarktype, int samplecount = 1)
        {
            return GetRPCTypedResult<List<ZCBenchmarkResult>>(rpc, ZendRPCCommand.ZCBenchmark, new object[] { $"{benchmarktype}", samplecount });
        }

        public ZCRawKeygen ZCRawKeygen(RPCConnection rpc)
        {
            return GetRPCTypedResult<ZCRawKeygen>(rpc, ZendRPCCommand.ZCRawKeyGen, new object[0]);
        }

        public ZCRawReceive ZCRawReceive(RPCConnection rpc, string zcsecretkey, string encryptednote)
        {
            return GetRPCTypedResult<ZCRawReceive>(rpc, ZendRPCCommand.ZCRawReceive, new object[] { $"{zcsecretkey}", $"{encryptednote}" });
        }

        public string ZCSampleJoinsplit(RPCConnection rpc)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.ZCSampleJoinSplit, new object[0]);
        }
        #endregion

    }
}
