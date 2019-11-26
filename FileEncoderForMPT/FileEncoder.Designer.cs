namespace FileEncoderForMPT
{
    partial class FileEncoder
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
            this.openFileDlg = new System.Windows.Forms.Button();
            this.saveFileDlg = new System.Windows.Forms.Button();
            this.KeyGen = new System.Windows.Forms.Button();
            this.importFile = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exportFile = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.KeyText = new System.Windows.Forms.TextBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDlg
            // 
            this.openFileDlg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.openFileDlg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.openFileDlg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.openFileDlg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openFileDlg.Location = new System.Drawing.Point(325, 20);
            this.openFileDlg.Name = "openFileDlg";
            this.openFileDlg.Size = new System.Drawing.Size(25, 20);
            this.openFileDlg.TabIndex = 0;
            this.openFileDlg.Text = "...";
            this.openFileDlg.UseVisualStyleBackColor = false;
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveFileDlg.Location = new System.Drawing.Point(325, 60);
            this.saveFileDlg.Name = "saveFileDlg";
            this.saveFileDlg.Size = new System.Drawing.Size(25, 20);
            this.saveFileDlg.TabIndex = 1;
            this.saveFileDlg.Text = "...";
            this.saveFileDlg.UseVisualStyleBackColor = true;
            // 
            // KeyGen
            // 
            this.KeyGen.Location = new System.Drawing.Point(6, 42);
            this.KeyGen.Name = "KeyGen";
            this.KeyGen.Size = new System.Drawing.Size(344, 47);
            this.KeyGen.TabIndex = 2;
            this.KeyGen.Text = "Генерация ключа";
            this.KeyGen.UseVisualStyleBackColor = true;
            // 
            // importFile
            // 
            this.importFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.importFile.Enabled = false;
            this.importFile.Location = new System.Drawing.Point(8, 20);
            this.importFile.Name = "importFile";
            this.importFile.Size = new System.Drawing.Size(311, 20);
            this.importFile.TabIndex = 3;
            this.importFile.Text = "Импорт";
            this.importFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.exportFile);
            this.groupBox1.Controls.Add(this.importFile);
            this.groupBox1.Controls.Add(this.openFileDlg);
            this.groupBox1.Controls.Add(this.saveFileDlg);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 108);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор файла";
            // 
            // exportFile
            // 
            this.exportFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exportFile.Enabled = false;
            this.exportFile.Location = new System.Drawing.Point(8, 60);
            this.exportFile.Name = "exportFile";
            this.exportFile.Size = new System.Drawing.Size(311, 20);
            this.exportFile.TabIndex = 4;
            this.exportFile.Text = "Экспорт";
            this.exportFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.KeyText);
            this.groupBox2.Controls.Add(this.KeyGen);
            this.groupBox2.Location = new System.Drawing.Point(12, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 95);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключ";
            // 
            // KeyText
            // 
            this.KeyText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyText.Location = new System.Drawing.Point(8, 16);
            this.KeyText.Name = "KeyText";
            this.KeyText.Size = new System.Drawing.Size(342, 20);
            this.KeyText.TabIndex = 0;
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(18, 228);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(344, 43);
            this.Encrypt.TabIndex = 6;
            this.Encrypt.Text = "Зашифровать";
            this.Encrypt.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(20, 278);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Назад";
            this.BackButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FileEncoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 305);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FileEncoder";
            this.Text = "Файл";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileEncoder_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFileDlg;
        private System.Windows.Forms.Button saveFileDlg;
        private System.Windows.Forms.Button KeyGen;
        private System.Windows.Forms.TextBox importFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox exportFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox KeyText;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button BackButton;
    }
}