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
        public bool AddNode(string ipAddress, int port, AddNodeCommand command)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommand.AddNode.GetDescription(), new object[] { $"{ipAddress}", port, command});
        }

        public bool ClearBanned()
        {
            return GetRPCTypedResult<bool>(ZendRPCCommand.ClearBanned.GetDescription(), new object[0]);
        }

        public bool DisconnectNode(string ipAddress, int port)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommand.DisconnectNode.GetDescription(), new object[] { $"{ipAddress}", port });
        }

        public IList<AddedNodeResult> GetAddedNodeInfo(bool dns, string ipAddress = null, int? port = null)
        {
            return GetRPCTypedResult<List<AddedNodeResult>>(ZendRPCCommand.GetAddedNodeInfo.GetDescription(), new object[] { dns, $"{ipAddress}", port });
        }

        public int GetConnectionCount()
        {
            return GetRPCTypedResult<int>(ZendRPCCommand.GetConnectionCount.GetDescription(), new object[0]);
        }

        public GetNetTotalsResult GetNetTotals()
        {
            return GetRPCTypedResult<GetNetTotalsResult>(ZendRPCCommand.GetNetTotals.GetDescription(), new object[0]);
        }

        public GetNetworkInfoResult GetNetworkInfo()
        {
            return GetRPCTypedResult<GetNetworkInfoResult>(ZendRPCCommand.GetNetworkInfo.GetDescription(), new object[0]);
        }

        public IList<PeerInfoResult> GetPeerInfo()
        {
            return GetRPCTypedResult<List<PeerInfoResult>>(ZendRPCCommand.GetPeerInfo.GetDescription(), new object[0]);
        }

        public IList<BannedPeersResult> ListBanned()
        {
            return GetRPCTypedResult<List<BannedPeersResult>>(ZendRPCCommand.ListBanned.GetDescription(), new object[0]);
        }

        public bool Ping()
        {
            return GetRPCTypedResult<bool>(ZendRPCCommand.Ping.GetDescription(), new object[0]);
        }

        public bool SetBan(string ipaddress, int? netmask, SetBanCommand AddRemove, int? bantimeSeconds, bool absolute)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommand.SetBan.GetDescription(), new object[]{ipaddress,netmask,AddRemove,bantimeSeconds,absolute});
        }
        #endregion
    }
}
