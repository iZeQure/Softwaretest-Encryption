using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AsymmetricalEncryptionDemo
{
    public abstract class Client
    {
        private RSAParameters _publicKey;
        private string _cipherText;

        public string CipherText { get => _cipherText; set => _cipherText = value; }
        public RSAParameters PublicKey { get => _publicKey; set => _publicKey = value; }
    }
}
