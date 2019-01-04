using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomizeWords_ObjectsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Random random = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                var ri = random.Next(0, words.Count);

                string temp = words[i];
                words[i] = words[ri];
                words[ri] = temp;
            }
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
