using System;
using System.Linq;
using System.Text;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            string result = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];

                for (int j = 0; j < currentWord.Length; j++)
                {
                    result = string.Concat(result,currentWord);
                }
            }

            Console.WriteLine(result);
        }
    }
}
