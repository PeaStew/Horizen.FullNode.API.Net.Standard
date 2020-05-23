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
            return GetRPCTypedResult<GetInfoResult>(rpc, ZendRPCCommand.GetInfo, new object[0]);
        }

        public string Help(RPCConnection rpc,string command)
        {
            return GetRPCTypedResult<string>(rpc, ZendRPCCommand.Help, new object[]{$"{command}"});
        }

        public void Stop(RPCConnection rpc)
        {
            GetRPCTypedResult<string>(rpc, ZendRPCCommand.Stop, new object[0]);
        }
        #endregion

    }
}
