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
            return GetRPCTypedResult<bool>(ZendRPCCommands[ZendRPCCommand.AddNode], new object[] { $"{ipAddress}", port, command});
        }

        public bool ClearBanned()
        {
            return GetRPCTypedResult<bool>(ZendRPCCommands[ZendRPCCommand.ClearBanned], new object[0]);
        }

        public bool DisconnectNode(string ipAddress, int port)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommands[ZendRPCCommand.DisconnectNode], new object[] { $"{ipAddress}", port });
        }

        public IList<AddedNodeResult> GetAddedNodeInfo(bool dns, string ipAddress = null, int? port = null)
        {
            return GetRPCTypedResult<List<AddedNodeResult>>(ZendRPCCommands[ZendRPCCommand.AddNode], new object[] { dns, $"{ipAddress}", port });
        }

        public int GetConnectionCount()
        {
            return GetRPCTypedResult<int>(ZendRPCCommands[ZendRPCCommand.GetConnectionCount], new object[0]);
        }

        public GetNetTotalsResult GetNetTotals()
        {
            return GetRPCTypedResult<GetNetTotalsResult>(ZendRPCCommands[ZendRPCCommand.GetNetTotals], new object[0]);
        }

        public GetNetworkInfoResult GetNetworkInfo()
        {
            return GetRPCTypedResult<GetNetworkInfoResult>(ZendRPCCommands[ZendRPCCommand.GetNetworkInfo], new object[0]);
        }

        public IList<PeerInfoResult> GetPeerInfo()
        {
            return GetRPCTypedResult<List<PeerInfoResult>>(ZendRPCCommands[ZendRPCCommand.GetPeerInfo], new object[0]);
        }

        public IList<BannedPeersResult> ListBanned()
        {
            return GetRPCTypedResult<List<BannedPeersResult>>(ZendRPCCommands[ZendRPCCommand.ListBanned], new object[0]);
        }

        public bool Ping()
        {
            return GetRPCTypedResult<bool>(ZendRPCCommands[ZendRPCCommand.Ping], new object[0]);
        }

        public bool SetBan(string ipaddress, int? netmask, SetBanCommand AddRemove, int? bantimeSeconds, bool absolute)
        {
            return GetRPCTypedResult<bool>(ZendRPCCommands[ZendRPCCommand.SetBan], new object[]{ipaddress,netmask,AddRemove,bantimeSeconds,absolute});
        }
        #endregion
    }
}
