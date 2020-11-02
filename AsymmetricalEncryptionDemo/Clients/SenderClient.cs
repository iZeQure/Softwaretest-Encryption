using System;
using System.Collections.Generic;
using System.Text;

namespace AsymmetricalEncryptionDemo.Clients
{
    public class SenderClient : Client
    {
        private string _painText;

        public string PainText { get => _painText; set => _painText = value; }
    }
}
