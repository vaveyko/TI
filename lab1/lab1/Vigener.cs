namespace lab1;

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
    public static string Cipherise(string key, string text)
    {
        char[] cipherText = new char[text.Length];
        int keyIndex = 0;
        for (int i = 0; i < text.Length; i++)
        {
            cipherText[i] = MyAlphabet[(_ascii[text[i]] + _ascii[key[keyIndex]]) % MyAlphabet.Length];
            
            keyIndex = (++keyIndex) % key.Length;
        }
        return new string(cipherText);
    }
}