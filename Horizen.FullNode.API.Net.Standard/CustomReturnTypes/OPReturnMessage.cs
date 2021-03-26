using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;
using Newtonsoft.Json;

namespace Horizen.FullNode.API.Net.Standard.CustomReturnTypes
{
    public class OPReturnMessage
    {
        public OPReturnMessage()
        { }
        public OPReturnMessage(GetBlockResult bd, GetRawTransactionVerboseResult tx, string asm)
        {
            blockdata = bd;
            transaction = tx;
            message = ProcessMessage(asm);
        }
        [JsonIgnore]
        public GetBlockResult blockdata { get; set; }
        public GetRawTransactionVerboseResult transaction { get; set; }
        public string message { get; set; }

        public static string FromHex(string hex)
        {
            var result = new byte[hex.Length / 2];
            for (var i = 0; i < result.Length; i++)
            {
                result[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return Encoding.UTF8.GetString(result, 0, result.Length);
        }

        private string ProcessMessage(string asm)
        {
            var messageParts = asm.Split(' ').ToList();
            return FromHex(messageParts[1]);
        }

    }
}
