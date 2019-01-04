using System;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string firstWord = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (words.ContainsKey(firstWord) == false)
                {
                    words.Add(firstWord, new List<string>());
                }

                words[firstWord].Add(synonym);
            }

            foreach (var kvp in words)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
