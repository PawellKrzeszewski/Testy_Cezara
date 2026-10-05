using System;
using System.Collections.Generic;
using System.Text;

namespace Testy_Cezara_Obiektowo
{
    public class ConsoleReader
    {
        public (string text, int key) ReadCipherData()
        {
            Console.Write("Podaj tekst do zaszyfrowania: ");
            string text = Console.ReadLine();

            Console.Write("Podaj klucz do zaszyfrowania: ");

            if (!int.TryParse(Console.ReadLine(), out int key))
            {
                Console.WriteLine("Błąd: Klucz musi być liczbą!\n");
                return (string.Empty, -1);
            }

            return (text, key);
        }
    }
}
