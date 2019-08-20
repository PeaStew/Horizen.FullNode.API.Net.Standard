using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;

namespace Horizen.FullNode.API.Net.Standard.RPC
{
    public partial interface IZendRPCControl
    {
        /* == Control ==
        getinfo
        help ( "command" )
        stop
        */
        GetInfoResult GetInfo(RPCConnection rpc);

        string Help(RPCConnection rpc, string command = null);

        void Stop(RPCConnection rpc);
    }
}
