using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard.RPCReturnTypes
{
  #region zCommandResults

    //double zGetBalanceResult
    //List<string> zListAddressesResult
    //List<string> zListoperationIDsResult

    public class ZOperationStatusOrResult
    {
        public string id { get; set; }
        public string status { get; set; }
        public int creation_time { get; set; }
        public TransactionId result { get; set; }
        public double execution_secs { get; set; }
        public string method { get; set; }
        public TransactionDetails _params { get; set; }

        public class TransactionId
        {
            public string txid { get; set; }
        }

        public class TransactionDetails
        {
            public string fromaddress { get; set; }
            public Amount[] amounts { get; set; }
            public int minconf { get; set; }
            public double fee { get; set; }
        }

        public class Amount
        {
            public string address { get; set; }
            public double amount { get; set; }
        }
    }

    #endregion
}
