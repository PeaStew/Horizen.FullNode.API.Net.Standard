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
        public GetInfoResult GetInfo()
        {
            return GetRPCTypedResult<GetInfoResult>(ZendRPCCommand.GetInfo.GetDescription(), new object[0]);
        }

        public string Help(string command)
        {
            return GetRPCTypedResult<string>(ZendRPCCommand.Help.GetDescription(), new object[]{$"{command}"});
        }

        public void Stop()
        {
            GetRPCTypedResult<string>(ZendRPCCommand.Stop.GetDescription(), new object[0]);
        }
        #endregion

    }
}
