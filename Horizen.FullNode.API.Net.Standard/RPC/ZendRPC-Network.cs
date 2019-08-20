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
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.AddNode.GetDescription(), new object[] { $"{ipAddress}", port, command});
        }

        public bool ClearBanned(RPCConnection rpc)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.ClearBanned.GetDescription(), new object[0]);
        }

        public bool DisconnectNode(RPCConnection rpc, string ipAddress, int port)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.DisconnectNode.GetDescription(), new object[] { $"{ipAddress}", port });
        }

        public IList<AddedNodeResult> GetAddedNodeInfo(RPCConnection rpc, bool dns, string ipAddress = null, int? port = null)
        {
            return GetRPCTypedResult<List<AddedNodeResult>>(rpc, ZendRPCCommand.GetAddedNodeInfo.GetDescription(), new object[] { dns, $"{ipAddress}", port });
        }

        public int GetConnectionCount(RPCConnection rpc)
        {
            return GetRPCTypedResult<int>(rpc, ZendRPCCommand.GetConnectionCount.GetDescription(), new object[0]);
        }

        public GetNetTotalsResult GetNetTotals(RPCConnection rpc)
        {
            return GetRPCTypedResult<GetNetTotalsResult>(rpc, ZendRPCCommand.GetNetTotals.GetDescription(), new object[0]);
        }

        public GetNetworkInfoResult GetNetworkInfo(RPCConnection rpc)
        {
            return GetRPCTypedResult<GetNetworkInfoResult>(rpc, ZendRPCCommand.GetNetworkInfo.GetDescription(), new object[0]);
        }

        public IList<PeerInfoResult> GetPeerInfo(RPCConnection rpc)
        {
            return GetRPCTypedResult<List<PeerInfoResult>>(rpc, ZendRPCCommand.GetPeerInfo.GetDescription(), new object[0]);
        }

        public IList<BannedPeersResult> ListBanned(RPCConnection rpc)
        {
            return GetRPCTypedResult<List<BannedPeersResult>>(rpc, ZendRPCCommand.ListBanned.GetDescription(), new object[0]);
        }

        public bool Ping(RPCConnection rpc)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.Ping.GetDescription(), new object[0]);
        }

        public bool SetBan(RPCConnection rpc, string ipaddress, int? netmask, SetBanCommand AddRemove, int? bantimeSeconds, bool absolute)
        {
            return GetRPCTypedResult<bool>(rpc, ZendRPCCommand.SetBan.GetDescription(), new object[]{ipaddress,netmask,AddRemove,bantimeSeconds,absolute});
        }
        #endregion
    }
}
