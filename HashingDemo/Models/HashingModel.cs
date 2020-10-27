using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashingDemo.Models
{
    public enum HashingType
    {
        SHA1 = 0,
        SHA256 = 1,
        SHA384 = 2,
        SHA512 = 3,
        HMAC = 4
    }

    public class HashingModel
    {
        private string _name;
        private HashingType _hashingType;
        private HMAC key;

        public HashingModel()
        {
            GetAlgorithmList();
        }

        public HashingModel(string name, HashingType hashingType)
        {
            Name = name;
            HashingType = hashingType;
        }

        public List<HashingModel> HashingModels { get; set; }
        public string Name { get => _name; set => _name = value; }
        public HMAC Key { get => key; set => key = value; }
        internal HashingType HashingType { get => _hashingType; set => _hashingType = value; }

        private void GetAlgorithmList()
        {
            HashingModels = new List<HashingModel>()
            {
                new HashingModel("SHA 1 Algorithm", HashingType.SHA1),
                new HashingModel("SHA 256 Algorithm", HashingType.SHA256),
                new HashingModel("SHA 384 Algorithm", HashingType.SHA384),
                new HashingModel("SHA 512 Algorithm", HashingType.SHA512),
                new HashingModel("HMAC Algorithm", HashingType.HMAC)
            };
        }
    }
}
