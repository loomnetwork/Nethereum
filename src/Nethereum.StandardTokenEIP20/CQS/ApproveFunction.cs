using System.Numerics;
using Loom.Nethereum.ABI.FunctionEncoding.Attributes;
using Loom.Nethereum.Contracts.CQS;

namespace Loom.Nethereum.StandardTokenEIP20.CQS
{
    [Function("approve", "bool")]
    public class ApproveFunction:ContractMessage
    {
        [Parameter("address", "_spender", 1)]
        public string Spender {get; set;}
        [Parameter("uint256", "_value", 2)]
        public BigInteger Value {get; set;}
    }
}