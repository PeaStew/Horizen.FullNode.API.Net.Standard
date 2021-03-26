using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using Horizen.FullNode.API.Net.Standard.RPC;
using Newtonsoft.Json;
using StreamJsonRpc;
using StreamJsonRpc.Protocol;
using static Horizen.FullNode.API.Net.Standard.ZendRPC;

namespace Horizen.FullNode.API.Net.Standard
{
    public class RPCConnection
    {
        public string ConnectionName { get; set; }
        public string RPCIpAddress { get; set; } = "localhost";
        public int RPCPort { get; set; }
        public string RPCUser { get; set; }
        public string RPCPassword { get; set; }
        public bool RPCActive { get; private set; } = false;
        public int RPCConnectionLimit { get; set; } = 4000;

        // for use with the enum, which may not cover 100% of available commands when a new release is made available.
        public string RunCommand(ZendRPCCommand commandName, object[] _params, string identifier = null)
        {
            return RunCommand(new RPCData(identifier, Utils.GetDescription(commandName), _params));
        }
        // command string for use when the command is not supported by the enum
        public string RunCommand(string commandName, object[] _params, string identifier = null)
        {
            return RunCommand(new RPCData(identifier, commandName, _params));
        }

        //https://www.jsonrpc.org/specification


        public string RunCommand(RPCData rpcData)
        {
            var result = this.GetRPCResult(rpcData);
            return result.error != null ? null : JsonConvert.SerializeObject(result.result);
        }

        public string RunCommand(List<RPCData> rpcData)
        {
            var result = this.GetRPCResult(rpcData);
            return JsonConvert.SerializeObject(result.Where(a=>a.error == null).Select(a=>a.result));
        }

        private WebClientResponse GetRPCResult(RPCData data)
        {
            return JsonConvert.DeserializeObject<WebClientResponse>(GetRPCResult(JsonConvert.SerializeObject(data)));

        }

        private List<WebClientResponse> GetRPCResult(List<RPCData> data)
        {
            return JsonConvert.DeserializeObject<List<WebClientResponse>>(GetRPCResult(JsonConvert.SerializeObject(data)));

        }

        private string GetRPCResult(string jsonText)
        {
            using (var wc = new WebClient())
            {
                ServicePointManager.DefaultConnectionLimit = RPCConnectionLimit;
                RPCActive = true;
                wc.Headers[HttpRequestHeader.ContentType] = "text/plain";
                wc.Credentials = new NetworkCredential { UserName = RPCUser, Password = RPCPassword };
                var response = wc.UploadString($"http://{RPCIpAddress}:{RPCPort}", jsonText);
                RPCActive = false;
                wc.Dispose();
                return response;
                
            }

        }
    }




    public class RPCData
    {
        public RPCData(string id, string method, object[] parameters)
        {
            this.id = string.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id;
            this.method = method;
            this._params = parameters;
        }

        public RPCData(string id, ZendRPCCommand commandName, object[] parameters)
        {
            this.id = string.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id;
            this.method = commandName.GetDescription();
            this._params = parameters;
        }

        public string jsonrpc { get; set; } = "2.0";
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
