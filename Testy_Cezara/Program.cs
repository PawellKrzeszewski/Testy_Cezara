using static System.Net.Mime.MediaTypeNames;

namespace Testy_Cezara
{
    internal class Program
    {
        static List<char> alphabet = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];

        static void Main(string[] args)
        {
            while (true) 
            {
                GetVariables();
            }
        }

        private static void GetVariables()
        {
            Console.Write("Podaj tekst do zaszyfrowania: ");
            string text = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Podaj klucz do zaszyfrowania: ");
            int key = int.Parse(Console.ReadLine());

            Console.WriteLine(Engine(text, key)); ;
        }

        private static string Engine(string text, int key)
        {
            List<char> textList = new List<char>();
            List<char> encryptedTextList = new List<char>();

            TextToListConvert(text, textList);

            Encryption(key, encryptedTextList, textList);

            return ListToStringConvert(encryptedTextList);
        }

        private static void TextToListConvert(string text, List<char> textList)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                    textList.Add(' ');
                else
                    textList.Add(text[i]);
            }
        }

        private static void Encryption(int key, List<char> encryptedTextList, List<char> textList)
        {
            for (int i = 0; i < textList.Count(); i++)
            {
                if (textList[i] == ' ')
                    encryptedTextList.Add(' ');
                else
                {
                    int listIndex = alphabet.IndexOf(textList[i]);
                    encryptedTextList.Add(alphabet[((listIndex + key) % 26 + 26) % 26]);
                }
            }
        }

        private static string ListToStringConvert(List<char> encryptedTextList)
        {
            string encrypytedText = "";

            foreach (char c in encryptedTextList)
            {
                encrypytedText += c;
            }

            return encrypytedText;
        }
    }
}
