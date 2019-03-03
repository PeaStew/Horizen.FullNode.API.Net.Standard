using System;
using System.Collections.Generic;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard
{
    public interface IAddress
    {
        string address { get; set; }
        bool ValidateAddress(string address);
    }

    public class PublicAddress: IAddress
    {
        public string address { get; set; }
        public bool ValidateAddress(string address)
        {
            throw new NotImplementedException();
        }
    }

    public interface IPrivateAddress: IAddress
    {
        
    }

    public class SproutAddress : IPrivateAddress
    {
        public string address { get; set; }
        public bool ValidateAddress(string address)
        {
            throw new NotImplementedException();
        }
    }

    public class SaplingAddress : IPrivateAddress
    {
        public string address { get; set; }
        public bool ValidateAddress(string address)
        {
            throw new NotImplementedException();
        }
    }

    public class TransactionId
    {
        public string txid { get; set; }
    }

    public class Blockhash
    {
        public string blockhash { get; set; }
    }
}
