using System;
using System.Linq;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            PrintsMiddleCharacters(str);
        }

        private static void PrintsMiddleCharacters(string str)
        {
            string middleCharacter = "";

            if (str.Length % 2 != 0)
            {
                middleCharacter = str[str.Length / 2].ToString();
            }
            else
            {
                middleCharacter = $"{str[str.Length / 2 - 1]}{str[str.Length / 2]}";
            }

            Console.WriteLine(middleCharacter);
        }
    }
}
