using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] result = words.Where(w => w.Length % 2 == 0).ToArray();

            foreach (string word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}
