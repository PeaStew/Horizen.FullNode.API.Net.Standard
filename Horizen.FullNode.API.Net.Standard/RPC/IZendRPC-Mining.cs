using System;
using System.Collections.Generic;
using System.Text;
using Horizen.FullNode.API.Net.Standard.RPCInputTypes;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;


namespace Horizen.FullNode.API.Net.Standard.RPC
{
    public partial interface IZendRPCMining
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

        GetBlockSubsidyResult GetBlockSubsidy(RPCConnection rpc, int? height);
        GetBlockTemplateResult GetBlockTemplate(RPCConnection rpc, GetBlockTemplateInput jsonRequestObject = null);
        int GetLocalSolps(RPCConnection rpc);
        GetMiningInfoResult GetMiningInfo(RPCConnection rpc);
        int GetNetworkHashPs(RPCConnection rpc,int blocks = 120, int height = -1);
        int GetNetworkSolPs(RPCConnection rpc, int blocks = 120, int height = -1);
        bool PrioritiseTransaction(RPCConnection rpc, string txid, double priorityDelta, int feeDelta);
        string submitblock(RPCConnection rpc, string hexdata, SubmitBlockInput jsonparametersobject);
    }
}
