using System.Numerics;
using Loom.Nethereum.ABI.FunctionEncoding.Attributes;
using Loom.Nethereum.Contracts.CQS;

namespace Loom.Nethereum.StandardTokenEIP20.CQS
{
    [Function("transfer", "bool")]
    public class TransferFunction:ContractMessage
    {
        [Parameter("address", "_to", 1)]
        public string To {get; set;}
        [Parameter("uint256", "_value", 2)]
        public BigInteger Value {get; set;}
    }
}