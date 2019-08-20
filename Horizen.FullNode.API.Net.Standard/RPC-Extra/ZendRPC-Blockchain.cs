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
        #region Blockchain

        public List<GetBlockResult> GetBlocks(RPCConnection rpc, List<int> heights, int verbosity)
        {
            var data = new List<RPCData>();
            heights.ForEach(a=>data.Add(new RPCData(a.ToString(), ZendRPCCommand.GetBlock.GetDescription(), new object[] { $"{a}", true })));
            return GetRPCTypedResult<List<GetBlockResult>>(rpc, data);
        }
        #endregion

    }
}
