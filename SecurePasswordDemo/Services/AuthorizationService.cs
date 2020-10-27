using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SecurePasswordDemo.Services
{
    public class AuthorizationService
    {
        private const int SALT_SIZE = 256;
        private const int INTERATIONS = 500000;
        private const int HASH_BYTE_SIZE = 256;

        public string GenerateSalt()
        {
            byte[] salt = new byte[SALT_SIZE];

            using var random = new RNGCryptoServiceProvider();

            random.GetNonZeroBytes(salt);

            return Convert.ToBase64String(salt);
        }

        public string GenerateHashedPassword(string password, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password + salt);

            using var sha256 = SHA256.Create();

            byte[] hash = sha256.ComputeHash(bytes);

            return Convert.ToBase64String(hash);
        }

        public string HashPasswordWithIterations(string password, string salt, int iterations = INTERATIONS, int hashByteSize = HASH_BYTE_SIZE)
        {
            using var hashGenerator = new Rfc2898DeriveBytes(password: password, salt: Convert.FromBase64String(salt))
            {
                IterationCount = iterations
            };

            return Convert.ToBase64String(hashGenerator.GetBytes(hashByteSize));
        }
    }
}
