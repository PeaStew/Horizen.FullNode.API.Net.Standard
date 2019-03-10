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
            return GetRPCTypedResult<bool>("getnetworksolps", new object[] { $"{ipAddress}", port, command});
        }

        public bool ClearBanned()
        {
            throw new NotImplementedException();
        }

        public bool DisconnectNode(string ipAddress, int port)
        {
            throw new NotImplementedException();
        }

        public IList<AddedNodeResult> GetAddedNodeInfo(bool dns, string ipAddress = null, int? port = null)
        {
            throw new NotImplementedException();
        }

        public int GetConnectionCount()
        {
            throw new NotImplementedException();
        }

        public GetNetTotalsResult GetNetTotals()
        {
            throw new NotImplementedException();
        }

        public GetNetworkInfoResult GetNetworkInfo()
        {
            throw new NotImplementedException();
        }

        public IList<PeerInfoResult> GetPeerInfo()
        {
            throw new NotImplementedException();
        }

        public IList<BannedPeersResult> ListBanned()
        {
            throw new NotImplementedException();
        }

        public bool Ping()
        {
            throw new NotImplementedException();
        }

        public bool SetBan(string ipaddress, int? netmask, SetBanCommand AddRemove, int? bantimeSeconds, bool absolute)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
