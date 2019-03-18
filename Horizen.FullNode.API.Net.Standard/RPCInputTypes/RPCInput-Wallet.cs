using System;
using System.Collections.Generic;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard.RPCInputTypes
{
    public class SendManyInput
    {
        private PublicAddress address { get; set; }
        private double amount { get; set; }
    }
}
