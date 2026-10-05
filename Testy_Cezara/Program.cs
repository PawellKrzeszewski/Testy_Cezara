namespace Testy_Cezara
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                (string text, int key) = ReadUserInput();

                Console.WriteLine(RunCeaser(text, key));
            }
        }

        private static (string, int) ReadUserInput()
        {
            Console.Write("Podaj tekst do zaszyfrowania: ");
            string text = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Podaj klucz do zaszyfrowania: ");
            int key = int.Parse(Console.ReadLine());

            return (text, key);
        }

        public static string RunCeaser(string text, int key)
        {
            List<char> textList = new(text);

            List<char> encryptedList = ApplyCaesarAlgorithm(key, textList);

            return string.Concat(encryptedList);
        }

        private static List<char> ApplyCaesarAlgorithm(int key, List<char> textList)
        {
            List<char> encryptedTextList = new();

            foreach (char character in textList)
            {
                if (character == ' ')
                    encryptedTextList.Add(' ');
                else
                {
                    int listIndex = character - 'a';
                    encryptedTextList.Add((char)((((listIndex + key) % 26 + 26) % 26) + 'a'));
                }
            }

            return encryptedTextList;
        }
    }
}