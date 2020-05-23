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
        #region Raw Transactions

        public List<GetRawTransactionVerboseResult> GetRawTransactions(RPCConnection rpc, List<string> txids, bool verbose = true)
        {
            var data = new List<RPCData>();
            foreach (var txid in txids)
            {
                data.Add(new RPCData(txid, ZendRPCCommand.GetRawTransaction,  new object[] { $"{txid}", 1 }));
            }
            return GetRPCTypedResult<List<GetRawTransactionVerboseResult>>(rpc, data);
        }

        #endregion
    }
}
