using AsymmetricalEncryptionDemo.Clients;
using AsymmetricalEncryptionDemo.Encryptions;
using System;
using System.Linq;
using System.Text;

namespace AsymmetricalEncryptionDemo
{
    class Program
    {
        private const string ORIGINAL_MESSAGE = "May the force be with you.";

        private static RsaWithCspKey _rsaWithCspKey = new RsaWithCspKey();

        private static string _hexValue;

        static void Main(string[] args)
        {
            SenderClient senderClient = new SenderClient();
            ReceiverClient receiverClient = new ReceiverClient();

            try
            {
                _rsaWithCspKey.AssignNeyCspKey();

                var publicKey = _rsaWithCspKey.CryptoServiceProvider.ExportParameters(false);
                var privateKey = _rsaWithCspKey.CryptoServiceProvider.ExportParameters(true);

                senderClient.PublicKey = publicKey;

                receiverClient.PublicKey = publicKey;
                receiverClient.PrivateData = privateKey;

                SenderClientData(senderClient as SenderClient);
                ReceiverClientData(receiverClient as ReceiverClient);
            }
            finally
            {
                _rsaWithCspKey.DeleteKeyFromCsp();
            }
        }

        private static void SenderClientData(SenderClient senderClient)
        {
            byte[] cipherDataBytes = _rsaWithCspKey.EncryptData(plainData: Encoding.UTF8.GetBytes(ORIGINAL_MESSAGE));

            _hexValue = BitConverter.ToString(cipherDataBytes);
            senderClient.CipherText = BitConverter.ToString(cipherDataBytes);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"## Sender Client ##");
            Console.ResetColor();

            Console.WriteLine($"{"Exponent",-25} : {BitConverter.ToString(senderClient.PublicKey.Exponent)}");
            Console.WriteLine($"{"Modulus",-25} : {BitConverter.ToString(senderClient.PublicKey.Modulus)}");

            Console.WriteLine();

            Console.WriteLine($"{"Original Message",-25} : {ORIGINAL_MESSAGE}");
            Console.WriteLine($"{"Cipher Message",-25} : {senderClient.CipherText}");
        }

        private static void ReceiverClientData(ReceiverClient receiverClient)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Environment.NewLine} ## Receiver Client ##");
            Console.ResetColor();

            Console.WriteLine("Public Data");

            Console.WriteLine($"{"Exponent",-25} : {BitConverter.ToString(receiverClient.PublicKey.Exponent)}");
            Console.WriteLine($"{"Modulus",-25} : {BitConverter.ToString(receiverClient.PublicKey.Modulus)}");

            Console.WriteLine();

            Console.WriteLine(receiverClient.ToString());

            Console.WriteLine($"{"Cipher Message",-25} : {_hexValue}");
            Console.WriteLine($"{"Delivered Message",-25} : {Encoding.UTF8.GetString(_rsaWithCspKey.DecryptData(GetBytesFromHex(_hexValue)))}");
        }

        public static byte[] GetBytesFromHex(string hex)
        {
            hex = hex.Replace("-", "");

            return Enumerable.Range(0, hex.Length)
                    .Where(x => x % 2 == 0)
                    .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                    .ToArray();
        }
    }
}
