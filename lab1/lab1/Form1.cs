namespace lab1;

public partial class Form1 : Form
{
    private string ClearStr(string str)
    {
        char[] buff = new char[str.Length];
        int buffInd = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (Vigener.MyAlphabet.Contains(str[i]) || str[i] == ' ')
            {
                buff[buffInd++] = str[i]; 
            }
        }
        return new string(buff, 0, buffInd);
    }
    public Form1()
    {
        InitializeComponent();
    }

    private void cipherButton_Click(object sender, EventArgs e)
    {
        outputTextBox.Text = Vigener.Cipherise(ClearStr(keyTextBox.Text), ClearStr(inputTextBox.Text));
    }

    private void unCipherButton_Click(object sender, EventArgs e)
    {
        outputTextBox.Text = Vigener.UnCipherise(ClearStr(keyTextBox.Text), ClearStr(inputTextBox.Text));
    }

    private void openFileButton_Click(object sender, EventArgs e)
    {
        openFileDialog1.ShowDialog();
        if (openFileDialog1.FileName.Length > 0)
        {
            inputTextBox.Text = File.ReadAllText(openFileDialog1.FileName);
        }
    }
}