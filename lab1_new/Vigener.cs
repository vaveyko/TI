using System.Collections.Generic;

namespace lab1_new
{
    public class Vigener
{
    public const string MyAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

    private static Dictionary<char, int> _ascii = new Dictionary<char, int>{
        { 'а', 0 }, { 'б', 1 }, { 'в', 2 }, { 'г', 3 }, { 'д', 4 },
        { 'е', 5 }, { 'ё', 6 }, { 'ж', 7 }, { 'з', 8 }, { 'и', 9 },
        { 'й', 10 }, { 'к', 11 }, { 'л', 12 }, { 'м', 13 }, { 'н', 14 },
        { 'о', 15 }, { 'п', 16 }, { 'р', 17 }, { 'с', 18 }, { 'т', 19 },
        { 'у', 20 }, { 'ф', 21 }, { 'х', 22 }, { 'ц', 23 }, { 'ч', 24 },
        { 'ш', 25 }, { 'щ', 26 }, { 'ъ', 27 }, { 'ы', 28 }, { 'ь', 29 },
        { 'э', 30 }, { 'ю', 31 }, { 'я', 32 }
        
    };
    
    private static string DelSpaceStr(string str)
    {
        char[] buff = new char[str.Length];
        int buffInd = 0;
        
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != ' ')
            {
                buff[buffInd++] = str[i];
            }
        }
        
        return new string(buff, 0, buffInd);
    }
    
    public static string Cipherise(string currKey, string text)
    {
        string key = DelSpaceStr(currKey);
        char[] cipherText = new char[text.Length];
        int keyIndex = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if(text[i] != ' ')
            {
                cipherText[i] = MyAlphabet[(_ascii[text[i]] + _ascii[key[keyIndex]]) % MyAlphabet.Length];
                keyIndex = (++keyIndex) % key.Length;
            }
            else
            {
                cipherText[i] = text[i];
            }
        }
        return new string(cipherText);
    }

    public static string UnCipherise(string currKey, string cipherText)
    {
        string key = DelSpaceStr(currKey);
        char[] text = new char[cipherText.Length];
        
        int keyIndex = 0;
        for (int i = 0; i < cipherText.Length; i++)
        {
            if (cipherText[i] != ' ')
            {
                text[i] = MyAlphabet[(MyAlphabet.Length + _ascii[cipherText[i]] - _ascii[key[keyIndex]]) % MyAlphabet.Length];
                keyIndex = (++keyIndex) % key.Length;
            }
            else
            {
                text[i] = cipherText[i];
            }
        }
        
        return new string(text);
    }
}
}