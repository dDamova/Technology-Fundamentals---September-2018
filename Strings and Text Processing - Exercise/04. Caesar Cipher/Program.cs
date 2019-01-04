using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder encryptedText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char encryptedSymbol = (char)(text[i] + 3);
                encryptedText.Append(encryptedSymbol);
            }

            Console.WriteLine(encryptedText);
        }
    }
}
