using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashingDemo.Services
{
    public class ComputeService
    {
        private const int KEY_SIZE = 256;

        public byte[] GenerateKey()
        {
            using var rngProvider = new RNGCryptoServiceProvider();

            var randomKey = new byte[KEY_SIZE];

            rngProvider.GetBytes(randomKey);

            return randomKey;
        }

        public byte[] ComputeSHA1Hash(byte[] toBeHashed)
        {
            using var sha1 = SHA1.Create();

            return sha1.ComputeHash(toBeHashed);
        }

        public byte[] ComputeSHA256Hash(byte[] toBeHashed)
        {
            using var sha256 = SHA256.Create();

            return sha256.ComputeHash(toBeHashed);
        }

        public byte[] ComputeSHA384Hash(byte[] toBeHashed)
        {
            using var sha384 = SHA384.Create();

            return sha384.ComputeHash(toBeHashed);
        }

        public byte[] ComputeSHA512Hash(byte[] toBeHashed)
        {
            using var sha512 = SHA512.Create();

            return sha512.ComputeHash(toBeHashed);
        }

        public byte[] ComputeHMACHash(byte[] toBeHashed, byte[] key)
        {
            using var hmac = new HMACSHA512(key);

            return hmac.ComputeHash(toBeHashed);
        }
    }
}
