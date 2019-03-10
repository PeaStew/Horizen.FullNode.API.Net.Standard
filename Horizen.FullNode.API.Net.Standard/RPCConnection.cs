using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;
using StreamJsonRpc;
using StreamJsonRpc.Protocol;

namespace Horizen.FullNode.API.Net.Standard
{
    public class RPCConnection
    {
        public string RPCIpAddress { get; set; } = "localhost";
        public int RPCPort { get; set; } = 18231;
        public string RPCUser { get; set; } = "asdfk87aios";
        public string RPCPassword { get; set; } = "asdfsdfasgffdgfdsi787690879siuhdfjh";
        public bool RPCActive { get; private set; } = false;

        public string RunCommand(string commandName, object[] _params)
        {
            //TODO: Check for error
            var result = this.GetRPCResult(new RPCData(Guid.NewGuid().ToString(), commandName, _params));
            Console.WriteLine(JsonConvert.SerializeObject(result.error));
            return JsonConvert.SerializeObject(result.result);
        }

        private WebClientResponse GetRPCResult(RPCData rpcData)
        {
            using (var wc = new WebClient())
            {
                ServicePointManager.DefaultConnectionLimit = 500;
                RPCActive = true;
                wc.Headers[HttpRequestHeader.ContentType] = "text/plain";
                wc.Credentials = new NetworkCredential { UserName = RPCUser, Password = RPCPassword };
                var jsonText = rpcData.GetJsonString();
                var response = wc.UploadString($"http://{RPCIpAddress}:{RPCPort}", jsonText);
                RPCActive = false;
                return JsonConvert.DeserializeObject<WebClientResponse>(response);
                
            }

        }
    }


    public class RPCData
    {
        public RPCData(string id, string method, object[] parameters)
        {
            this.id = id;
            this.method = method;
            this._params = parameters;
        }

        public string jsonrpc { get; set; } = "1.0";
        public string id { get; set; }
        public string method { get; set; }
        [JsonProperty("params")]
        public object[] _params { get; set; }

        public string GetJsonString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }


    public class WebClientResponse
    {
        public object result { get; set; }
        public object error { get; set; }
        public string id { get; set; }
    }


}
