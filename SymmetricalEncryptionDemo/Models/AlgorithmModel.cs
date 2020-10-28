using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricalEncryptionDemo.Models
{
    public class AlgorithmModel
    {
        private string _algorithmName;
        private List<AlgorithmModel> _algorithms;

        public AlgorithmModel()
        {
            InitAlgorithms();
        }

        public AlgorithmModel(string algorithmName)
        {
            AlgorithmName = algorithmName;
        }

        public string AlgorithmName { get => _algorithmName; set => _algorithmName = value; }
        public List<AlgorithmModel> Algorithms { get => _algorithms; set => _algorithms = value; }

        public override string ToString()
        {
            return $"{AlgorithmName}";
        }

        private void InitAlgorithms()
        {
            Algorithms = new List<AlgorithmModel>()
            {
                new AlgorithmModel("DES"),
                new AlgorithmModel("3DES"),
                new AlgorithmModel("Rijndael"),
                new AlgorithmModel("AES")
            };
        }
    }
}
