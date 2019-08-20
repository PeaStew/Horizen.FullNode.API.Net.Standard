using System;
using System.Collections.Generic;
using System.Text;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;

namespace Horizen.FullNode.API.Net.Standard.RPC
{
    public partial interface IZendRPCNetwork
    {
        /* == Network ==
        addnode "node" "add|remove|onetry"
        clearbanned
        disconnectnode "node"
        getaddednodeinfo dns ( "node" )
        getconnectioncount
        getnettotals
        getnetworkinfo
        getpeerinfo
        listbanned
        ping
        setban "ip(/netmask)" "add|remove" (bantime) (absolute)
        */

        bool AddNode(RPCConnection rpc, string ipAddress, int port, AddNodeCommand command);
        bool ClearBanned(RPCConnection rpc);
        bool DisconnectNode(RPCConnection rpc, string ipAddress, int port);
        IList<AddedNodeResult> GetAddedNodeInfo(RPCConnection rpc, bool dns, string ipAddress = null, int? port = null);
        int GetConnectionCount(RPCConnection rpc);
        GetNetTotalsResult GetNetTotals(RPCConnection rpc);
        GetNetworkInfoResult GetNetworkInfo(RPCConnection rpc);
        IList<PeerInfoResult> GetPeerInfo(RPCConnection rpc);
        IList<BannedPeersResult> ListBanned(RPCConnection rpc);
        bool Ping(RPCConnection rpc);
        //"bantime"      (numeric, optional) time in seconds how long (or until when if [absolute] is set) the ip is banned (0 or empty means using the default time of 24h which can also be overwritten by the -bantime startup argument)
        //"absolute"     (boolean, optional) If set, the bantime must be a absolute timestamp in seconds since epoch (Jan 1 1970 GMT)
        bool SetBan(RPCConnection rpc, string ipaddress, int? netmask, SetBanCommand AddRemove, int? bantimeSeconds, bool absolute);
    }
}
