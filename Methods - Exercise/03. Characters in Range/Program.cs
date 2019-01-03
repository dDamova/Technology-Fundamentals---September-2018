using System;
using System.Collections.Generic;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());

            if (startChar > endChar)
            {
                char temp = startChar;
                startChar = endChar;
                endChar = temp;
            }

            PrintsCharactersInRAnge(startChar, endChar);
        }

        private static void PrintsCharactersInRAnge(char startChar, char endChar)
        {
            List<char> charactersBetween = new List<char>();

            for (char i = (char)(startChar + 1); i < endChar; i++)
            {
                charactersBetween.Add(i);
            }

            Console.WriteLine(string.Join(" ", charactersBetween));
        }
    }
}
