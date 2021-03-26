using Horizen.FullNode.API.Net.Standard;
using Horizen.FullNode.API.Net.Standard.CustomReturnTypes;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Horizen.FullNode.API.Net.Standard.CustomReturnTypes
{
    public class MessageSearcher
    {
        public int blockHeight;

        public List<OPReturnMessage> messages = new List<OPReturnMessage>();

        public async Task SearchForMessagesAsync(RPCConnection rpcConnection, GetBlockResult bd)
        {
            this.blockHeight = bd.height;
            var transactions = Task.Run(()=> GetTransactions(rpcConnection, bd.tx.ToList()));

            foreach (var tx in await transactions)
            {
                var res = ProcessTx(bd, tx);
                if(res == null || !res.Any()) continue;
                messages.AddRange(res);
            }
        }

        public async Task SearchForMessagesAsync(RPCConnection rpcConnection, int blockHeight)
        {
            this.blockHeight = blockHeight;
            var bd = GetBlock(rpcConnection, blockHeight);

            await SearchForMessagesAsync(rpcConnection, bd);
        }

        private List<OPReturnMessage> ProcessTx(GetBlockResult bd, GetRawTransactionVerboseResult transaction)
        {
            var foundMessages = new List<OPReturnMessage>();
            if (transaction == null) return null;

            if (!transaction.vin.Any() || transaction.vout == null) return null;

            var vouts = transaction.vout.Where(a => a.scriptPubKey != null && a.scriptPubKey.asm.Contains("OP_RETURN")).ToList();
            if (!vouts.Any()) return null;

            foreach (var vout in vouts)
            {
                var message = new OPReturnMessage(bd, transaction, vout.scriptPubKey.asm);
                foundMessages.Add(message);
                Console.WriteLine($"{bd.height} - {transaction.txid} - {vout.n} - {message.message}");
            }
            return foundMessages.Any() ? foundMessages :  null;
        }

        public GetInfoResult GetInfo(RPCConnection rpcConnection)
        {
            var zend = new ZendRPC();
            var res = zend.GetInfo(rpcConnection);
            return res;
        }

        public GetBlockResult GetBlock(RPCConnection rpcConnection, int blockHeight)
        {
            var zend = new ZendRPC();
            var res = zend.GetBlock(rpcConnection, blockHeight, 1);
            return res;
        }

        public GetRawTransactionVerboseResult GetTransaction(RPCConnection rpcConnection, string transactionId)
        {
            var zend = new ZendRPC();
            var res = zend.GetRawTransaction(rpcConnection, transactionId);
            return res;
        }

        public List<GetRawTransactionVerboseResult> GetTransactions(RPCConnection rpcConnection, List<string> txids)
        {
            var zend = new ZendRPC();
            var res = zend.GetRawTransactions(rpcConnection, txids);
            return res;
        }


    }

            
        }
