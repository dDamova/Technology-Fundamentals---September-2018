using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                words.Add(input);

                input = Console.ReadLine();
            }

            for (int i = 0; i < words.Count; i++)
            {
                string word = words[i];
                string reversed = string.Empty;

                for (int j = word.Length - 1; j >= 0; j--)
                {
                    reversed += word[j];
                }

                Console.WriteLine($"{word} = {reversed}");
            }
        }
    }
}
