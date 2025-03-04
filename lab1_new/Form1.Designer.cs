namespace lab1_new
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.keyTextBox = new System.Windows.Forms.TextBox();
        this.cipherButton = new System.Windows.Forms.Button();
        this.unCipherButton = new System.Windows.Forms.Button();
        this.inputTextBox = new System.Windows.Forms.TextBox();
        this.outputTextBox = new System.Windows.Forms.TextBox();
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.vigenerTabPage = new System.Windows.Forms.TabPage();
        this.button4 = new System.Windows.Forms.Button();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.openFileButton = new System.Windows.Forms.Button();
        this.plefnerTabPage = new System.Windows.Forms.TabPage();
        this.button3 = new System.Windows.Forms.Button();
        this.keyPlTextBox3 = new System.Windows.Forms.TextBox();
        this.keyPlTextBox4 = new System.Windows.Forms.TextBox();
        this.keyPlTextBox2 = new System.Windows.Forms.TextBox();
        this.label6 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.button1 = new System.Windows.Forms.Button();
        this.outTextBox2 = new System.Windows.Forms.TextBox();
        this.inputTextBox2 = new System.Windows.Forms.TextBox();
        this.button2 = new System.Windows.Forms.Button();
        this.label4 = new System.Windows.Forms.Label();
        this.keyPlTextBox1 = new System.Windows.Forms.TextBox();
        this.cipherButton2 = new System.Windows.Forms.Button();
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
        this.tabControl1.SuspendLayout();
        this.vigenerTabPage.SuspendLayout();
        this.plefnerTabPage.SuspendLayout();
        this.SuspendLayout();
        // 
        // keyTextBox
        // 
        this.keyTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.keyTextBox.Location = new System.Drawing.Point(79, 124);
        this.keyTextBox.Name = "keyTextBox";
        this.keyTextBox.Size = new System.Drawing.Size(253, 37);
        this.keyTextBox.TabIndex = 0;
        // 
        // cipherButton
        // 
        this.cipherButton.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.cipherButton.Location = new System.Drawing.Point(79, 179);
        this.cipherButton.Name = "cipherButton";
        this.cipherButton.Size = new System.Drawing.Size(253, 42);
        this.cipherButton.TabIndex = 1;
        this.cipherButton.Text = "Зашифровать";
        this.cipherButton.UseVisualStyleBackColor = true;
        this.cipherButton.Click += new System.EventHandler(this.cipherButton_Click);
        // 
        // unCipherButton
        // 
        this.unCipherButton.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.unCipherButton.Location = new System.Drawing.Point(79, 236);
        this.unCipherButton.Name = "unCipherButton";
        this.unCipherButton.Size = new System.Drawing.Size(253, 42);
        this.unCipherButton.TabIndex = 2;
        this.unCipherButton.Text = "Расшифровать";
        this.unCipherButton.UseVisualStyleBackColor = true;
        this.unCipherButton.Click += new System.EventHandler(this.unCipherButton_Click);
        // 
        // inputTextBox
        // 
        this.inputTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.inputTextBox.Location = new System.Drawing.Point(453, 113);
        this.inputTextBox.Multiline = true;
        this.inputTextBox.Name = "inputTextBox";
        this.inputTextBox.Size = new System.Drawing.Size(458, 185);
        this.inputTextBox.TabIndex = 3;
        // 
        // outputTextBox
        // 
        this.outputTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.outputTextBox.Location = new System.Drawing.Point(453, 348);
        this.outputTextBox.Multiline = true;
        this.outputTextBox.Name = "outputTextBox";
        this.outputTextBox.Size = new System.Drawing.Size(458, 197);
        this.outputTextBox.TabIndex = 4;
        this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
        // 
        // tabControl1
        // 
        this.tabControl1.Controls.Add(this.vigenerTabPage);
        this.tabControl1.Controls.Add(this.plefnerTabPage);
        this.tabControl1.Location = new System.Drawing.Point(-3, 1);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(1001, 684);
        this.tabControl1.TabIndex = 5;
        // 
        // vigenerTabPage
        // 
        this.vigenerTabPage.Controls.Add(this.button4);
        this.vigenerTabPage.Controls.Add(this.label3);
        this.vigenerTabPage.Controls.Add(this.label2);
        this.vigenerTabPage.Controls.Add(this.label1);
        this.vigenerTabPage.Controls.Add(this.openFileButton);
        this.vigenerTabPage.Controls.Add(this.outputTextBox);
        this.vigenerTabPage.Controls.Add(this.unCipherButton);
        this.vigenerTabPage.Controls.Add(this.cipherButton);
        this.vigenerTabPage.Controls.Add(this.inputTextBox);
        this.vigenerTabPage.Controls.Add(this.keyTextBox);
        this.vigenerTabPage.Location = new System.Drawing.Point(4, 29);
        this.vigenerTabPage.Name = "vigenerTabPage";
        this.vigenerTabPage.Padding = new System.Windows.Forms.Padding(3);
        this.vigenerTabPage.Size = new System.Drawing.Size(993, 651);
        this.vigenerTabPage.TabIndex = 0;
        this.vigenerTabPage.Text = "Виженер";
        this.vigenerTabPage.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        this.button4.Enabled = false;
        this.button4.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.button4.Location = new System.Drawing.Point(453, 562);
        this.button4.Name = "button4";
        this.button4.Size = new System.Drawing.Size(224, 43);
        this.button4.TabIndex = 9;
        this.button4.Text = "Файл сохранить";
        this.button4.UseVisualStyleBackColor = true;
        this.button4.Click += new System.EventHandler(this.button4_Click);
        // 
        // label3
        // 
        this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.label3.Location = new System.Drawing.Point(453, 313);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(303, 32);
        this.label3.TabIndex = 8;
        this.label3.Text = "Преобразованный текст";
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.label2.Location = new System.Drawing.Point(453, 75);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(250, 32);
        this.label2.TabIndex = 7;
        this.label2.Text = "Обычный текст";
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.label1.Location = new System.Drawing.Point(79, 64);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(124, 43);
        this.label1.TabIndex = 6;
        this.label1.Text = "Ключ";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // openFileButton
        // 
        this.openFileButton.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.openFileButton.Location = new System.Drawing.Point(209, 64);
        this.openFileButton.Name = "openFileButton";
        this.openFileButton.Size = new System.Drawing.Size(123, 43);
        this.openFileButton.TabIndex = 5;
        this.openFileButton.Text = "Файл";
        this.openFileButton.UseVisualStyleBackColor = true;
        this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
        // 
        // plefnerTabPage
        // 
        this.plefnerTabPage.Controls.Add(this.button3);
        this.plefnerTabPage.Controls.Add(this.keyPlTextBox3);
        this.plefnerTabPage.Controls.Add(this.keyPlTextBox4);
        this.plefnerTabPage.Controls.Add(this.keyPlTextBox2);
        this.plefnerTabPage.Controls.Add(this.label6);
        this.plefnerTabPage.Controls.Add(this.label5);
        this.plefnerTabPage.Controls.Add(this.button1);
        this.plefnerTabPage.Controls.Add(this.outTextBox2);
        this.plefnerTabPage.Controls.Add(this.inputTextBox2);
        this.plefnerTabPage.Controls.Add(this.button2);
        this.plefnerTabPage.Controls.Add(this.label4);
        this.plefnerTabPage.Controls.Add(this.keyPlTextBox1);
        this.plefnerTabPage.Controls.Add(this.cipherButton2);
        this.plefnerTabPage.Controls.Add(this.tableLayoutPanel1);
        this.plefnerTabPage.Location = new System.Drawing.Point(4, 29);
        this.plefnerTabPage.Name = "plefnerTabPage";
        this.plefnerTabPage.Padding = new System.Windows.Forms.Padding(3);
        this.plefnerTabPage.Size = new System.Drawing.Size(993, 651);
        this.plefnerTabPage.TabIndex = 1;
        this.plefnerTabPage.Text = "Плейфер";
        this.plefnerTabPage.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        this.button3.Enabled = false;
        this.button3.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.button3.Location = new System.Drawing.Point(520, 524);
        this.button3.Name = "button3";
        this.button3.Size = new System.Drawing.Size(242, 44);
        this.button3.TabIndex = 13;
        this.button3.Text = "Файл сохранить";
        this.button3.UseVisualStyleBackColor = true;
        this.button3.Click += new System.EventHandler(this.button3_Click);
        // 
        // keyPlTextBox3
        // 
        this.keyPlTextBox3.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.keyPlTextBox3.Location = new System.Drawing.Point(27, 100);
        this.keyPlTextBox3.Name = "keyPlTextBox3";
        this.keyPlTextBox3.Size = new System.Drawing.Size(227, 37);
        this.keyPlTextBox3.TabIndex = 12;
        // 
        // keyPlTextBox4
        // 
        this.keyPlTextBox4.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.keyPlTextBox4.Location = new System.Drawing.Point(259, 100);
        this.keyPlTextBox4.Name = "keyPlTextBox4";
        this.keyPlTextBox4.Size = new System.Drawing.Size(227, 37);
        this.keyPlTextBox4.TabIndex = 11;
        // 
        // keyPlTextBox2
        // 
        this.keyPlTextBox2.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.keyPlTextBox2.Location = new System.Drawing.Point(259, 55);
        this.keyPlTextBox2.Name = "keyPlTextBox2";
        this.keyPlTextBox2.Size = new System.Drawing.Size(227, 37);
        this.keyPlTextBox2.TabIndex = 10;
        // 
        // label6
        // 
        this.label6.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.label6.Location = new System.Drawing.Point(520, 278);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(270, 33);
        this.label6.TabIndex = 9;
        this.label6.Text = "Преобразованный текст";
        // 
        // label5
        // 
        this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.label5.Location = new System.Drawing.Point(520, 19);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(270, 33);
        this.label5.TabIndex = 8;
        this.label5.Text = "Исходный текст";
        // 
        // button1
        // 
        this.button1.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.button1.Location = new System.Drawing.Point(259, 143);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(228, 44);
        this.button1.TabIndex = 7;
        this.button1.Text = "Расшифровать";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click_1);
        // 
        // outTextBox2
        // 
        this.outTextBox2.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.outTextBox2.Location = new System.Drawing.Point(520, 314);
        this.outTextBox2.Multiline = true;
        this.outTextBox2.Name = "outTextBox2";
        this.outTextBox2.Size = new System.Drawing.Size(445, 193);
        this.outTextBox2.TabIndex = 6;
        this.outTextBox2.TextChanged += new System.EventHandler(this.outTextBox2_TextChanged);
        // 
        // inputTextBox2
        // 
        this.inputTextBox2.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.inputTextBox2.Location = new System.Drawing.Point(520, 55);
        this.inputTextBox2.Multiline = true;
        this.inputTextBox2.Name = "inputTextBox2";
        this.inputTextBox2.Size = new System.Drawing.Size(445, 193);
        this.inputTextBox2.TabIndex = 5;
        // 
        // button2
        // 
        this.button2.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.button2.Location = new System.Drawing.Point(158, 15);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(97, 37);
        this.button2.TabIndex = 4;
        this.button2.Text = "Файл";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // label4
        // 
        this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.label4.Location = new System.Drawing.Point(27, 15);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(112, 37);
        this.label4.TabIndex = 3;
        this.label4.Text = "Ключ";
        // 
        // keyPlTextBox1
        // 
        this.keyPlTextBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.keyPlTextBox1.Location = new System.Drawing.Point(27, 55);
        this.keyPlTextBox1.Name = "keyPlTextBox1";
        this.keyPlTextBox1.Size = new System.Drawing.Size(227, 37);
        this.keyPlTextBox1.TabIndex = 2;
        // 
        // cipherButton2
        // 
        this.cipherButton2.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.cipherButton2.Location = new System.Drawing.Point(27, 143);
        this.cipherButton2.Name = "cipherButton2";
        this.cipherButton2.Size = new System.Drawing.Size(228, 44);
        this.cipherButton2.TabIndex = 1;
        this.cipherButton2.Text = "Зашифровать";
        this.cipherButton2.UseVisualStyleBackColor = true;
        this.cipherButton2.Click += new System.EventHandler(this.button1_Click);
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 11;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 209);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 11;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        this.tableLayoutPanel1.Size = new System.Drawing.Size(441, 414);
        this.tableLayoutPanel1.TabIndex = 0;
        // 
        // openFileDialog1
        // 
        this.openFileDialog1.Filter = "(*.txt)|*.txt";
        this.openFileDialog1.ReadOnlyChecked = true;
        // 
        // saveFileDialog1
        // 
        this.saveFileDialog1.Filter = "(*.txt)|*.txt";
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(996, 685);
        this.Controls.Add(this.tabControl1);
        this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        this.Name = "Form1";
        this.Text = "Шифры";
        this.tabControl1.ResumeLayout(false);
        this.vigenerTabPage.ResumeLayout(false);
        this.vigenerTabPage.PerformLayout();
        this.plefnerTabPage.ResumeLayout(false);
        this.plefnerTabPage.PerformLayout();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Button button3;

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
}