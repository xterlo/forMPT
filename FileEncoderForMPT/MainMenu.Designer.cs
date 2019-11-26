namespace FileEncoderForMPT
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileEncoder = new System.Windows.Forms.Button();
            this.openTextEncoder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileEncoder
            // 
            this.openFileEncoder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openFileEncoder.Location = new System.Drawing.Point(12, 212);
            this.openFileEncoder.Name = "openFileEncoder";
            this.openFileEncoder.Size = new System.Drawing.Size(336, 55);
            this.openFileEncoder.TabIndex = 0;
            this.openFileEncoder.Text = "Файл";
            this.openFileEncoder.UseVisualStyleBackColor = true;
            this.openFileEncoder.Click += new System.EventHandler(this.OpenFileEncoder_Click);
            // 
            // openTextEncoder
            // 
            this.openTextEncoder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openTextEncoder.Location = new System.Drawing.Point(12, 273);
            this.openTextEncoder.Name = "openTextEncoder";
            this.openTextEncoder.Size = new System.Drawing.Size(336, 61);
            this.openTextEncoder.TabIndex = 1;
            this.openTextEncoder.Text = "Текст";
            this.openTextEncoder.UseVisualStyleBackColor = true;
            this.openTextEncoder.Click += new System.EventHandler(this.OpenTextEncoder_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 132);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вас приветствует программа для шифрования текста и файлов!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(209, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Шорин Евгений (СА50-2-19)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 365);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openTextEncoder);
            this.Controls.Add(this.openFileEncoder);
            this.MaximumSize = new System.Drawing.Size(376, 404);
            this.MinimumSize = new System.Drawing.Size(376, 404);
            this.Name = "MainMenu";
            this.Text = "Главная";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFileEncoder;
        private System.Windows.Forms.Button openTextEncoder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

