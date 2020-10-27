using HashingDemo.Models;
using HashingDemo.Services;
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

namespace HashingDemo
{
    public partial class MainForm : Form
    {
        public ComputeService ComputeService { get { return new ComputeService(); } }
        public Stopwatch StopWatch { get; } = new Stopwatch();
        public TimeSpan Time { get; set; } = new TimeSpan();

        public MainForm()
        {
            InitializeComponent();
            BindAlgorithmsComboBox();
        }

        private void BindAlgorithmsComboBox()
        {
            HashingModel hashingModel = new HashingModel();
            AlgorithComboBox.DataSource = hashingModel.HashingModels;
            AlgorithComboBox.DisplayMember = "Name";
        }

        private void ComputeHashingButton_Click(object sender, EventArgs e)
        {
            AlgorithmDataDisplayErrorLabel.Visible = false;
            ComputeHashingButton.Enabled = false;

            if (!string.IsNullOrEmpty(PlainTextTextBox.Text))
            {
                var selectedItem = AlgorithComboBox.SelectedItem;
                byte[] generatedKey = ComputeService.GenerateKey();

                if (selectedItem is HashingModel model)
                {
                    GeneratedKeyTextBox.Text = Convert.ToBase64String(generatedKey);
                    var hashedResult = new object();

                    switch (model.HashingType)
                    {
                        case HashingType.SHA1:
                            StopWatch.Start();
                            hashedResult = ComputeService.ComputeSHA1Hash(Encoding.UTF8.GetBytes(PlainTextTextBox.Text));
                            StopWatch.Stop();
                            Time = StopWatch.Elapsed;
                            StopWatch.Reset();

                            DisplayBenchmarks(HashingType.SHA1);
                            break;
                        case HashingType.SHA256:
                            StopWatch.Start();
                            hashedResult = ComputeService.ComputeSHA256Hash(Encoding.UTF8.GetBytes(PlainTextTextBox.Text));
                            StopWatch.Stop();
                            Time = StopWatch.Elapsed;
                            StopWatch.Reset();

                            DisplayBenchmarks(HashingType.SHA256);
                            break;
                        case HashingType.SHA384:
                            StopWatch.Start();
                            hashedResult = ComputeService.ComputeSHA384Hash(Encoding.UTF8.GetBytes(PlainTextTextBox.Text));
                            StopWatch.Stop();
                            Time = StopWatch.Elapsed;
                            StopWatch.Reset();

                            DisplayBenchmarks(HashingType.SHA384);
                            break;
                        case HashingType.SHA512:
                            StopWatch.Start();
                            hashedResult = ComputeService.ComputeSHA512Hash(Encoding.UTF8.GetBytes(PlainTextTextBox.Text));
                            StopWatch.Stop();
                            Time = StopWatch.Elapsed;
                            StopWatch.Reset();

                            DisplayBenchmarks(HashingType.SHA512);
                            break;
                        case HashingType.HMAC:
                            StopWatch.Start();
                            hashedResult = ComputeService.ComputeHMACHash(Encoding.UTF8.GetBytes(PlainTextTextBox.Text), generatedKey);
                            StopWatch.Stop();
                            Time = StopWatch.Elapsed;
                            StopWatch.Reset();

                            DisplayBenchmarks(HashingType.HMAC);
                            break;
                        default:
                            break;
                    }

                    SetDisplayProperties((byte[])hashedResult);
                }

                ComputeHashingButton.Enabled = true;
            }
            else
            {
                ComputeHashingButton.Enabled = true;
                AlgorithmDataDisplayErrorLabel.Text = "*Please enter something to hash";
                AlgorithmDataDisplayErrorLabel.Visible = true;
            }
        }

        private void SetDisplayProperties(byte[] hashedValue)
        {
            DisplayPropertiesASCIITextBox.Text = Encoding.ASCII.GetString(hashedValue);
            DisplayPropertiesHEXTextBox.Text = BitConverter.ToString(hashedValue);
        }

        private void DisplayBenchmarks(HashingType hashingType)
        {
            switch (hashingType)
            {
                case HashingType.SHA1:
                    SHA1TextBoxRow1.Text = Time.ToString(@"ss\:fffffff");
                    break;
                case HashingType.SHA256:
                    SHA256TextBoxRow1.Text = Time.ToString(@"ss\:fffffff");
                    break;
                case HashingType.SHA384:
                    SHA384TextBoxRow1.Text = Time.ToString(@"ss\:fffffff");
                    break;
                case HashingType.SHA512:
                    SHA512TextBoxRow1.Text = Time.ToString(@"ss\:fffffff");
                    break;
                case HashingType.HMAC:
                    HMACTextBoxRow1.Text = Time.ToString(@"ss\:fffffff");
                    break;
            }
        }

        private void PlainTextTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PlainTextTextBox.Text))
            {
                AlgorithmDataDisplayErrorLabel.Text = "*Please enter something to hash";
                AlgorithmDataDisplayErrorLabel.Visible = true;
            }
            else
            {
                AlgorithmDataDisplayErrorLabel.Visible = false;
            }
        }
    }
}
