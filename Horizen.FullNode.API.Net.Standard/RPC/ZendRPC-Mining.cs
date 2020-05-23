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

        #region Mining
        public GetBlockSubsidyResult GetBlockSubsidy(RPCConnection rpc, int? height)
        {
            return GetRPCTypedResult<GetBlockSubsidyResult>(rpc, ZendRPCCommand.GetBlockSubsidy, height == null ? new object[0] :new object[] { height });
        }

        public GetBlockTemplateResult GetBlockTemplate(RPCConnection rpc, GetBlockTemplateInput jsonRequestObject = null)
        {
            return GetRPCTypedResult<GetBlockTemplateResult>(rpc, ZendRPCCommand.GetBlockTemplate,
                jsonRequestObject == null ? new object[0] : new object[] {jsonRequestObject});
            //TODO: Check format (below), currently seems to return only 'proposal' as capability regardless of which way the message is sent
            //{
            //    new Dictionary<string,GetBlockTemplateInput>{{"jsonrequestobject",jsonRequestObject }}
            //});
        }

        public int GetLocalSolps(RPCConnection rpc)
        {
            return GetRPCTypedResult<int>(rpc, ZendRPCCommand.GetLocalSolPs, new object[0]);
        }

        public GetMiningInfoResult GetMiningInfo(RPCConnection rpc)
        {
            return GetRPCTypedResult<GetMiningInfoResult>(rpc, ZendRPCCommand.GetMiningInfo, new object[0]);
        }

        public int GetNetworkHashPs(RPCConnection rpc, int blocks = 120, int height = -1)
        {
            return GetNetworkSolPs(rpc, blocks, height);
        }

        public int GetNetworkSolPs(RPCConnection rpc, int blocks = 120, int height = -1)
        {
            return GetRPCTypedResult<int>(rpc, ZendRPCCommand.GetNetworkSolPs, new object[]{blocks,height});
        }

        public bool PrioritiseTransaction(RPCConnection rpc, string txid, double priorityDelta, int feeDelta)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.PrioritiseTransaction, new object[] { $"{txid}", priorityDelta, feeDelta });
        }

        public string submitblock(RPCConnection rpc, string hexdata, SubmitBlockInput jsonparametersobject)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.SubmitBlock, new object[] { $"{hexdata}", jsonparametersobject });
        }
        #endregion
    }
}
