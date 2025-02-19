namespace lab1;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        keyTextBox = new System.Windows.Forms.TextBox();
        cipherButton = new System.Windows.Forms.Button();
        unCipherButton = new System.Windows.Forms.Button();
        inputTextBox = new System.Windows.Forms.TextBox();
        outputTextBox = new System.Windows.Forms.TextBox();
        tabControl1 = new System.Windows.Forms.TabControl();
        vigenerTabPage = new System.Windows.Forms.TabPage();
        openFileButton = new System.Windows.Forms.Button();
        plefnerTabPage = new System.Windows.Forms.TabPage();
        openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        tabControl1.SuspendLayout();
        vigenerTabPage.SuspendLayout();
        SuspendLayout();
        // 
        // keyTextBox
        // 
        keyTextBox.Location = new System.Drawing.Point(35, 65);
        keyTextBox.Name = "keyTextBox";
        keyTextBox.Size = new System.Drawing.Size(215, 31);
        keyTextBox.TabIndex = 0;
        // 
        // cipherButton
        // 
        cipherButton.Location = new System.Drawing.Point(35, 112);
        cipherButton.Name = "cipherButton";
        cipherButton.Size = new System.Drawing.Size(215, 42);
        cipherButton.TabIndex = 1;
        cipherButton.Text = "Зашифровать";
        cipherButton.UseVisualStyleBackColor = true;
        cipherButton.Click += cipherButton_Click;
        // 
        // unCipherButton
        // 
        unCipherButton.Location = new System.Drawing.Point(35, 160);
        unCipherButton.Name = "unCipherButton";
        unCipherButton.Size = new System.Drawing.Size(215, 42);
        unCipherButton.TabIndex = 2;
        unCipherButton.Text = "Расшифровать";
        unCipherButton.UseVisualStyleBackColor = true;
        unCipherButton.Click += unCipherButton_Click;
        // 
        // inputTextBox
        // 
        inputTextBox.Location = new System.Drawing.Point(331, 65);
        inputTextBox.Multiline = true;
        inputTextBox.Name = "inputTextBox";
        inputTextBox.Size = new System.Drawing.Size(435, 167);
        inputTextBox.TabIndex = 3;
        // 
        // outputTextBox
        // 
        outputTextBox.Location = new System.Drawing.Point(331, 270);
        outputTextBox.Multiline = true;
        outputTextBox.Name = "outputTextBox";
        outputTextBox.Size = new System.Drawing.Size(435, 167);
        outputTextBox.TabIndex = 4;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(vigenerTabPage);
        tabControl1.Controls.Add(plefnerTabPage);
        tabControl1.Location = new System.Drawing.Point(-3, 1);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(802, 493);
        tabControl1.TabIndex = 5;
        // 
        // vigenerTabPage
        // 
        vigenerTabPage.Controls.Add(label3);
        vigenerTabPage.Controls.Add(label2);
        vigenerTabPage.Controls.Add(label1);
        vigenerTabPage.Controls.Add(openFileButton);
        vigenerTabPage.Controls.Add(outputTextBox);
        vigenerTabPage.Controls.Add(unCipherButton);
        vigenerTabPage.Controls.Add(cipherButton);
        vigenerTabPage.Controls.Add(inputTextBox);
        vigenerTabPage.Controls.Add(keyTextBox);
        vigenerTabPage.Location = new System.Drawing.Point(4, 34);
        vigenerTabPage.Name = "vigenerTabPage";
        vigenerTabPage.Padding = new System.Windows.Forms.Padding(3);
        vigenerTabPage.Size = new System.Drawing.Size(794, 455);
        vigenerTabPage.TabIndex = 0;
        vigenerTabPage.Text = "Виженер";
        vigenerTabPage.UseVisualStyleBackColor = true;
        // 
        // openFileButton
        // 
        openFileButton.Location = new System.Drawing.Point(169, 27);
        openFileButton.Name = "openFileButton";
        openFileButton.Size = new System.Drawing.Size(81, 32);
        openFileButton.TabIndex = 5;
        openFileButton.Text = "Файл";
        openFileButton.UseVisualStyleBackColor = true;
        openFileButton.Click += openFileButton_Click;
        // 
        // plefnerTabPage
        // 
        plefnerTabPage.Location = new System.Drawing.Point(4, 34);
        plefnerTabPage.Name = "plefnerTabPage";
        plefnerTabPage.Padding = new System.Windows.Forms.Padding(3);
        plefnerTabPage.Size = new System.Drawing.Size(794, 455);
        plefnerTabPage.TabIndex = 1;
        plefnerTabPage.Text = "Плейфер";
        plefnerTabPage.UseVisualStyleBackColor = true;
        // 
        // openFileDialog1
        // 
        openFileDialog1.Filter = "(*.txt)|*.txt";
        openFileDialog1.ReadOnlyChecked = true;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(35, 27);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(134, 32);
        label1.TabIndex = 6;
        label1.Text = "Ключ";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(331, 27);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(241, 32);
        label2.TabIndex = 7;
        label2.Text = "Обычный текст";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(331, 235);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(241, 32);
        label3.TabIndex = 8;
        label3.Text = "Преобразованный текст";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 494);
        Controls.Add(tabControl1);
        Text = "Шифры";
        tabControl1.ResumeLayout(false);
        vigenerTabPage.ResumeLayout(false);
        vigenerTabPage.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.OpenFileDialog openFileDialog1;

    private System.Windows.Forms.Button openFileButton;

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage vigenerTabPage;
    private System.Windows.Forms.TabPage plefnerTabPage;

    private System.Windows.Forms.TextBox inputTextBox;

    private System.Windows.Forms.TextBox keyTextBox;
    private System.Windows.Forms.Button cipherButton;
    private System.Windows.Forms.Button unCipherButton;
    private System.Windows.Forms.TextBox outputTextBox;

    #endregion
}