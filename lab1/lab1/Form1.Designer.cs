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
        SuspendLayout();
        // 
        // keyTextBox
        // 
        keyTextBox.Location = new System.Drawing.Point(44, 43);
        keyTextBox.Name = "keyTextBox";
        keyTextBox.Size = new System.Drawing.Size(173, 31);
        keyTextBox.TabIndex = 0;
        // 
        // cipherButton
        // 
        cipherButton.Location = new System.Drawing.Point(44, 90);
        cipherButton.Name = "cipherButton";
        cipherButton.Size = new System.Drawing.Size(173, 42);
        cipherButton.TabIndex = 1;
        cipherButton.Text = "Зашифровать";
        cipherButton.UseVisualStyleBackColor = true;
        cipherButton.Click += cipherButton_Click;
        // 
        // unCipherButton
        // 
        unCipherButton.Location = new System.Drawing.Point(44, 149);
        unCipherButton.Name = "unCipherButton";
        unCipherButton.Size = new System.Drawing.Size(173, 42);
        unCipherButton.TabIndex = 2;
        unCipherButton.Text = "Расшифровать";
        unCipherButton.UseVisualStyleBackColor = true;
        unCipherButton.Click += unCipherButton_Click;
        // 
        // inputTextBox
        // 
        inputTextBox.Location = new System.Drawing.Point(416, 39);
        inputTextBox.Multiline = true;
        inputTextBox.Name = "inputTextBox";
        inputTextBox.Size = new System.Drawing.Size(310, 151);
        inputTextBox.TabIndex = 3;
        // 
        // outputTextBox
        // 
        outputTextBox.Location = new System.Drawing.Point(416, 214);
        outputTextBox.Multiline = true;
        outputTextBox.Name = "outputTextBox";
        outputTextBox.Size = new System.Drawing.Size(310, 151);
        outputTextBox.TabIndex = 4;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(outputTextBox);
        Controls.Add(inputTextBox);
        Controls.Add(unCipherButton);
        Controls.Add(cipherButton);
        Controls.Add(keyTextBox);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox inputTextBox;

    private System.Windows.Forms.TextBox keyTextBox;
    private System.Windows.Forms.Button cipherButton;
    private System.Windows.Forms.Button unCipherButton;
    private System.Windows.Forms.TextBox outputTextBox;

    #endregion
}