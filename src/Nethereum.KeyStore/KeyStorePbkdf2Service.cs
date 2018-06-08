﻿using System;
using Loom.Nethereum.Hex.HexConvertors.Extensions;
using Loom.Nethereum.KeyStore.Crypto;
using Loom.Nethereum.KeyStore.Model;

namespace Loom.Nethereum.KeyStore
{
    public class KeyStorePbkdf2Service : KeyStoreServiceBase<Pbkdf2Params>
    {
        public const string KdfType = "pbkdf2";

        public KeyStorePbkdf2Service()
        {
        }

        public KeyStorePbkdf2Service(IRandomBytesGenerator randomBytesGenerator, KeyStoreCrypto keyStoreCrypto) : base(
            randomBytesGenerator, keyStoreCrypto)
        {
        }

        public KeyStorePbkdf2Service(IRandomBytesGenerator randomBytesGenerator) : base(randomBytesGenerator)
        {
        }

        protected override byte[] GenerateDerivedKey(string pasword, byte[] salt, Pbkdf2Params kdfParams)
        {
            return KeyStoreCrypto.GeneratePbkdf2Sha256DerivedKey(pasword, salt, kdfParams.Count, kdfParams.Dklen);
        }

        protected override Pbkdf2Params GetDefaultParams()
        {
            return new Pbkdf2Params {Dklen = 32, Count = 262144, Prf = "hmac-sha256"};
        }

        public override byte[] DecryptKeyStore(string password, KeyStore<Pbkdf2Params> keyStore)
        {
            if (password == null) throw new ArgumentNullException(nameof(password));
            if (keyStore == null) throw new ArgumentNullException(nameof(keyStore));

            return KeyStoreCrypto.DecryptPbkdf2Sha256(password, keyStore.Crypto.Mac.HexToByteArray(),
                keyStore.Crypto.CipherParams.Iv.HexToByteArray(),
                keyStore.Crypto.CipherText.HexToByteArray(),
                keyStore.Crypto.Kdfparams.Count,
                keyStore.Crypto.Kdfparams.Salt.HexToByteArray(),
                keyStore.Crypto.Kdfparams.Dklen);
        }

        public override string GetKdfType()
        {
            return KdfType;
        }
    }
}