using SymmetricalEncryptionDemo.Models;
using SymmetricalEncryptionDemo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymmetricalEncryptionDemo
{
    public partial class MainForm : Form
    {
        private AlgorithmModel AlgorithmModel { get; } = new AlgorithmModel();
        private SymmetricAlgorithmService SymmetricAlgorithmService { get; } = new SymmetricAlgorithmService();
        private byte[] EncryptedMessage { get; set; }
        private byte[] DecryptedMessage { get; set; }
        private TimeSpan EncryptionTime { get; set; }
        private TimeSpan DecryptionTime { get; set; }
        private Stopwatch Stopwatch { get; } = new Stopwatch();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ComboBox_AlgorithmList.DataSource = AlgorithmModel.Algorithms;
            ComboBox_AlgorithmList.ValueMember = "AlgorithmName";
        }

        private void Button_GenerateProperites_Click(object sender, EventArgs e)
        {
            Button_GenerateProperites.Enabled = false;

            if (ComboBox_AlgorithmList.SelectedItem is AlgorithmModel algorithm)
            {
                SymmetricAlgorithmService.Generate(algorithm.AlgorithmName);

                if (SymmetricAlgorithmService.SymmetricAlgorithm != null)
                {
                    KeyTextBox.Text = Convert.ToBase64String(SymmetricAlgorithmService.SymmetricAlgorithm.Key);
                    IVTextBox.Text = Convert.ToBase64String(SymmetricAlgorithmService.SymmetricAlgorithm.IV);
                }
            }

            Button_GenerateProperites.Enabled = true;
        }

        private void Button_EncryptMessage_Click(object sender, EventArgs e)
        {
            Button_EncryptMessage.Enabled = false;

            if (MessageTextBox.TextLength > 0)
            {
                Stopwatch.Start();
                EncryptedMessage = SymmetricAlgorithmService.Encrypt(Encoding.UTF8.GetBytes(MessageTextBox.Text));
                Stopwatch.Stop();
                EncryptionTime = Stopwatch.Elapsed;
                Stopwatch.Reset();

                EncryptedMessageTextBox.Text = BitConverter.ToString(EncryptedMessage);
            }

            Button_EncryptMessage.Enabled = true;
        }

        private void Button_DecryptMessage_Click(object sender, EventArgs e)
        {
            Button_DecryptMessage.Enabled = false;

            if (EncryptedMessage.Length > 0)
            {
                DisplayEncryptedMessageTextBox.Text = BitConverter.ToString(EncryptedMessage);

                Stopwatch.Start();
                DecryptedMessage = SymmetricAlgorithmService.Decrypt(EncryptedMessage);
                Stopwatch.Stop();
                DecryptionTime = Stopwatch.Elapsed;
                Stopwatch.Reset();

                DecryptedMessageTextBox.Text = Encoding.UTF8.GetString(DecryptedMessage);
            }

            Button_DecryptMessage.Enabled = true;
        }

        private void Button_GetBenchmarkTimes_Click(object sender, EventArgs e)
        {
            EncryptionTimeBenchmark.Text = EncryptionTime.ToString();
            DecryptionTimeBenchmark.Text = DecryptionTime.ToString();
        }
    }
}
