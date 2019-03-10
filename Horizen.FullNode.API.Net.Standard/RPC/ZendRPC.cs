using System;
using System.Collections.Generic;
using System.Text;
using Horizen.FullNode.API.Net.Standard.RPC;
using Horizen.FullNode.API.Net.Standard.RPCInputTypes;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;
using Newtonsoft.Json;

namespace Horizen.FullNode.API.Net.Standard
{
    public partial class ZendRPC:IZendRPC
    {
        public T GetRPCTypedResult<T>(string method, object[] _params)
        {
            var result = new RPCConnection().RunCommand(method, _params);
            if (typeof(T) == typeof(string)
                || typeof(T) == typeof(int)
                || typeof(T) == typeof(long)
                || typeof(T) == typeof(float)
                || typeof(T) == typeof(double)
                || typeof(T) == typeof(bool))
            {
                return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(result.Replace("\"", "")));
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(result);
            }
        }

    }
}
