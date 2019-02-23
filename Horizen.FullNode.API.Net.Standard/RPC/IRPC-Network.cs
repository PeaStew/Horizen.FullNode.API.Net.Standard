using System;
using System.Collections.Generic;
using System.Text;
using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;

namespace Horizen.FullNode.API.Net.Standard.RPC
{
    public partial interface IRPC
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

        bool AddNode(string ipAddress, int port, AddNodeCommand command);
        bool ClearBanned();
        bool DisconnectNode(string ipAddress, int port);
        IList<AddedNodeResult> GetAddedNodeInfo(bool dns, string ipAddress = null, int? port = null);
        int GetConnectionCount();
        GetNetTotalsResult GetNetTotals();
        GetNetworkInfoResult GetNetworkInfo();
        IList<PeerInfoResult> GetPeerInfo();
        IList<BannedPeersResult> ListBanned();
        bool Ping();
        //"bantime"      (numeric, optional) time in seconds how long (or until when if [absolute] is set) the ip is banned (0 or empty means using the default time of 24h which can also be overwritten by the -bantime startup argument)
        //"absolute"     (boolean, optional) If set, the bantime must be a absolute timestamp in seconds since epoch (Jan 1 1970 GMT)
        bool SetBan(string ipaddress, int? netmask, SetBanCommand AddRemove, int? bantimeSeconds, bool absolute);
    }
}
