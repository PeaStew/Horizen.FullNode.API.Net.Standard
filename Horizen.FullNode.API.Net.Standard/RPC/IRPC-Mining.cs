using System;
using System.Collections.Generic;
using System.Text;
using Horizen.FullNode.API.Net.Standard.RPCInputTypes;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;


namespace Horizen.FullNode.API.Net.Standard.RPC
{
    public partial interface IRPC
    {
        /* == Mining ==
        getblocksubsidy height
        getblocktemplate ( "jsonrequestobject" )
        getlocalsolps
        getmininginfo
        getnetworkhashps ( blocks height )
        getnetworksolps ( blocks height )
        prioritisetransaction <txid> <priority delta> <fee delta>
        submitblock "hexdata" ( "jsonparametersobject" )
        */

        GetBlockSubsidyResult GetBlockSubsidy(int? height);
        GetBlockTemplateResult GetBlockTemplate(GetBlockTemplateInput jsonRequestObject = null);
        int GetLocalSolps();
        GetMiningInfoResult GetMiningInfo();
        int GetNetworkHashPs(int? blocks = null, int? height = null);
        int GetNetworkSolPs(int? blocks = null, int? height = null);
        bool PrioritiseTransaction(string txid, double priorityDelta, int feeDelta);
    }
}
