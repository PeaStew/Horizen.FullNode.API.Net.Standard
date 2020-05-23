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

        #region Network
        public bool AddNode(RPCConnection rpc, string ipAddress, int port, AddNodeCommand command)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.AddNode, new object[] { $"{ipAddress}", port, command});
        }

        public bool ClearBanned(RPCConnection rpc)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.ClearBanned, new object[0]);
        }

        public bool DisconnectNode(RPCConnection rpc, string ipAddress, int port)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.DisconnectNode, new object[] { $"{ipAddress}", port });
        }

        public IList<AddedNodeResult> GetAddedNodeInfo(RPCConnection rpc, bool dns, string ipAddress = null, int? port = null)
        {
            return GetRPCTypedResult<List<AddedNodeResult>>(rpc, ZendRPCCommand.GetAddedNodeInfo, new object[] { dns, $"{ipAddress}", port });
        }

        public int GetConnectionCount(RPCConnection rpc)
        {
            return GetRPCTypedResult<int>(rpc, ZendRPCCommand.GetConnectionCount, new object[0]);
        }

        public GetNetTotalsResult GetNetTotals(RPCConnection rpc)
        {
            return GetRPCTypedResult<GetNetTotalsResult>(rpc, ZendRPCCommand.GetNetTotals, new object[0]);
        }

        public GetNetworkInfoResult GetNetworkInfo(RPCConnection rpc)
        {
            return GetRPCTypedResult<GetNetworkInfoResult>(rpc, ZendRPCCommand.GetNetworkInfo, new object[0]);
        }

        public IList<PeerInfoResult> GetPeerInfo(RPCConnection rpc)
        {
            return GetRPCTypedResult<List<PeerInfoResult>>(rpc, ZendRPCCommand.GetPeerInfo, new object[0]);
        }

        public IList<BannedPeersResult> ListBanned(RPCConnection rpc)
        {
            return GetRPCTypedResult<List<BannedPeersResult>>(rpc, ZendRPCCommand.ListBanned, new object[0]);
        }

        public bool Ping(RPCConnection rpc)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.Ping, new object[0]);
        }

        public bool SetBan(RPCConnection rpc, string ipaddress, int? netmask, SetBanCommand AddRemove, int? bantimeSeconds, bool absolute)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.SetBan, new object[]{ipaddress,netmask,AddRemove,bantimeSeconds,absolute});
        }
        #endregion
    }
}
