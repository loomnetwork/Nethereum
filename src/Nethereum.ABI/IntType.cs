using Loom.Nethereum.ABI.Decoders;
using Loom.Nethereum.ABI.Encoders;

namespace Loom.Nethereum.ABI
{
    public class IntType : ABIType
    {
        public IntType(string name) : base(name)
        {
            Decoder = new IntTypeDecoder();
            Encoder = new IntTypeEncoder();
        }

        public override string CanonicalName
        {
            get
            {
                if (Name.Equals("int"))
                    return "int256";
                if (Name.Equals("uint"))
                    return "uint256";
                return base.CanonicalName;
            }
        }
    }
}