using System.Numerics;
using Loom.Nethereum.ABI.FunctionEncoding.Attributes;
using Loom.Nethereum.Contracts.CQS;

namespace Loom.Nethereum.StandardTokenEIP20.CQS
{
    [Function("transferFrom", "bool")]
    public class TransferFromFunction:ContractMessage
    {
        [Parameter("address", "_from", 1)]
        public string From {get; set;}
        [Parameter("address", "_to", 2)]
        public string To {get; set;}
        [Parameter("uint256", "_value", 3)]
        public BigInteger Value {get; set;}
    }
}
