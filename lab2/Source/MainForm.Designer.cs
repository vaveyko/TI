﻿namespace StreamingEncryption
{
    partial class MainForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registerStatusLabel = new System.Windows.Forms.Label();
            this.registerStatusTextBox = new System.Windows.Forms.TextBox();
            this.registerLengthLabel = new System.Windows.Forms.Label();
            this.registerLengthTextBox = new System.Windows.Forms.TextBox();
            this.plainTextLabel = new System.Windows.Forms.Label();
            this.plainTextTextBox = new System.Windows.Forms.TextBox();
            this.generatedKeyLabel = new System.Windows.Forms.Label();
            this.generatedKeyTextBox = new System.Windows.Forms.TextBox();
            this.cipherTextLabel = new System.Windows.Forms.Label();
            this.cipherTextTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerStatusLabel
            // 
            this.registerStatusLabel.AutoSize = true;
            this.registerStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerStatusLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerStatusLabel.Location = new System.Drawing.Point(13, 42);
            this.registerStatusLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.registerStatusLabel.Name = "registerStatusLabel";
            this.registerStatusLabel.Size = new System.Drawing.Size(305, 29);
            this.registerStatusLabel.TabIndex = 0;
            this.registerStatusLabel.Text = "Состояние регистра (26):\r\n";
            // 
            // registerStatusTextBox
            // 
            this.registerStatusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerStatusTextBox.Location = new System.Drawing.Point(18, 84);
            this.registerStatusTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.registerStatusTextBox.MaxLength = 200;
            this.registerStatusTextBox.Name = "registerStatusTextBox";
            this.registerStatusTextBox.Size = new System.Drawing.Size(705, 35);
            this.registerStatusTextBox.TabIndex = 1;
            this.registerStatusTextBox.Text = "11111111111111111111111111";
            this.registerStatusTextBox.TextChanged += new System.EventHandler(this.registerStatusTextBox_TextChanged);
            // 
            // registerLengthLabel
            // 
            this.registerLengthLabel.AutoSize = true;
            this.registerLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLengthLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerLengthLabel.Location = new System.Drawing.Point(734, 42);
            this.registerLengthLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.registerLengthLabel.Name = "registerLengthLabel";
            this.registerLengthLabel.Size = new System.Drawing.Size(308, 29);
            this.registerLengthLabel.TabIndex = 2;
            this.registerLengthLabel.Text = "Текущая длина регистра:";
            // 
            // registerLengthTextBox
            // 
            this.registerLengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLengthTextBox.Location = new System.Drawing.Point(739, 84);
            this.registerLengthTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.registerLengthTextBox.MaxLength = 50;
            this.registerLengthTextBox.Name = "registerLengthTextBox";
            this.registerLengthTextBox.ReadOnly = true;
            this.registerLengthTextBox.Size = new System.Drawing.Size(286, 35);
            this.registerLengthTextBox.TabIndex = 3;
            this.registerLengthTextBox.Text = "26";
            // 
            // plainTextLabel
            // 
            this.plainTextLabel.AutoSize = true;
            this.plainTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plainTextLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plainTextLabel.Location = new System.Drawing.Point(13, 313);
            this.plainTextLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.plainTextLabel.Name = "plainTextLabel";
            this.plainTextLabel.Size = new System.Drawing.Size(203, 29);
            this.plainTextLabel.TabIndex = 4;
            this.plainTextLabel.Text = "Исходный текст:";
            // 
            // plainTextTextBox
            // 
            this.plainTextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plainTextTextBox.Location = new System.Drawing.Point(18, 343);
            this.plainTextTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.plainTextTextBox.MaxLength = 50;
            this.plainTextTextBox.Multiline = true;
            this.plainTextTextBox.Name = "plainTextTextBox";
            this.plainTextTextBox.ReadOnly = true;
            this.plainTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.plainTextTextBox.Size = new System.Drawing.Size(1142, 100);
            this.plainTextTextBox.TabIndex = 5;
            // 
            // generatedKeyLabel
            // 
            this.generatedKeyLabel.AutoSize = true;
            this.generatedKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generatedKeyLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generatedKeyLabel.Location = new System.Drawing.Point(13, 182);
            this.generatedKeyLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.generatedKeyLabel.Name = "generatedKeyLabel";
            this.generatedKeyLabel.Size = new System.Drawing.Size(300, 29);
            this.generatedKeyLabel.TabIndex = 6;
            this.generatedKeyLabel.Text = "Сгенерированный ключ:";
            // 
            // generatedKeyTextBox
            // 
            this.generatedKeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generatedKeyTextBox.Location = new System.Drawing.Point(17, 212);
            this.generatedKeyTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.generatedKeyTextBox.MaxLength = 50;
            this.generatedKeyTextBox.Multiline = true;
            this.generatedKeyTextBox.Name = "generatedKeyTextBox";
            this.generatedKeyTextBox.ReadOnly = true;
            this.generatedKeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.generatedKeyTextBox.Size = new System.Drawing.Size(1143, 100);
            this.generatedKeyTextBox.TabIndex = 7;
            // 
            // cipherTextLabel
            // 
            this.cipherTextLabel.AutoSize = true;
            this.cipherTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cipherTextLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cipherTextLabel.Location = new System.Drawing.Point(17, 445);
            this.cipherTextLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cipherTextLabel.Name = "cipherTextLabel";
            this.cipherTextLabel.Size = new System.Drawing.Size(284, 29);
            this.cipherTextLabel.TabIndex = 8;
            this.cipherTextLabel.Text = "Зашифрованный текст:";
            // 
            // cipherTextTextBox
            // 
            this.cipherTextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cipherTextTextBox.Location = new System.Drawing.Point(18, 479);
            this.cipherTextTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.cipherTextTextBox.MaxLength = 50;
            this.cipherTextTextBox.Multiline = true;
            this.cipherTextTextBox.Name = "cipherTextTextBox";
            this.cipherTextTextBox.ReadOnly = true;
            this.cipherTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cipherTextTextBox.Size = new System.Drawing.Size(1142, 100);
            this.cipherTextTextBox.TabIndex = 9;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1177, 33);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.openToolStripMenuItem, this.saveToolStripMenuItem });
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Enabled = false;
            this.encryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptButton.ForeColor = System.Drawing.Color.Teal;
            this.encryptButton.Location = new System.Drawing.Point(356, 122);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(367, 72);
            this.encryptButton.TabIndex = 11;
            this.encryptButton.Text = "Зашифровать";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1177, 596);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.cipherTextTextBox);
            this.Controls.Add(this.cipherTextLabel);
            this.Controls.Add(this.generatedKeyTextBox);
            this.Controls.Add(this.generatedKeyLabel);
            this.Controls.Add(this.plainTextTextBox);
            this.Controls.Add(this.plainTextLabel);
            this.Controls.Add(this.registerLengthTextBox);
            this.Controls.Add(this.registerLengthLabel);
            this.Controls.Add(this.registerStatusTextBox);
            this.Controls.Add(this.registerStatusLabel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Потоковое шифрование";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label registerStatusLabel;
        private System.Windows.Forms.TextBox registerStatusTextBox;
        private System.Windows.Forms.Label registerLengthLabel;
        private System.Windows.Forms.TextBox registerLengthTextBox;
        private System.Windows.Forms.Label plainTextLabel;
        private System.Windows.Forms.TextBox plainTextTextBox;
        private System.Windows.Forms.Label generatedKeyLabel;
        private System.Windows.Forms.TextBox generatedKeyTextBox;
        private System.Windows.Forms.Label cipherTextLabel;
        private System.Windows.Forms.TextBox cipherTextTextBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

