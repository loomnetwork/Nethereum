using System.Numerics;
using Loom.Nethereum.ABI.FunctionEncoding.Attributes;

namespace Loom.Nethereum.StandardTokenEIP20.DTOs
{
    [Event("Approval")]
    public class ApprovalEventDTO
    {
        [Parameter("address", "_owner", 1, true )]
        public string Owner {get; set;}
        [Parameter("address", "_spender", 2, true )]
        public string Spender {get; set;}
        [Parameter("uint256", "_value", 3, false )]
        public BigInteger Value {get; set;}
    }
}