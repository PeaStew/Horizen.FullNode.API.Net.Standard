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
        GetInfoResult GetInfo();

        string Help(string command = null);

        void Stop();
    }
}
