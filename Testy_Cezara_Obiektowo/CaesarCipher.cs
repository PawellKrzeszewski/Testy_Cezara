using System;
using System.Collections.Generic;
using System.Text;

namespace Testy_Cezara_Obiektowo
{

    public class CaesarCipher : ICipher
    {
        private readonly int _key;

        public CaesarCipher(int key)
        {
            _key = key;
        }

        public string Encrypt(string text)
        {
            List<char> encryptedTextList = new();
            foreach (char character in text)
            {
                if (character == ' ')
                    encryptedTextList.Add(' ');
                else
                {
                    int listIndex = character - 'a';
                    encryptedTextList.Add((char)((((listIndex + _key) % 26 + 26) % 26) + 'a'));
                }
            }
            return string.Concat(encryptedTextList);
        }
    }
}
