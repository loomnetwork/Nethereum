﻿using System.Numerics;
using Loom.Nethereum.ABI.FunctionEncoding.Attributes;

namespace Loom.Nethereum.StandardTokenEIP20.Events.DTO
{
    public class Transfer
    {
        [Parameter("address", "from", 1, true)]
        public string AddressFrom { get; set; }

        [Parameter("address", "to", 2, true)]
        public string AddressTo { get; set; }

        [Parameter("uint", "value", 3)]
        public BigInteger Value { get; set; }
    }
}
