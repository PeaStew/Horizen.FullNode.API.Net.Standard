using Horizen.FullNode.API.Net.Standard.RPCReturnTypes;

namespace Horizen.FullNode.API.Net.Standard.RPC
{
    public partial interface IRPC
    {
        /* == Control ==
        getinfo
        help ( "command" )
        stop
        */
        GetInfoResult GetInfo();

        string Help();

        void Stop();
    }
}
