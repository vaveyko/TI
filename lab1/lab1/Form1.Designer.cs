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
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        openFileButton = new System.Windows.Forms.Button();
        plefnerTabPage = new System.Windows.Forms.TabPage();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        outTextBox2 = new System.Windows.Forms.TextBox();
        inputTextBox2 = new System.Windows.Forms.TextBox();
        button2 = new System.Windows.Forms.Button();
        label4 = new System.Windows.Forms.Label();
        keyPlTextBox1 = new System.Windows.Forms.TextBox();
        cipherButton2 = new System.Windows.Forms.Button();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        keyPlTextBox2 = new System.Windows.Forms.TextBox();
        keyPlTextBox4 = new System.Windows.Forms.TextBox();
        keyPlTextBox3 = new System.Windows.Forms.TextBox();
        tabControl1.SuspendLayout();
        vigenerTabPage.SuspendLayout();
        plefnerTabPage.SuspendLayout();
        SuspendLayout();
        // 
        // keyTextBox
        // 
        keyTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
        keyTextBox.Location = new System.Drawing.Point(79, 124);
        keyTextBox.Name = "keyTextBox";
        keyTextBox.Size = new System.Drawing.Size(215, 37);
        keyTextBox.TabIndex = 0;
        // 
        // cipherButton
        // 
        cipherButton.Font = new System.Drawing.Font("Segoe UI", 11F);
        cipherButton.Location = new System.Drawing.Point(79, 171);
        cipherButton.Name = "cipherButton";
        cipherButton.Size = new System.Drawing.Size(215, 42);
        cipherButton.TabIndex = 1;
        cipherButton.Text = "Зашифровать";
        cipherButton.UseVisualStyleBackColor = true;
        cipherButton.Click += cipherButton_Click;
        // 
        // unCipherButton
        // 
        unCipherButton.Font = new System.Drawing.Font("Segoe UI", 11F);
        unCipherButton.Location = new System.Drawing.Point(79, 219);
        unCipherButton.Name = "unCipherButton";
        unCipherButton.Size = new System.Drawing.Size(215, 42);
        unCipherButton.TabIndex = 2;
        unCipherButton.Text = "Расшифровать";
        unCipherButton.UseVisualStyleBackColor = true;
        unCipherButton.Click += unCipherButton_Click;
        // 
        // inputTextBox
        // 
        inputTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
        inputTextBox.Location = new System.Drawing.Point(453, 113);
        inputTextBox.Multiline = true;
        inputTextBox.Name = "inputTextBox";
        inputTextBox.Size = new System.Drawing.Size(458, 185);
        inputTextBox.TabIndex = 3;
        // 
        // outputTextBox
        // 
        outputTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
        outputTextBox.Location = new System.Drawing.Point(453, 348);
        outputTextBox.Multiline = true;
        outputTextBox.Name = "outputTextBox";
        outputTextBox.Size = new System.Drawing.Size(458, 197);
        outputTextBox.TabIndex = 4;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(vigenerTabPage);
        tabControl1.Controls.Add(plefnerTabPage);
        tabControl1.Location = new System.Drawing.Point(-3, 1);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(1001, 684);
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
        vigenerTabPage.Size = new System.Drawing.Size(993, 646);
        vigenerTabPage.TabIndex = 0;
        vigenerTabPage.Text = "Виженер";
        vigenerTabPage.UseVisualStyleBackColor = true;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 11F);
        label3.Location = new System.Drawing.Point(453, 313);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(303, 32);
        label3.TabIndex = 8;
        label3.Text = "Преобразованный текст";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 11F);
        label2.Location = new System.Drawing.Point(453, 75);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(250, 32);
        label2.TabIndex = 7;
        label2.Text = "Обычный текст";
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 11F);
        label1.Location = new System.Drawing.Point(79, 75);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(124, 43);
        label1.TabIndex = 6;
        label1.Text = "Ключ";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // openFileButton
        // 
        openFileButton.Font = new System.Drawing.Font("Segoe UI", 11F);
        openFileButton.Location = new System.Drawing.Point(209, 75);
        openFileButton.Name = "openFileButton";
        openFileButton.Size = new System.Drawing.Size(85, 43);
        openFileButton.TabIndex = 5;
        openFileButton.Text = "Файл";
        openFileButton.UseVisualStyleBackColor = true;
        openFileButton.Click += openFileButton_Click;
        // 
        // plefnerTabPage
        // 
        plefnerTabPage.Controls.Add(keyPlTextBox3);
        plefnerTabPage.Controls.Add(keyPlTextBox4);
        plefnerTabPage.Controls.Add(keyPlTextBox2);
        plefnerTabPage.Controls.Add(label6);
        plefnerTabPage.Controls.Add(label5);
        plefnerTabPage.Controls.Add(button1);
        plefnerTabPage.Controls.Add(outTextBox2);
        plefnerTabPage.Controls.Add(inputTextBox2);
        plefnerTabPage.Controls.Add(button2);
        plefnerTabPage.Controls.Add(label4);
        plefnerTabPage.Controls.Add(keyPlTextBox1);
        plefnerTabPage.Controls.Add(cipherButton2);
        plefnerTabPage.Controls.Add(tableLayoutPanel1);
        plefnerTabPage.Location = new System.Drawing.Point(4, 34);
        plefnerTabPage.Name = "plefnerTabPage";
        plefnerTabPage.Padding = new System.Windows.Forms.Padding(3);
        plefnerTabPage.Size = new System.Drawing.Size(993, 646);
        plefnerTabPage.TabIndex = 1;
        plefnerTabPage.Text = "Плейфер";
        plefnerTabPage.UseVisualStyleBackColor = true;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 11F);
        label6.Location = new System.Drawing.Point(520, 278);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(270, 33);
        label6.TabIndex = 9;
        label6.Text = "Преобразованный текст";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 11F);
        label5.Location = new System.Drawing.Point(520, 19);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(270, 33);
        label5.TabIndex = 8;
        label5.Text = "Исходный текст";
        // 
        // button1
        // 
        button1.Font = new System.Drawing.Font("Segoe UI", 11F);
        button1.Location = new System.Drawing.Point(259, 143);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(228, 44);
        button1.TabIndex = 7;
        button1.Text = "Расшифровать";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click_1;
        // 
        // outTextBox2
        // 
        outTextBox2.Font = new System.Drawing.Font("Segoe UI", 11F);
        outTextBox2.Location = new System.Drawing.Point(520, 314);
        outTextBox2.Multiline = true;
        outTextBox2.Name = "outTextBox2";
        outTextBox2.Size = new System.Drawing.Size(445, 193);
        outTextBox2.TabIndex = 6;
        // 
        // inputTextBox2
        // 
        inputTextBox2.Font = new System.Drawing.Font("Segoe UI", 11F);
        inputTextBox2.Location = new System.Drawing.Point(520, 55);
        inputTextBox2.Multiline = true;
        inputTextBox2.Name = "inputTextBox2";
        inputTextBox2.Size = new System.Drawing.Size(445, 193);
        inputTextBox2.TabIndex = 5;
        // 
        // button2
        // 
        button2.Font = new System.Drawing.Font("Segoe UI", 11F);
        button2.Location = new System.Drawing.Point(158, 15);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(97, 37);
        button2.TabIndex = 4;
        button2.Text = "Файл";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 11F);
        label4.Location = new System.Drawing.Point(27, 15);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(112, 37);
        label4.TabIndex = 3;
        label4.Text = "Ключ";
        // 
        // keyPlTextBox1
        // 
        keyPlTextBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
        keyPlTextBox1.Location = new System.Drawing.Point(27, 55);
        keyPlTextBox1.Name = "keyPlTextBox1";
        keyPlTextBox1.Size = new System.Drawing.Size(227, 37);
        keyPlTextBox1.TabIndex = 2;
        // 
        // cipherButton2
        // 
        cipherButton2.Font = new System.Drawing.Font("Segoe UI", 11F);
        cipherButton2.Location = new System.Drawing.Point(25, 143);
        cipherButton2.Name = "cipherButton2";
        cipherButton2.Size = new System.Drawing.Size(228, 44);
        cipherButton2.TabIndex = 1;
        cipherButton2.Text = "Зашифровать";
        cipherButton2.UseVisualStyleBackColor = true;
        cipherButton2.Click += button1_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 11;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.Location = new System.Drawing.Point(27, 209);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 11;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new System.Drawing.Size(441, 414);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // openFileDialog1
        // 
        openFileDialog1.Filter = "(*.txt)|*.txt";
        openFileDialog1.ReadOnlyChecked = true;
        // 
        // keyPlTextBox2
        // 
        keyPlTextBox2.Font = new System.Drawing.Font("Segoe UI", 11F);
        keyPlTextBox2.Location = new System.Drawing.Point(259, 55);
        keyPlTextBox2.Name = "keyPlTextBox2";
        keyPlTextBox2.Size = new System.Drawing.Size(227, 37);
        keyPlTextBox2.TabIndex = 10;
        // 
        // keyPlTextBox4
        // 
        keyPlTextBox4.Font = new System.Drawing.Font("Segoe UI", 11F);
        keyPlTextBox4.Location = new System.Drawing.Point(260, 100);
        keyPlTextBox4.Name = "keyPlTextBox4";
        keyPlTextBox4.Size = new System.Drawing.Size(227, 37);
        keyPlTextBox4.TabIndex = 11;
        // 
        // keyPlTextBox3
        // 
        keyPlTextBox3.Font = new System.Drawing.Font("Segoe UI", 11F);
        keyPlTextBox3.Location = new System.Drawing.Point(26, 100);
        keyPlTextBox3.Name = "keyPlTextBox3";
        keyPlTextBox3.Size = new System.Drawing.Size(227, 37);
        keyPlTextBox3.TabIndex = 12;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(996, 685);
        Controls.Add(tabControl1);
        Text = "Шифры";
        tabControl1.ResumeLayout(false);
        vigenerTabPage.ResumeLayout(false);
        vigenerTabPage.PerformLayout();
        plefnerTabPage.ResumeLayout(false);
        plefnerTabPage.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox keyPlTextBox2;
    private System.Windows.Forms.TextBox keyPlTextBox4;
    private System.Windows.Forms.TextBox keyPlTextBox3;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Button cipherButton2;

    private System.Windows.Forms.TextBox inputTextBox2;

    private System.Windows.Forms.TextBox outTextBox2;

    private System.Windows.Forms.TextBox keyPlTextBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

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