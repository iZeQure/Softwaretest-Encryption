using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            HashData hashData = new HashData();

            string inputKey = string.Empty;
            string selectedHashingMethod = string.Empty;
            string plainTextToBeHashed = string.Empty;
            string hashedText = string.Empty;
            string usedHashingAlgorithm = string.Empty;

            Console.WriteLine($" 1): SHA1 \n 2): SHA256 \n 3): SHA384 \n 4): SHA512 \n 5): HMAC");
            Console.Write($"Choose a hashing method : "); selectedHashingMethod = Console.ReadLine();

            Console.Write($"Enter a Text to hash : "); plainTextToBeHashed = Console.ReadLine();

            inputKey = Convert.ToBase64String(hashData.GenerateHashingKey());

            switch (selectedHashingMethod)
            {
                case "1":
                    usedHashingAlgorithm = "SHA1";
                    hashedText = Convert.ToBase64String(hashData.ComputeSHA1Hash(Encoding.UTF8.GetBytes(plainTextToBeHashed)));
                    break;
                case "2":
                    usedHashingAlgorithm = "SHA256";
                    hashedText = Convert.ToBase64String(hashData.ComputeSHA256Hash(Encoding.UTF8.GetBytes(plainTextToBeHashed)));
                    break;
                case "3":
                    usedHashingAlgorithm = "SHA384";
                    hashedText = Convert.ToBase64String(hashData.ComputeSHA384Hash(Encoding.UTF8.GetBytes(plainTextToBeHashed)));
                    break;
                case "4":
                    usedHashingAlgorithm = "SHA512";
                    hashedText = Convert.ToBase64String(hashData.ComputeSHA512Hash(Encoding.UTF8.GetBytes(plainTextToBeHashed)));
                    break;
                case "5":
                    usedHashingAlgorithm = "HMAC";
                    hashedText = Convert.ToBase64String(hashData.ComputeHMACHash(Encoding.UTF8.GetBytes(plainTextToBeHashed), Convert.FromBase64String(inputKey)));
                    break;
                default:
                    break;
            }

            if (usedHashingAlgorithm == "HMAC")
            {
                Console.WriteLine($"Key : {inputKey, -20}");
            }

            Console.WriteLine($"Algorithm : {usedHashingAlgorithm, -20}");
            Console.WriteLine(
                $"ASCII : {hashedText,-20}\n" +
                "Hex : {0}", BitConverter.ToString(Convert.FromBase64String(hashedText)).Replace("-", string.Empty));
        }
    }

    public class HashData
    {
        private const int KEY_SIZE = 32;

        public byte[] GenerateHashingKey()
        {
            using var rngProvider = new RNGCryptoServiceProvider();
            var randomNumber = new byte[KEY_SIZE];
            rngProvider.GetBytes(randomNumber);

            return randomNumber;
        }

        public byte[] ComputeSHA1Hash(byte[] toHash)
        {
            using var sha1 = SHA1.Create();

            return sha1.ComputeHash(toHash);
        }

        public byte[] ComputeSHA256Hash(byte[] toHash)
        {
            using var sha256 = SHA256.Create();

            return sha256.ComputeHash(toHash);
        }

        public byte[] ComputeSHA384Hash(byte[] toHash)
        {
            using var sha384 = SHA384.Create();

            return sha384.ComputeHash(toHash);
        }

        public byte[] ComputeSHA512Hash(byte[] toHash)
        {
            using var sha512 = SHA512.Create();

            return sha512.ComputeHash(toHash);
        }

        public byte[] ComputeHMACHash(byte[] toHash, byte[] key)
        {
            using var hmac = new HMACSHA512(key);

            return hmac.ComputeHash(toHash);
        }

        public bool CompareHashes(byte[] sender, byte[] receiver)
        {
            if (sender == receiver)
                return true;
            else
                return false;
        }
    }
}
