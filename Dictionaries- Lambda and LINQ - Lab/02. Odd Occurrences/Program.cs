using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .ToLower()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (occurrences.ContainsKey(word) == false)
                {
                    occurrences.Add(word, 0);
                }
                occurrences[word]++;
            }
            List<string> result = new List<string>();

            foreach (var kvp in occurrences.Where(x => x.Value % 2 != 0))
            {
                result.Add(kvp.Key);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
