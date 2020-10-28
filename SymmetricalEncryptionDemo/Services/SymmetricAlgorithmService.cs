using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricalEncryptionDemo.Services
{
    public class SymmetricAlgorithmService
    {
        public SymmetricAlgorithm SymmetricAlgorithm { get; private set; }

        public void Generate(string cipherToBeUsed)
        {
            switch (cipherToBeUsed)
            {
                case "DES":
                    SymmetricAlgorithm = DES.Create();
                    break;
                case "3DES":
                    SymmetricAlgorithm = TripleDES.Create();
                    break;
                case "Rijndael":
                    SymmetricAlgorithm = Rijndael.Create();
                    break;
                case "AES":
                    SymmetricAlgorithm = Aes.Create();
                    break;
            }

            SymmetricAlgorithm.GenerateKey();
            SymmetricAlgorithm.GenerateIV();
        }

        public byte[] Encrypt(byte[] message)
        {
            using (var memoryStream = new MemoryStream())
            {
                var cryptoStream = new CryptoStream(
                    memoryStream, 
                    SymmetricAlgorithm.CreateEncryptor(),
                    CryptoStreamMode.Write);

                cryptoStream.Write(message, 0, message.Length);
                cryptoStream.FlushFinalBlock();

                return memoryStream.ToArray();
            }
        }

        public byte[] Decrypt(byte[] message)
        {
            using (var memoryStream = new MemoryStream())
            {
                var cryptoStream = new CryptoStream(
                    memoryStream,
                    SymmetricAlgorithm.CreateDecryptor(),
                    CryptoStreamMode.Write);

                cryptoStream.Write(message, 0, message.Length);
                cryptoStream.FlushFinalBlock();

                return memoryStream.ToArray();
            }
        }
    }
}
