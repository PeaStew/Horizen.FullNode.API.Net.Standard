using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard.RPCReturnTypes
{ 
    #region Control
    /* == Control ==
    getinfo
    help ( "command" )
    stop
    */


    public class GetInfoResult
    {
        public int version { get; set; }
        public int protocolversion { get; set; }
        public int walletversion { get; set; }
        public double balance { get; set; }
        public int blocks { get; set; }
        public int timeoffset { get; set; }
        public int connections { get; set; }
        public string proxy { get; set; }
        public double difficulty { get; set; }
        public bool testnet { get; set; }
        public int keypoololdest { get; set; }
        public int keypoolsize { get; set; }
        public double paytxfee { get; set; }
        public double relayfee { get; set; }
        public string errors { get; set; }
    }

    #endregion


}
