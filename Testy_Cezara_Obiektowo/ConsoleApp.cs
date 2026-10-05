using System;
using System.Collections.Generic;
using System.Text;

namespace Testy_Cezara_Obiektowo
{
    public class ConsoleApp
    {
        private readonly ConsoleReader _reader;
        private readonly ConsoleWriter _writer;

        public ConsoleApp()
        {
            _reader = new();
            _writer = new();
        }
        
        public void Run()
        {
            while (true)
            {
                (string text, int key) = _reader.ReadCipherData();

                ICipher cipher = new CaesarCipher(key);
                string result = cipher.Encrypt(text);

                _writer.PrintResult(result);
            }
        }
    }
}
