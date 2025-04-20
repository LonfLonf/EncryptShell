namespace EncryptCode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBoxEncrypt = new ComboBox();
            textBoxShellCode = new TextBox();
            comboBoxLanguage = new ComboBox();
            textBox1 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            generateCode = new Button();
            labelInformation = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxEncrypt
            // 
            comboBoxEncrypt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxEncrypt.FormattingEnabled = true;
            comboBoxEncrypt.Items.AddRange(new object[] { "XOR ENCRYPT", "AES ENCRYPT" });
            comboBoxEncrypt.Location = new Point(3, 133);
            comboBoxEncrypt.Name = "comboBoxEncrypt";
            comboBoxEncrypt.Size = new Size(390, 23);
            comboBoxEncrypt.TabIndex = 1;
            comboBoxEncrypt.SelectedIndexChanged += comboBoxEncrypt_SelectedIndexChanged;
            // 
            // textBoxShellCode
            // 
            textBoxShellCode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxShellCode.Location = new Point(3, 162);
            textBoxShellCode.Multiline = true;
            textBoxShellCode.Name = "textBoxShellCode";
            textBoxShellCode.ScrollBars = ScrollBars.Vertical;
            textBoxShellCode.Size = new Size(390, 423);
            textBoxShellCode.TabIndex = 2;
            textBoxShellCode.Text = resources.GetString("textBoxShellCode.Text");
            textBoxShellCode.TextChanged += textBox2_TextChanged;
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Items.AddRange(new object[] { "C", "C#" });
            comboBoxLanguage.Location = new Point(3, 85);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(390, 23);
            comboBoxLanguage.TabIndex = 3;
            comboBoxLanguage.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Location = new Point(3, 37);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Put a name of File";
            textBox1.Size = new Size(390, 23);
            textBox1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(comboBoxLanguage, 0, 1);
            tableLayoutPanel1.Controls.Add(comboBoxEncrypt, 0, 2);
            tableLayoutPanel1.Controls.Add(generateCode, 0, 4);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxShellCode, 0, 3);
            tableLayoutPanel1.Controls.Add(labelInformation, 0, 5);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.110638F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.917337F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.917337F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 61.50568F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.096591F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.380682F));
            tableLayoutPanel1.Size = new Size(416, 704);
            tableLayoutPanel1.TabIndex = 5;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // generateCode
            // 
            generateCode.Location = new Point(3, 591);
            generateCode.Name = "generateCode";
            generateCode.Size = new Size(141, 23);
            generateCode.TabIndex = 5;
            generateCode.Text = "Generate the Code";
            generateCode.UseVisualStyleBackColor = true;
            generateCode.Click += generateCode_Click;
            // 
            // labelInformation
            // 
            labelInformation.Location = new Point(3, 644);
            labelInformation.Name = "labelInformation";
            labelInformation.Size = new Size(410, 23);
            labelInformation.TabIndex = 6;
            labelInformation.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 738);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Encrypt Shell";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBoxEncrypt;
        private TextBox textBoxShellCode;
        private ComboBox comboBoxLanguage;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button generateCode;
        private Label labelInformation;
    }
}
