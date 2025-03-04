using System.Collections.Generic;

namespace lab1_new
{
    public class Plefner
{
    public const string MyAlphabet = "abcdefghijklmnopqrstuvwxyz";
    private static Dictionary<char, int[]> _firstMap = new Dictionary<char, int[]>();
    private static Dictionary<char, int[]> _secondMap = new Dictionary<char, int[]>();
    private static Dictionary<char, int[]> _thirdMap = new Dictionary<char, int[]>();
    private static Dictionary<char, int[]> _forthMap = new Dictionary<char, int[]>();
    
    private static Dictionary<char, int> _ascii = new Dictionary<char, int>
    {
        { 'a', 0 }, { 'b', 1 }, { 'c', 2 }, { 'd', 3 }, { 'e', 4 },
        { 'f', 5 }, { 'g', 6 }, { 'h', 7 }, { 'i', 8 }, { 'j', 9 },
        { 'k', 10 }, { 'l', 11 }, { 'm', 12 }, { 'n', 13 }, { 'o', 14 },
        { 'p', 15 }, { 'q', 16 }, { 'r', 17 }, { 's', 18 }, { 't', 19 },
        { 'u', 20 }, { 'v', 21 }, { 'w', 22 }, { 'x', 23 }, { 'y', 24 },
        { 'z', 25 }
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

    /*private static void CreateBuffMap(char[,] map)
    {
        _secondMap = new Dictionary<char, int[]>();
        _thirdMap = new Dictionary<char, int[]>();
        _forthMap = new Dictionary<char, int[]>();
        foreach (char curKey in _firstMap.Keys)
        {
            
            _secondMap.Add(curKey, [_firstMap[curKey][1], 4 - (_firstMap[curKey][0] - 5)]);
            _thirdMap.Add(curKey, [4 - (_firstMap[curKey][1] - 5), _firstMap[curKey][0]]);
            _forthMap.Add(curKey, [4 - (_firstMap[curKey][0] - 5), 4 - (_firstMap[curKey][1] - 5)]);
        }
    }*/

    private static char[,] FillBuffMatrix(string key, ref Dictionary<char, int[]> map)
    {
        char[,] buffMatrix = new char[5, 5];
        int[] flagArr = new int[26];
        map = new Dictionary<char, int[]>();
        
        for (int i = 0; i < flagArr.Length; i++)
        {
            flagArr[i] = 0;
        }

        int keyInd = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (keyInd < key.Length && flagArr[_ascii[key[keyInd]]] != 1)
                {
                    buffMatrix[i, j] = key[keyInd];
                    flagArr[_ascii[key[keyInd]]] = 1;
                    map.Add(key[keyInd], new int[] { i, j });
                    if (flagArr[_ascii['j']] == 1 || flagArr[_ascii['i']] == 1)
                    {
                        flagArr[_ascii['j']] = 1;
                        flagArr[_ascii['i']] = 1;
                    }
                }
                else
                {
                    int h = -1;
                    while (h < flagArr.Length && flagArr[++h] == 1) ;
                    if (h < flagArr.Length)
                    {
                        buffMatrix[i, j] = MyAlphabet[h];
                        flagArr[h] = 1;
                        map.Add(MyAlphabet[h], new int[] { i, j });
                        if (flagArr[_ascii['j']] == 1 || flagArr[_ascii['i']] == 1)
                        {
                            flagArr[_ascii['j']] = 1;
                            flagArr[_ascii['i']] = 1;
                        }
                    }
                }
                keyInd++;
            }
        }

        if (map.ContainsKey('j'))
        {
            map.Add('i', map['j']);
        }
        else if (map.ContainsKey('i'))
        {
            map.Add('j', map['i']);
        }

        return buffMatrix;
    }
    public static char[,] FillMatrix(string key1, string key2, string key3, string key4)
    {
        char[,] keyMatrix = new char[10, 10];
        char[,] first = FillBuffMatrix(DelSpaceStr(key1), ref _firstMap);
        char[,] second = FillBuffMatrix(DelSpaceStr(key2), ref _secondMap);
        char[,] third = FillBuffMatrix(DelSpaceStr(key3), ref _thirdMap);
        char[,] forth = FillBuffMatrix(DelSpaceStr(key4), ref _forthMap);
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                keyMatrix[i, j] = first[i, j];
            }
        }
        
        for (int i = 0; i < 5; i++)
        {
            for (int j = 5; j < 10; j++)
            {
                keyMatrix[i, j] = second[i, j-5];
            }
        }
        
        for (int i = 5; i < 10; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                keyMatrix[i, j] = third[i-5, j];
            }
        }
        
        for (int i = 5; i < 10; i++)
        {
            for (int j = 5; j < 10; j++)
            {
                keyMatrix[i, j] = forth[i - 5, j - 5];
            }
        }

        return keyMatrix;
    }

    private static string PrepareText(string curText)
    {
        string text = DelSpaceStr(curText);
        char[] buff = new char[text.Length*2];
        int buffInd = 0;
        for (int i = 0; i < text.Length-1; i++)
        {
            if ((text[i] == text[i + 1]) || (text[i] == 'j' && text[i+1] == 'i') || (text[i+1] == 'j' && text[i] == 'i'))
            {
                buff[buffInd++] = text[i];
                buff[buffInd++] = 'z';
            }
            else
            {
                buff[buffInd++] = text[i];
            }
        }
        buff[buffInd] = text[text.Length-1];

        if (buffInd % 2 == 0)
        {
            buff[++buffInd] = 'z';
        }
        return new string(buff, 0, buffInd+1);
    }
    
    public static string Cipherise(string key1, string key2, string key3, string key4, string text)
    {
        char[,] keyMatrix = FillMatrix(key1, key2, key3, key4);
        char[] cipherText = new char[text.Length*2];

        string newText = PrepareText(text);
        for (int i = 0; i < newText.Length/2; i++)
        {
            cipherText[2*i] = keyMatrix[_firstMap[newText[2*i]][0], _forthMap[newText[2*i+1]][1]+5];
            cipherText[2*i+1] = keyMatrix[_forthMap[newText[2*i+1]][0]+5, _firstMap[newText[2*i]][1]];
        }

        return new string(cipherText);
    }
    
    public static string UnCipherise(string key1, string key2, string key3, string key4, string newText)
    {
        char[,] keyMatrix = FillMatrix(key1, key2, key3, key4);
        char[] cipherText = new char[newText.Length*2];

        //string newText = DelSpaceStr(text);
        for (int i = 0; i < newText.Length/2; i++)
        {
            cipherText[2*i] = keyMatrix[_secondMap[newText[2*i]][0], _thirdMap[newText[2*i+1]][1]];
            cipherText[2*i+1] = keyMatrix[_thirdMap[newText[2*i+1]][0]+5, _secondMap[newText[2*i]][1]+5];
        }

        int ind = 1;
        while (ind < cipherText.Length - 1 && cipherText[ind] != '\0')
        {
            if (cipherText[ind - 1] == cipherText[ind + 1] && cipherText[ind] == 'z')
            {
                int buffInd = ind;
                while(buffInd < cipherText.Length-1 && cipherText[buffInd] != '\0')
                {
                    cipherText[buffInd] = cipherText[buffInd+1];
                    buffInd++;
                }
            }

            ind++;
        }

        return new string(cipherText);
    }
}
}