namespace HashingDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AlgorithComboBox = new System.Windows.Forms.ComboBox();
            this.AlgorithmComboBoxTitleLabel = new System.Windows.Forms.Label();
            this.ComputeHashingButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PlainTextLabel = new System.Windows.Forms.Label();
            this.PlainTextTextBox = new System.Windows.Forms.TextBox();
            this.GeneratedKeyLabel = new System.Windows.Forms.Label();
            this.GeneratedKeyTextBox = new System.Windows.Forms.TextBox();
            this.AlgorithmDataTitleLabel = new System.Windows.Forms.Label();
            this.AlgorithmDataDisplayErrorLabel = new System.Windows.Forms.Label();
            this.DisplayPropertiesTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DisplayPropertiesASCIILabel = new System.Windows.Forms.Label();
            this.DisplayPropertiesHEXLabel = new System.Windows.Forms.Label();
            this.DisplayPropertiesHEXTextBox = new System.Windows.Forms.TextBox();
            this.DisplayPropertiesASCIITextBox = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SecondsPerBlockLabel = new System.Windows.Forms.Label();
            this.BytesPerSecondHDDLabel = new System.Windows.Forms.Label();
            this.BytesPerSecondRAMLabel = new System.Windows.Forms.Label();
            this.SHA1Label = new System.Windows.Forms.Label();
            this.SHA256Label = new System.Windows.Forms.Label();
            this.SHA384Label = new System.Windows.Forms.Label();
            this.SHA512Label = new System.Windows.Forms.Label();
            this.HMACLabel = new System.Windows.Forms.Label();
            this.SHA1TextBoxRow1 = new System.Windows.Forms.TextBox();
            this.SHA256TextBoxRow1 = new System.Windows.Forms.TextBox();
            this.SHA384TextBoxRow1 = new System.Windows.Forms.TextBox();
            this.SHA512TextBoxRow1 = new System.Windows.Forms.TextBox();
            this.HMACTextBoxRow1 = new System.Windows.Forms.TextBox();
            this.hashingModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hashingModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hashingModelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hashingModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AlgorithComboBox
            // 
            this.AlgorithComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlgorithComboBox.FormattingEnabled = true;
            this.AlgorithComboBox.Location = new System.Drawing.Point(12, 41);
            this.AlgorithComboBox.Name = "AlgorithComboBox";
            this.AlgorithComboBox.Size = new System.Drawing.Size(203, 21);
            this.AlgorithComboBox.TabIndex = 0;
            // 
            // AlgorithmComboBoxTitleLabel
            // 
            this.AlgorithmComboBoxTitleLabel.AutoSize = true;
            this.AlgorithmComboBoxTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlgorithmComboBoxTitleLabel.Location = new System.Drawing.Point(12, 18);
            this.AlgorithmComboBoxTitleLabel.Name = "AlgorithmComboBoxTitleLabel";
            this.AlgorithmComboBoxTitleLabel.Size = new System.Drawing.Size(159, 20);
            this.AlgorithmComboBoxTitleLabel.TabIndex = 1;
            this.AlgorithmComboBoxTitleLabel.Text = "Pick Panda Algorithm";
            // 
            // ComputeHashingButton
            // 
            this.ComputeHashingButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComputeHashingButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComputeHashingButton.Location = new System.Drawing.Point(12, 85);
            this.ComputeHashingButton.Name = "ComputeHashingButton";
            this.ComputeHashingButton.Size = new System.Drawing.Size(203, 46);
            this.ComputeHashingButton.TabIndex = 2;
            this.ComputeHashingButton.Text = "Compute Hash";
            this.ComputeHashingButton.UseVisualStyleBackColor = true;
            this.ComputeHashingButton.Click += new System.EventHandler(this.ComputeHashingButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = global::HashingDemo.Properties.Resources.FB_IMG_1603713262180;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.tableLayoutPanel1.Controls.Add(this.PlainTextLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PlainTextTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GeneratedKeyLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.GeneratedKeyTextBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(454, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 273);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // PlainTextLabel
            // 
            this.PlainTextLabel.AutoSize = true;
            this.PlainTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlainTextLabel.Location = new System.Drawing.Point(5, 2);
            this.PlainTextLabel.Name = "PlainTextLabel";
            this.PlainTextLabel.Size = new System.Drawing.Size(103, 26);
            this.PlainTextLabel.TabIndex = 0;
            this.PlainTextLabel.Text = "Enter Plain Text:";
            this.PlainTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlainTextTextBox
            // 
            this.PlainTextTextBox.AcceptsTab = true;
            this.PlainTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PlainTextTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PlainTextTextBox.Location = new System.Drawing.Point(116, 5);
            this.PlainTextTextBox.Name = "PlainTextTextBox";
            this.PlainTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.PlainTextTextBox.Size = new System.Drawing.Size(213, 20);
            this.PlainTextTextBox.TabIndex = 1;
            this.PlainTextTextBox.Leave += new System.EventHandler(this.PlainTextTextBox_Leave);
            // 
            // GeneratedKeyLabel
            // 
            this.GeneratedKeyLabel.AutoSize = true;
            this.GeneratedKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneratedKeyLabel.Location = new System.Drawing.Point(5, 30);
            this.GeneratedKeyLabel.Name = "GeneratedKeyLabel";
            this.GeneratedKeyLabel.Size = new System.Drawing.Size(103, 26);
            this.GeneratedKeyLabel.TabIndex = 2;
            this.GeneratedKeyLabel.Text = "Generated Key:";
            this.GeneratedKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GeneratedKeyTextBox
            // 
            this.GeneratedKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneratedKeyTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GeneratedKeyTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratedKeyTextBox.Location = new System.Drawing.Point(116, 33);
            this.GeneratedKeyTextBox.Name = "GeneratedKeyTextBox";
            this.GeneratedKeyTextBox.ReadOnly = true;
            this.GeneratedKeyTextBox.Size = new System.Drawing.Size(213, 20);
            this.GeneratedKeyTextBox.TabIndex = 3;
            // 
            // AlgorithmDataTitleLabel
            // 
            this.AlgorithmDataTitleLabel.AutoSize = true;
            this.AlgorithmDataTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlgorithmDataTitleLabel.Location = new System.Drawing.Point(456, 18);
            this.AlgorithmDataTitleLabel.Name = "AlgorithmDataTitleLabel";
            this.AlgorithmDataTitleLabel.Size = new System.Drawing.Size(115, 20);
            this.AlgorithmDataTitleLabel.TabIndex = 6;
            this.AlgorithmDataTitleLabel.Text = "Algorithm Data";
            // 
            // AlgorithmDataDisplayErrorLabel
            // 
            this.AlgorithmDataDisplayErrorLabel.AutoSize = true;
            this.AlgorithmDataDisplayErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.AlgorithmDataDisplayErrorLabel.Location = new System.Drawing.Point(577, 23);
            this.AlgorithmDataDisplayErrorLabel.Name = "AlgorithmDataDisplayErrorLabel";
            this.AlgorithmDataDisplayErrorLabel.Size = new System.Drawing.Size(129, 13);
            this.AlgorithmDataDisplayErrorLabel.TabIndex = 7;
            this.AlgorithmDataDisplayErrorLabel.Text = "AlgorithmDataDisplayError";
            this.AlgorithmDataDisplayErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AlgorithmDataDisplayErrorLabel.Visible = false;
            // 
            // DisplayPropertiesTitleLabel
            // 
            this.DisplayPropertiesTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayPropertiesTitleLabel.AutoSize = true;
            this.DisplayPropertiesTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayPropertiesTitleLabel.Location = new System.Drawing.Point(456, 317);
            this.DisplayPropertiesTitleLabel.Name = "DisplayPropertiesTitleLabel";
            this.DisplayPropertiesTitleLabel.Size = new System.Drawing.Size(136, 20);
            this.DisplayPropertiesTitleLabel.TabIndex = 4;
            this.DisplayPropertiesTitleLabel.Text = "Display Properties";
            this.DisplayPropertiesTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.67F));
            this.tableLayoutPanel2.Controls.Add(this.DisplayPropertiesASCIILabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DisplayPropertiesHEXLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.DisplayPropertiesHEXTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.DisplayPropertiesASCIITextBox, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(454, 340);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(334, 98);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // DisplayPropertiesASCIILabel
            // 
            this.DisplayPropertiesASCIILabel.AutoSize = true;
            this.DisplayPropertiesASCIILabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayPropertiesASCIILabel.Location = new System.Drawing.Point(5, 2);
            this.DisplayPropertiesASCIILabel.Name = "DisplayPropertiesASCIILabel";
            this.DisplayPropertiesASCIILabel.Size = new System.Drawing.Size(103, 46);
            this.DisplayPropertiesASCIILabel.TabIndex = 0;
            this.DisplayPropertiesASCIILabel.Text = "ASCII";
            this.DisplayPropertiesASCIILabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DisplayPropertiesHEXLabel
            // 
            this.DisplayPropertiesHEXLabel.AutoSize = true;
            this.DisplayPropertiesHEXLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayPropertiesHEXLabel.Location = new System.Drawing.Point(5, 50);
            this.DisplayPropertiesHEXLabel.Name = "DisplayPropertiesHEXLabel";
            this.DisplayPropertiesHEXLabel.Size = new System.Drawing.Size(103, 46);
            this.DisplayPropertiesHEXLabel.TabIndex = 1;
            this.DisplayPropertiesHEXLabel.Text = "HEX";
            this.DisplayPropertiesHEXLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DisplayPropertiesHEXTextBox
            // 
            this.DisplayPropertiesHEXTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayPropertiesHEXTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DisplayPropertiesHEXTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayPropertiesHEXTextBox.Location = new System.Drawing.Point(116, 63);
            this.DisplayPropertiesHEXTextBox.Name = "DisplayPropertiesHEXTextBox";
            this.DisplayPropertiesHEXTextBox.ReadOnly = true;
            this.DisplayPropertiesHEXTextBox.Size = new System.Drawing.Size(213, 20);
            this.DisplayPropertiesHEXTextBox.TabIndex = 3;
            // 
            // DisplayPropertiesASCIITextBox
            // 
            this.DisplayPropertiesASCIITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayPropertiesASCIITextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DisplayPropertiesASCIITextBox.Location = new System.Drawing.Point(116, 15);
            this.DisplayPropertiesASCIITextBox.Name = "DisplayPropertiesASCIITextBox";
            this.DisplayPropertiesASCIITextBox.ReadOnly = true;
            this.DisplayPropertiesASCIITextBox.Size = new System.Drawing.Size(213, 20);
            this.DisplayPropertiesASCIITextBox.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Controls.Add(this.SecondsPerBlockLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.BytesPerSecondHDDLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.BytesPerSecondRAMLabel, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.SHA1Label, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.SHA256Label, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.SHA384Label, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.SHA512Label, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.HMACLabel, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.SHA1TextBoxRow1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.SHA256TextBoxRow1, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.SHA384TextBoxRow1, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.SHA512TextBoxRow1, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.HMACTextBoxRow1, 5, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 222);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(436, 216);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // SecondsPerBlockLabel
            // 
            this.SecondsPerBlockLabel.AutoSize = true;
            this.SecondsPerBlockLabel.BackColor = System.Drawing.Color.LightGray;
            this.SecondsPerBlockLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondsPerBlockLabel.Location = new System.Drawing.Point(5, 55);
            this.SecondsPerBlockLabel.Name = "SecondsPerBlockLabel";
            this.SecondsPerBlockLabel.Size = new System.Drawing.Size(64, 51);
            this.SecondsPerBlockLabel.TabIndex = 0;
            this.SecondsPerBlockLabel.Text = "Seconds / Block";
            this.SecondsPerBlockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BytesPerSecondHDDLabel
            // 
            this.BytesPerSecondHDDLabel.AutoSize = true;
            this.BytesPerSecondHDDLabel.BackColor = System.Drawing.Color.Silver;
            this.BytesPerSecondHDDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BytesPerSecondHDDLabel.Location = new System.Drawing.Point(5, 108);
            this.BytesPerSecondHDDLabel.Name = "BytesPerSecondHDDLabel";
            this.BytesPerSecondHDDLabel.Size = new System.Drawing.Size(64, 51);
            this.BytesPerSecondHDDLabel.TabIndex = 1;
            this.BytesPerSecondHDDLabel.Text = "Bytes / Second (HDD)";
            this.BytesPerSecondHDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BytesPerSecondRAMLabel
            // 
            this.BytesPerSecondRAMLabel.AutoSize = true;
            this.BytesPerSecondRAMLabel.BackColor = System.Drawing.Color.DarkGray;
            this.BytesPerSecondRAMLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BytesPerSecondRAMLabel.Location = new System.Drawing.Point(5, 161);
            this.BytesPerSecondRAMLabel.Name = "BytesPerSecondRAMLabel";
            this.BytesPerSecondRAMLabel.Size = new System.Drawing.Size(64, 53);
            this.BytesPerSecondRAMLabel.TabIndex = 2;
            this.BytesPerSecondRAMLabel.Text = "Bytes / Second (RAM)";
            this.BytesPerSecondRAMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SHA1Label
            // 
            this.SHA1Label.AutoSize = true;
            this.SHA1Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SHA1Label.Location = new System.Drawing.Point(77, 40);
            this.SHA1Label.Name = "SHA1Label";
            this.SHA1Label.Size = new System.Drawing.Size(64, 13);
            this.SHA1Label.TabIndex = 3;
            this.SHA1Label.Text = "SHA 1";
            this.SHA1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SHA256Label
            // 
            this.SHA256Label.AutoSize = true;
            this.SHA256Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SHA256Label.Location = new System.Drawing.Point(149, 40);
            this.SHA256Label.Name = "SHA256Label";
            this.SHA256Label.Size = new System.Drawing.Size(64, 13);
            this.SHA256Label.TabIndex = 4;
            this.SHA256Label.Text = "SHA 256";
            this.SHA256Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SHA384Label
            // 
            this.SHA384Label.AutoSize = true;
            this.SHA384Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SHA384Label.Location = new System.Drawing.Point(221, 40);
            this.SHA384Label.Name = "SHA384Label";
            this.SHA384Label.Size = new System.Drawing.Size(64, 13);
            this.SHA384Label.TabIndex = 5;
            this.SHA384Label.Text = "SHA 384";
            this.SHA384Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SHA512Label
            // 
            this.SHA512Label.AutoSize = true;
            this.SHA512Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SHA512Label.Location = new System.Drawing.Point(293, 40);
            this.SHA512Label.Name = "SHA512Label";
            this.SHA512Label.Size = new System.Drawing.Size(64, 13);
            this.SHA512Label.TabIndex = 6;
            this.SHA512Label.Text = "SHA 512";
            this.SHA512Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HMACLabel
            // 
            this.HMACLabel.AutoSize = true;
            this.HMACLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HMACLabel.Location = new System.Drawing.Point(365, 40);
            this.HMACLabel.Name = "HMACLabel";
            this.HMACLabel.Size = new System.Drawing.Size(66, 13);
            this.HMACLabel.TabIndex = 7;
            this.HMACLabel.Text = "HMAC";
            this.HMACLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SHA1TextBoxRow1
            // 
            this.SHA1TextBoxRow1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SHA1TextBoxRow1.BackColor = System.Drawing.Color.LightGray;
            this.SHA1TextBoxRow1.Location = new System.Drawing.Point(77, 70);
            this.SHA1TextBoxRow1.Name = "SHA1TextBoxRow1";
            this.SHA1TextBoxRow1.ReadOnly = true;
            this.SHA1TextBoxRow1.Size = new System.Drawing.Size(64, 20);
            this.SHA1TextBoxRow1.TabIndex = 8;
            // 
            // SHA256TextBoxRow1
            // 
            this.SHA256TextBoxRow1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SHA256TextBoxRow1.BackColor = System.Drawing.Color.LightGray;
            this.SHA256TextBoxRow1.Location = new System.Drawing.Point(149, 70);
            this.SHA256TextBoxRow1.Name = "SHA256TextBoxRow1";
            this.SHA256TextBoxRow1.ReadOnly = true;
            this.SHA256TextBoxRow1.Size = new System.Drawing.Size(64, 20);
            this.SHA256TextBoxRow1.TabIndex = 9;
            // 
            // SHA384TextBoxRow1
            // 
            this.SHA384TextBoxRow1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SHA384TextBoxRow1.BackColor = System.Drawing.Color.LightGray;
            this.SHA384TextBoxRow1.Location = new System.Drawing.Point(221, 70);
            this.SHA384TextBoxRow1.Name = "SHA384TextBoxRow1";
            this.SHA384TextBoxRow1.ReadOnly = true;
            this.SHA384TextBoxRow1.Size = new System.Drawing.Size(64, 20);
            this.SHA384TextBoxRow1.TabIndex = 10;
            // 
            // SHA512TextBoxRow1
            // 
            this.SHA512TextBoxRow1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SHA512TextBoxRow1.BackColor = System.Drawing.Color.LightGray;
            this.SHA512TextBoxRow1.Location = new System.Drawing.Point(293, 70);
            this.SHA512TextBoxRow1.Name = "SHA512TextBoxRow1";
            this.SHA512TextBoxRow1.ReadOnly = true;
            this.SHA512TextBoxRow1.Size = new System.Drawing.Size(64, 20);
            this.SHA512TextBoxRow1.TabIndex = 11;
            // 
            // HMACTextBoxRow1
            // 
            this.HMACTextBoxRow1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HMACTextBoxRow1.BackColor = System.Drawing.Color.LightGray;
            this.HMACTextBoxRow1.Location = new System.Drawing.Point(365, 70);
            this.HMACTextBoxRow1.Name = "HMACTextBoxRow1";
            this.HMACTextBoxRow1.ReadOnly = true;
            this.HMACTextBoxRow1.Size = new System.Drawing.Size(66, 20);
            this.HMACTextBoxRow1.TabIndex = 12;
            // 
            // hashingModelsBindingSource
            // 
            this.hashingModelsBindingSource.DataMember = "HashingModels";
            this.hashingModelsBindingSource.DataSource = this.hashingModelBindingSource;
            // 
            // hashingModelBindingSource
            // 
            this.hashingModelBindingSource.DataSource = typeof(HashingDemo.Models.HashingModel);
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(HashingDemo.MainForm);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.AlgorithmDataDisplayErrorLabel);
            this.Controls.Add(this.AlgorithmDataTitleLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DisplayPropertiesTitleLabel);
            this.Controls.Add(this.ComputeHashingButton);
            this.Controls.Add(this.AlgorithmComboBoxTitleLabel);
            this.Controls.Add(this.AlgorithComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panda\'s Hashing Club";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hashingModelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hashingModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AlgorithComboBox;
        private System.Windows.Forms.Label AlgorithmComboBoxTitleLabel;
        private System.Windows.Forms.Button ComputeHashingButton;
        private System.Windows.Forms.BindingSource hashingModelBindingSource;
        private System.Windows.Forms.BindingSource mainFormBindingSource;
        private System.Windows.Forms.BindingSource hashingModelsBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label PlainTextLabel;
        private System.Windows.Forms.TextBox PlainTextTextBox;
        private System.Windows.Forms.Label GeneratedKeyLabel;
        private System.Windows.Forms.TextBox GeneratedKeyTextBox;
        private System.Windows.Forms.Label AlgorithmDataTitleLabel;
        private System.Windows.Forms.Label AlgorithmDataDisplayErrorLabel;
        private System.Windows.Forms.Label DisplayPropertiesTitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label DisplayPropertiesASCIILabel;
        private System.Windows.Forms.Label DisplayPropertiesHEXLabel;
        private System.Windows.Forms.TextBox DisplayPropertiesHEXTextBox;
        private System.Windows.Forms.MaskedTextBox DisplayPropertiesASCIITextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label SecondsPerBlockLabel;
        private System.Windows.Forms.Label BytesPerSecondHDDLabel;
        private System.Windows.Forms.Label BytesPerSecondRAMLabel;
        private System.Windows.Forms.Label SHA1Label;
        private System.Windows.Forms.Label SHA256Label;
        private System.Windows.Forms.Label SHA384Label;
        private System.Windows.Forms.Label SHA512Label;
        private System.Windows.Forms.Label HMACLabel;
        private System.Windows.Forms.TextBox SHA1TextBoxRow1;
        private System.Windows.Forms.TextBox SHA256TextBoxRow1;
        private System.Windows.Forms.TextBox SHA384TextBoxRow1;
        private System.Windows.Forms.TextBox SHA512TextBoxRow1;
        private System.Windows.Forms.TextBox HMACTextBoxRow1;
    }
}

