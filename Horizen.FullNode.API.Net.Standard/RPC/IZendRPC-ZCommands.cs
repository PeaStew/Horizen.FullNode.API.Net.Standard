using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Horizen.FullNode.API.Net.Standard.RPCInputTypes;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;

namespace Horizen.FullNode.API.Net.Standard.RPC
{
    public partial interface IZendRPCZCommands
    {
        //        #region zCommands
        //        /* z_exportkey "zaddr"
        //        z_exportviewingkey "zaddr"
        //        z_exportwallet "filename"
        //        z_getbalance "address" ( minconf )
        //        z_getnewaddress
        //        z_getoperationresult (["operationid", ... ])
        //        z_getoperationstatus (["operationid", ... ])
        //        z_gettotalbalance ( minconf includeWatchonly )
        //        z_importkey "zkey" ( rescan startHeight )
        //        z_importviewingkey "vkey" ( rescan startHeight )
        //        z_importwallet "filename"
        //        z_listaddresses ( includeWatchonly )
        //        z_listoperationids
        //        z_listreceivedbyaddress "address" ( minconf )
        //        z_sendmany "fromaddress" [{"address":... ,"amount":...},...] ( minconf ) ( fee )
        //        z_shieldcoinbase "fromaddress" "tozaddress" ( fee ) ( limit )
        //        zcbenchmark benchmarktype samplecount
        //        zcrawjoinsplit rawtx inputs outputs vpub_old vpub_new
        //        zcrawkeygen
        //        zcrawreceive zcsecretkey encryptednote
        //        zcsamplejoinsplit
        //        */
        //        #endregion
        //        #endregion
        string ZExportKey(string address);
        string ZExportViewingKey(string address);
        string ZExportWallet(string address);
        decimal ZGetBalance(string address, int minconf = 1);
        //TODO: Upgrade when Sapling addresses available
        //string ZGetNewAddress(string type = "sapling");
        string ZGetNewAddress();
        IList<ZOperationStatusOrResult> ZGetOperationResult(IEnumerable<string> opid);
        IList<ZOperationStatusOrResult> ZGetOperationStatus(IEnumerable<string> opid);
        ZGetTotalBalanceResult ZGetTotalBalance(int minconf = 1, bool includeWatchOnly = false);
        void ZImportKey(string zkey, ZImportKeyRescanType rescan, int startheight = 0);
        void ZImportViewingKey(string vkey, ZImportKeyRescanType rescan, int startheight = 0);
        void ZImportWallet(string filename);
        IList<string> ZListAddresses(bool includewatchonly);
        IList<string> ZListOperationIds(ZListOperationIdsStatusType status);
        IList<ZListReceivedByAddressResult> ZListReceivedByAddress(string address, int minconf = 1);
        //ZListUnspent TODO: when available
        //ZMergeToAddress TODO: when available
        string ZSendMany(string fromaddress, IList<ZSendManyAmountsInput> amounts, int minconf = 1, double fee = 0.0001);
        ZShieldCoinbase ZShieldCoinbase(string fromaddress, string toaddress, double fee = 0.0001, int limit = 50);
        IList<ZCBenchmarkResult> ZCBenchMark(ZCBenchmarkType benchmarktype, int samplecount = 1);
        //TODO:zcrawjoinsplit
        ZCRawKeygen ZCRawKeygen();
        ZCRawReceive ZCRawReceive(string zcsecretkey, string encryptednote);
        string ZCSampleJoinsplit(); //returns JSDescription
    }
}
