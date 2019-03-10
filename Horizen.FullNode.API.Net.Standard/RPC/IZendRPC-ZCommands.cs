using System;
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
        //        double z_getbalance(string addr);
        //        List<ZOperationStatusOrResult> z_getoperationresult(IEnumerable<string> opid);
        //        List<ZOperationStatusOrResult> z_getoperationstatus(IEnumerable<string> opid);
        //        List<string> z_listaddresses();
        //        List<string> z_listoperationids();
        //        string z_sendmany(string zaddr, double amts, double amt, double fee);
    }
}
