namespace lab1;

public partial class Form1 : Form
{
    private string ClearStr(string str)
    {
        char[] buff = new char[str.Length];
        int buffInd = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (Vigener.MyAlphabet.Contains(str[i]))
            {
                buff[buffInd++] = str[i]; 
            }
        }
        return new string(buff);
    }
    public Form1()
    {
        InitializeComponent();
    }
}