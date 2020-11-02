using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AsymmetricalEncryptionDemo.Encryptions
{
    public class RsaWithCspKey
    {
        private const string CONTAINER_NAME = "PandaClubExtentions";
        private const int KEY_SIZE = 2048;

        private CspParameters _containerParameters;
        private RSACryptoServiceProvider _cryptoServiceProvider;

        public RSACryptoServiceProvider CryptoServiceProvider { get => _cryptoServiceProvider; set => _cryptoServiceProvider = value; }

        public void AssignNeyCspKey(int dWTypeIn = 1)
        {
            _containerParameters = new CspParameters(dWTypeIn)
            {
                KeyContainerName = CONTAINER_NAME,
                Flags = CspProviderFlags.UseMachineKeyStore,
                ProviderName = "Microsoft Strong Cryptographic Provider"
            };

            CryptoServiceProvider = new RSACryptoServiceProvider(_containerParameters)
            {
                PersistKeyInCsp = false
            };
        }

        public void DeleteKeyFromCsp()
        {
            CryptoServiceProvider.Clear();
        }

        public byte[] EncryptData(byte[] plainData)
        {
            byte[] encryptedDataBytes;

            using (CryptoServiceProvider = new RSACryptoServiceProvider(KEY_SIZE, _containerParameters))
            {
                encryptedDataBytes = CryptoServiceProvider.Encrypt(plainData, false);
            }

            return encryptedDataBytes;
        }

        public byte[] DecryptData(byte[] encryptedData)
        {
            byte[] plainDataBytes;

            using (CryptoServiceProvider = new RSACryptoServiceProvider(KEY_SIZE, _containerParameters))
            {
                plainDataBytes = CryptoServiceProvider.Decrypt(encryptedData, false);
            }

            return plainDataBytes;
        }
    }
}
