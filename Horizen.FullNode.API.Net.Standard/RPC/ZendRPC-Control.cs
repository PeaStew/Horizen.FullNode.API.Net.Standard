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

        #region Control
        public GetInfoResult GetInfo(RPCConnection rpc)
        {
            return GetRPCTypedResult<GetInfoResult>(rpc, ZendRPCCommand.GetInfo.GetDescription(), new object[0]);
        }

        public string Help(RPCConnection rpc,string command)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.Help.GetDescription(), new object[]{$"{command}"});
        }

        public void Stop(RPCConnection rpc)
        {
            GetRPCTypedResult<string>(rpc, ZendRPCCommand.Stop.GetDescription(), new object[0]);
        }
        #endregion

    }
}
