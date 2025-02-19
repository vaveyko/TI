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
        plefnerTabPage = new System.Windows.Forms.TabPage();
        folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
        openFileButton = new System.Windows.Forms.Button();
        tabControl1.SuspendLayout();
        vigenerTabPage.SuspendLayout();
        SuspendLayout();
        // 
        // keyTextBox
        // 
        keyTextBox.Location = new System.Drawing.Point(6, 65);
        keyTextBox.Name = "keyTextBox";
        keyTextBox.Size = new System.Drawing.Size(173, 31);
        keyTextBox.TabIndex = 0;
        // 
        // cipherButton
        // 
        cipherButton.Location = new System.Drawing.Point(6, 112);
        cipherButton.Name = "cipherButton";
        cipherButton.Size = new System.Drawing.Size(173, 42);
        cipherButton.TabIndex = 1;
        cipherButton.Text = "Зашифровать";
        cipherButton.UseVisualStyleBackColor = true;
        cipherButton.Click += cipherButton_Click;
        // 
        // unCipherButton
        // 
        unCipherButton.Location = new System.Drawing.Point(6, 160);
        unCipherButton.Name = "unCipherButton";
        unCipherButton.Size = new System.Drawing.Size(173, 42);
        unCipherButton.TabIndex = 2;
        unCipherButton.Text = "Расшифровать";
        unCipherButton.UseVisualStyleBackColor = true;
        unCipherButton.Click += unCipherButton_Click;
        // 
        // inputTextBox
        // 
        inputTextBox.Location = new System.Drawing.Point(331, 51);
        inputTextBox.Multiline = true;
        inputTextBox.Name = "inputTextBox";
        inputTextBox.Size = new System.Drawing.Size(310, 151);
        inputTextBox.TabIndex = 3;
        // 
        // outputTextBox
        // 
        outputTextBox.Location = new System.Drawing.Point(331, 221);
        outputTextBox.Multiline = true;
        outputTextBox.Name = "outputTextBox";
        outputTextBox.Size = new System.Drawing.Size(310, 151);
        outputTextBox.TabIndex = 4;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(vigenerTabPage);
        tabControl1.Controls.Add(plefnerTabPage);
        tabControl1.Location = new System.Drawing.Point(-3, 1);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(802, 611);
        tabControl1.TabIndex = 5;
        // 
        // vigenerTabPage
        // 
        vigenerTabPage.Controls.Add(openFileButton);
        vigenerTabPage.Controls.Add(outputTextBox);
        vigenerTabPage.Controls.Add(unCipherButton);
        vigenerTabPage.Controls.Add(cipherButton);
        vigenerTabPage.Controls.Add(inputTextBox);
        vigenerTabPage.Controls.Add(keyTextBox);
        vigenerTabPage.Location = new System.Drawing.Point(4, 34);
        vigenerTabPage.Name = "vigenerTabPage";
        vigenerTabPage.Padding = new System.Windows.Forms.Padding(3);
        vigenerTabPage.Size = new System.Drawing.Size(794, 573);
        vigenerTabPage.TabIndex = 0;
        vigenerTabPage.Text = "Виженер";
        vigenerTabPage.UseVisualStyleBackColor = true;
        // 
        // plefnerTabPage
        // 
        plefnerTabPage.Location = new System.Drawing.Point(4, 34);
        plefnerTabPage.Name = "plefnerTabPage";
        plefnerTabPage.Padding = new System.Windows.Forms.Padding(3);
        plefnerTabPage.Size = new System.Drawing.Size(794, 573);
        plefnerTabPage.TabIndex = 1;
        plefnerTabPage.Text = "Плейфер";
        plefnerTabPage.UseVisualStyleBackColor = true;
        // 
        // openFileButton
        // 
        openFileButton.Location = new System.Drawing.Point(97, 19);
        openFileButton.Name = "openFileButton";
        openFileButton.Size = new System.Drawing.Size(81, 32);
        openFileButton.TabIndex = 5;
        openFileButton.Text = "Файл";
        openFileButton.UseVisualStyleBackColor = true;
        openFileButton.Click += openFileButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 619);
        Controls.Add(tabControl1);
        Text = "Form1";
        tabControl1.ResumeLayout(false);
        vigenerTabPage.ResumeLayout(false);
        vigenerTabPage.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button openFileButton;

    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

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