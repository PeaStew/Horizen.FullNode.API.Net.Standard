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
        public GetBlockSubsidyResult GetBlockSubsidy(int? height)
        {
            return GetRPCTypedResult<GetBlockSubsidyResult>(ZendRPCCommand.GetBlockSubsidy.GetDescription(), height == null ? new object[0] :new object[] { height });
        }

        public GetBlockTemplateResult GetBlockTemplate(GetBlockTemplateInput jsonRequestObject = null)
        {
            return GetRPCTypedResult<GetBlockTemplateResult>(ZendRPCCommand.GetBlockTemplate.GetDescription(),
                jsonRequestObject == null ? new object[0] : new object[] {jsonRequestObject});
            //TODO: Check format (below), currently seems to return only 'proposal' as capability regardless of which way the message is sent
            //{
            //    new Dictionary<string,GetBlockTemplateInput>{{"jsonrequestobject",jsonRequestObject }}
            //});
        }

        public int GetLocalSolps()
        {
            return GetRPCTypedResult<int>(ZendRPCCommand.GetLocalSolPs.GetDescription(), new object[0]);
        }

        public GetMiningInfoResult GetMiningInfo()
        {
            return GetRPCTypedResult<GetMiningInfoResult>(ZendRPCCommand.GetMiningInfo.GetDescription(), new object[0]);
        }

        public int GetNetworkHashPs(int blocks = 120, int height = -1)
        {
            return GetNetworkSolPs(blocks, height);
        }

        public int GetNetworkSolPs(int blocks = 120, int height = -1)
        {
            return GetRPCTypedResult<int>(ZendRPCCommand.GetNetworkSolPs.GetDescription(), new object[]{blocks,height});
        }

        public bool PrioritiseTransaction(string txid, double priorityDelta, int feeDelta)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommand.PrioritiseTransaction.GetDescription(), new object[] { $"{txid}", priorityDelta, feeDelta });
        }

        public string submitblock(string hexdata, SubmitBlockInput jsonparametersobject)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.SubmitBlock.GetDescription(), new object[] { $"{hexdata}", jsonparametersobject });
        }
        #endregion
    }
}
