namespace lab1;

public partial class Form1 : Form
{
    private void FillGrid(char[,] matrix)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (matrix[i, j] == 'i')
                {
                    tableLayoutPanel1.GetControlFromPosition(j, i).Text = matrix[i, j] + "/j";
                }
                else if (matrix[i, j] == 'j')
                {
                    tableLayoutPanel1.GetControlFromPosition(j, i).Text = matrix[i, j] + "/i";
                }
                else
                {
                    tableLayoutPanel1.GetControlFromPosition(j, i).Text = matrix[i, j].ToString();
                }
            }
        }
        for (int i = 6; i < 11; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (matrix[i-1, j] == 'i')
                {
                    tableLayoutPanel1.GetControlFromPosition(j, i).Text = matrix[i-1, j] + "/j";
                }
                else if (matrix[i-1, j] == 'j')
                {
                    tableLayoutPanel1.GetControlFromPosition(j, i).Text = matrix[i-1, j] + "/i";
                }
                else
                {
                    tableLayoutPanel1.GetControlFromPosition(j, i).Text = matrix[i-1, j].ToString();
                }
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 6; j < 11; j++)
            {
                if (matrix[i, j-1] == 'i')
                {
                    tableLayoutPanel1.GetControlFromPosition(j, i).Text = matrix[i, j-1] + "/j";
                }
                else if (matrix[i, j-1] == 'j')
                {
                    tableLayoutPanel1.GetControlFromPosition(j, i).Text = matrix[i, j-1] + "/i";
                }
                else
                {
                    tableLayoutPanel1.GetControlFromPosition(j, i).Text = matrix[i, j-1].ToString();
                }
            }
        }
        for (int i = 6; i < 11; i++)
        {
            for (int j = 6; j < 11; j++)
            {
                if (matrix[i-1, j-1] == 'i')
                {
                    tableLayoutPanel1.GetControlFromPosition(j, i).Text = matrix[i-1, j-1] + "/j";
                }
                else if (matrix[i-1, j-1] == 'j')
                {
                    tableLayoutPanel1.GetControlFromPosition(j, i).Text = matrix[i-1, j-1] + "/i";
                }
                else
                {
                    tableLayoutPanel1.GetControlFromPosition(j, i).Text = matrix[i-1, j-1].ToString();
                }
            }
        }
    }
    private string ClearStr(string str, string alphabet)
    {
        char[] buff = new char[str.Length];
        int buffInd = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (alphabet.Contains(str[i]) || str[i] == ' ')
            {
                buff[buffInd++] = str[i]; 
            }
        }
        return new string(buff, 0, buffInd);
    }
    public Form1()
    {
        InitializeComponent();
        for (int i = 0; i < 11; i++)
        {
            for (int j = 0; j < 11; j++)
            {
                Label myLabel = new Label();
                myLabel.AutoSize = true;
                tableLayoutPanel1.Controls.Add(myLabel, i, j);
            }
        }
    }

    private void cipherButton_Click(object sender, EventArgs e)
    {
        string key = ClearStr(keyTextBox.Text.ToLower(), Vigener.MyAlphabet);
        string text = ClearStr(inputTextBox.Text.ToLower(), Vigener.MyAlphabet);
        if(key.Length > 0 && text.Length > 0)
        {
            outputTextBox.Text = Vigener.Cipherise(key, text);
        }
        else
        {
            MessageBox.Show("Поле ключа и исходного текста не должны быть пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void unCipherButton_Click(object sender, EventArgs e)
    {
        string key = ClearStr(keyTextBox.Text.ToLower(), Vigener.MyAlphabet);
        string text = ClearStr(inputTextBox.Text.ToLower(), Vigener.MyAlphabet);
        if(key.Length > 0 && text.Length > 0)
        {
            outputTextBox.Text = Vigener.UnCipherise(key, text);
        }
        else
        {
            MessageBox.Show("Поле ключа и исходного текста не должны быть пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void openFileButton_Click(object sender, EventArgs e)
    {
        openFileDialog1.ShowDialog();
        if (openFileDialog1.FileName.Length > 0)
        {
            inputTextBox.Text = File.ReadAllText(openFileDialog1.FileName);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string key = ClearStr(keyPlTextBox.Text.ToLower(), Plefner.MyAlphabet);
        string text = ClearStr(inputTextBox2.Text.ToLower(), Plefner.MyAlphabet);
        if(key.Length > 0 && text.Length > 0)
        {
            FillGrid(Plefner.FillMatrix(key));
            outTextBox2.Text = Plefner.Cipherise(key,text);
        }
        else
        {
            MessageBox.Show("Поле ключа и исходного текста не должны быть пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }

    private void button2_Click(object sender, EventArgs e)
    {
        openFileDialog1.ShowDialog();
        if (openFileDialog1.FileName.Length > 0)
        {
            inputTextBox2.Text = File.ReadAllText(openFileDialog1.FileName);
        }
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        string key = ClearStr(keyPlTextBox.Text.ToLower(), Plefner.MyAlphabet);
        string text = ClearStr(inputTextBox2.Text.ToLower(), Plefner.MyAlphabet);
        if (key.Length > 0 && text.Length > 0)
        {
            FillGrid(Plefner.FillMatrix(key));
            outTextBox2.Text = Plefner.UnCipherise(key, text);
        }
        else
        {
            MessageBox.Show("Поле ключа и исходного текста не должны быть пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}