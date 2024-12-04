namespace HashApp
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
            label1 = new Label();
            comboBoxFormatData = new ComboBox();
            label2 = new Label();
            textBoxData = new TextBox();
            checkBoxMD5 = new CheckBox();
            label3 = new Label();
            textBoxMD5 = new TextBox();
            textBoxSHA1 = new TextBox();
            label4 = new Label();
            checkBoxSHA1 = new CheckBox();
            textBoxSHA256 = new TextBox();
            label5 = new Label();
            checkBoxSHA2 = new CheckBox();
            buttonCalculate = new Button();
            groupBox1 = new GroupBox();
            radioButtonHex = new RadioButton();
            radioButtonText = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 0;
            label1.Text = "Format Data";
            // 
            // comboBoxFormatData
            // 
            comboBoxFormatData.FormattingEnabled = true;
            comboBoxFormatData.Items.AddRange(new object[] { "Text", "Hex", "File" });
            comboBoxFormatData.Location = new Point(16, 47);
            comboBoxFormatData.Name = "comboBoxFormatData";
            comboBoxFormatData.Size = new Size(101, 33);
            comboBoxFormatData.TabIndex = 1;
            comboBoxFormatData.Text = "Text";
            comboBoxFormatData.SelectedIndexChanged += comboBoxFormatData_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 11);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 2;
            label2.Text = "Data";
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(185, 49);
            textBoxData.Multiline = true;
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(472, 31);
            textBoxData.TabIndex = 3;
            textBoxData.Text = "HaiNam";
            // 
            // checkBoxMD5
            // 
            checkBoxMD5.AutoSize = true;
            checkBoxMD5.Checked = true;
            checkBoxMD5.CheckState = CheckState.Checked;
            checkBoxMD5.Location = new Point(13, 111);
            checkBoxMD5.Name = "checkBoxMD5";
            checkBoxMD5.Size = new Size(22, 21);
            checkBoxMD5.TabIndex = 4;
            checkBoxMD5.TextAlign = ContentAlignment.TopLeft;
            checkBoxMD5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 108);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 5;
            label3.Text = "MD5";
            // 
            // textBoxMD5
            // 
            textBoxMD5.Location = new Point(154, 102);
            textBoxMD5.Name = "textBoxMD5";
            textBoxMD5.Size = new Size(472, 31);
            textBoxMD5.TabIndex = 6;
            // 
            // textBoxSHA1
            // 
            textBoxSHA1.Location = new Point(154, 153);
            textBoxSHA1.Name = "textBoxSHA1";
            textBoxSHA1.Size = new Size(472, 31);
            textBoxSHA1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 159);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 8;
            label4.Text = "SHA-1";
            // 
            // checkBoxSHA1
            // 
            checkBoxSHA1.AutoSize = true;
            checkBoxSHA1.Checked = true;
            checkBoxSHA1.CheckState = CheckState.Checked;
            checkBoxSHA1.Location = new Point(12, 161);
            checkBoxSHA1.Name = "checkBoxSHA1";
            checkBoxSHA1.Size = new Size(22, 21);
            checkBoxSHA1.TabIndex = 7;
            checkBoxSHA1.TextAlign = ContentAlignment.TopLeft;
            checkBoxSHA1.UseVisualStyleBackColor = true;
            // 
            // textBoxSHA256
            // 
            textBoxSHA256.Location = new Point(154, 200);
            textBoxSHA256.Name = "textBoxSHA256";
            textBoxSHA256.Size = new Size(472, 31);
            textBoxSHA256.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 206);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 11;
            label5.Text = "SHA-256";
            // 
            // checkBoxSHA2
            // 
            checkBoxSHA2.AutoSize = true;
            checkBoxSHA2.Checked = true;
            checkBoxSHA2.CheckState = CheckState.Checked;
            checkBoxSHA2.Location = new Point(12, 210);
            checkBoxSHA2.Name = "checkBoxSHA2";
            checkBoxSHA2.Size = new Size(22, 21);
            checkBoxSHA2.TabIndex = 10;
            checkBoxSHA2.TextAlign = ContentAlignment.TopLeft;
            checkBoxSHA2.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(13, 350);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(112, 34);
            buttonCalculate.TabIndex = 13;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonHex);
            groupBox1.Controls.Add(radioButtonText);
            groupBox1.Location = new Point(13, 256);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(188, 70);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Type content of file";
            // 
            // radioButtonHex
            // 
            radioButtonHex.AutoSize = true;
            radioButtonHex.Location = new Point(101, 30);
            radioButtonHex.Name = "radioButtonHex";
            radioButtonHex.Size = new Size(67, 29);
            radioButtonHex.TabIndex = 1;
            radioButtonHex.TabStop = true;
            radioButtonHex.Text = "Hex";
            radioButtonHex.UseVisualStyleBackColor = true;
            // 
            // radioButtonText
            // 
            radioButtonText.AutoSize = true;
            radioButtonText.Location = new Point(6, 30);
            radioButtonText.Name = "radioButtonText";
            radioButtonText.Size = new Size(67, 29);
            radioButtonText.TabIndex = 0;
            radioButtonText.TabStop = true;
            radioButtonText.Text = "Text";
            radioButtonText.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 416);
            Controls.Add(groupBox1);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxSHA256);
            Controls.Add(label5);
            Controls.Add(checkBoxSHA2);
            Controls.Add(textBoxSHA1);
            Controls.Add(label4);
            Controls.Add(checkBoxSHA1);
            Controls.Add(textBoxMD5);
            Controls.Add(label3);
            Controls.Add(checkBoxMD5);
            Controls.Add(textBoxData);
            Controls.Add(label2);
            Controls.Add(comboBoxFormatData);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Hash Application";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxFormatData;
        private Label label2;
        private TextBox textBoxData;
        private CheckBox checkBoxMD5;
        private Label label3;
        private TextBox textBoxMD5;
        private TextBox textBoxSHA1;
        private Label label4;
        private CheckBox checkBoxSHA1;
        private TextBox textBoxSHA256;
        private Label label5;
        private CheckBox checkBoxSHA2;
        private Button buttonCalculate;
        private GroupBox groupBox1;
        private RadioButton radioButtonHex;
        private RadioButton radioButtonText;
    }
}
