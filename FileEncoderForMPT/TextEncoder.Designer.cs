namespace FileEncoderForMPT
{
    partial class TextEncoder
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
            this.EncryptText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.KeyGen = new System.Windows.Forms.Button();
            this.DecryptText = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncryptText
            // 
            this.EncryptText.Location = new System.Drawing.Point(18, 113);
            this.EncryptText.Multiline = true;
            this.EncryptText.Name = "EncryptText";
            this.EncryptText.Size = new System.Drawing.Size(359, 128);
            this.EncryptText.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.KeyTextBox);
            this.groupBox2.Controls.Add(this.KeyGen);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 95);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключ";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyTextBox.Location = new System.Drawing.Point(6, 16);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(359, 20);
            this.KeyTextBox.TabIndex = 0;
            // 
            // KeyGen
            // 
            this.KeyGen.Location = new System.Drawing.Point(6, 42);
            this.KeyGen.Name = "KeyGen";
            this.KeyGen.Size = new System.Drawing.Size(359, 47);
            this.KeyGen.TabIndex = 2;
            this.KeyGen.Text = "Генерация ключа";
            this.KeyGen.UseVisualStyleBackColor = true;
            // 
            // DecryptText
            // 
            this.DecryptText.Location = new System.Drawing.Point(18, 293);
            this.DecryptText.Multiline = true;
            this.DecryptText.Name = "DecryptText";
            this.DecryptText.Size = new System.Drawing.Size(359, 128);
            this.DecryptText.TabIndex = 7;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(18, 248);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(164, 39);
            this.EncryptButton.TabIndex = 8;
            this.EncryptButton.Text = "Зашифровать";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(203, 248);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(174, 39);
            this.DecryptButton.TabIndex = 9;
            this.DecryptButton.Text = "Дешифровать";
            this.DecryptButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(18, 425);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 23);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Назад";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TextEncoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.DecryptText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.EncryptText);
            this.Name = "TextEncoder";
            this.Text = "Текст";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextEncoder_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Button KeyGen;
        private System.Windows.Forms.TextBox DecryptText;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button backButton;
        protected System.Windows.Forms.TextBox EncryptText;
    }
}