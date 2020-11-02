using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AsymmetricalEncryptionDemo.Clients
{
    public class ReceiverClient : Client
    {
        private const int FORMAT_PADDING_LEFT = -10;
        private const int FORMAT_PADDING_RIGHT = -25;

        public RSAParameters PrivateData { get; set; }

        public override string ToString() =>
            $"{$"Private Data {Environment.NewLine}"}" +
            $"{$"{"D",FORMAT_PADDING_RIGHT} : {BitConverter.ToString(PrivateData.D)} {Environment.NewLine}"}" +
            $"{$"{"DP",FORMAT_PADDING_RIGHT} : {BitConverter.ToString(PrivateData.DP)} {Environment.NewLine}"}" +
            $"{$"{"DQ",FORMAT_PADDING_RIGHT} : {BitConverter.ToString(PrivateData.DQ)} {Environment.NewLine}"}" +
            $"{$"{"Inverse Q",FORMAT_PADDING_RIGHT} : {BitConverter.ToString(PrivateData.InverseQ)} {Environment.NewLine}"}" +
            $"{$"{"P",FORMAT_PADDING_RIGHT} : {BitConverter.ToString(PrivateData.P)} {Environment.NewLine}"}" +
            $"{$"{"Q",FORMAT_PADDING_RIGHT} : {BitConverter.ToString(PrivateData.Q)} {Environment.NewLine}"}";
    }
}
