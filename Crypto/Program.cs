using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Crypto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random(DateTime.Now.Ticks.GetHashCode());

            CryptographyDemo cryptographyDemo = new CryptographyDemo();
            SubstitutionCryptography substitutionCryptography = new SubstitutionCryptography();

            Console.Write("Enter Clear Text : ");
            string clearText = Console.ReadLine();
            int pad = rng.Next(1, 11);

            string encryptedText = substitutionCryptography.Encrypter(clearText, pad);

            Console.WriteLine($"Encrypted Text : {encryptedText}");
            Console.WriteLine($"Decrypted Text : {substitutionCryptography.Descrypter(encryptedText, pad)}");

            Console.WriteLine($"<< Benchmark Random & RNGCryptoServiceProvider >>");
            Console.Write("How many times shall it run : ");
            int.TryParse(Console.ReadLine(), out int timesToRun);

            Console.WriteLine($"Benchmarking results, please wait..");
            cryptographyDemo.BenchmarkResults(timesToRun);
        }
    }

    public class CryptographyDemo
    {
        private void GetUnsecureRandom(int timesToRun)
        {
            var random = new Random(250);

            for (int i = 0; i < timesToRun; i++)
            {
                random.Next(-10, 11);
            }
        }

        private void GetSecureRandom(int timesToRun)
        {
            using var provider = new RNGCryptoServiceProvider();

            byte[] data = new byte[4];

            for (int i = 0; i < timesToRun; i++)
            {
                provider.GetBytes(data);

                BitConverter.ToInt32(data, 0);
            }
        }

        public void BenchmarkResults(int timesToRun)
        {
            var stopW = new Stopwatch();

            stopW.Start();
            GetUnsecureRandom(timesToRun);
            stopW.Stop();

            Console.WriteLine("Elapsed time in seconds with unsecure : {0}", stopW.Elapsed.TotalSeconds);
            stopW.Reset();

            stopW.Start();
            GetSecureRandom(timesToRun);
            stopW.Stop();

            Console.WriteLine("Elapsed time in seconds with secure : {0}", stopW.Elapsed.TotalSeconds);
        }
    }

    public class SubstitutionCryptography
    {
        private readonly Regex Regex = new Regex(@"[\w-\S]");

        public string Encrypter(string clearText, int padRight)
        {
            string encryptedString = string.Empty;

            for (int character = 0; character < clearText.Length; character++)
            {
                if (Regex.IsMatch(clearText[character].ToString()))
                {
                    int c = (clearText[character] + padRight);

                    encryptedString += (char)c;
                }
                else
                {
                    encryptedString += clearText[character];
                }
            }

            return encryptedString;
        }

        public string Descrypter(string encryptedText, int padLeft)
        {
            string decryptedString = string.Empty;

            for (int character = 0; character < encryptedText.Length; character++)
            {
                if (Regex.IsMatch(encryptedText[character].ToString()))
                {
                    int c = (encryptedText[character] - padLeft);

                    decryptedString += (char)c;
                }
                else
                {
                    decryptedString += encryptedText[character];
                }
            }

            return decryptedString;
        }
    }
}
