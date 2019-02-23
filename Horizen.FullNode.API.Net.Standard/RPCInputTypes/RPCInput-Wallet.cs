using System;
using System.Collections.Generic;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard.RPCInputTypes
{
    public class SendManyInput
    {
        private TAddress address { get; set; }
        private float amount { get; set; }
    }
}
