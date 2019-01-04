using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> symbolOccurances = new Dictionary<char, int>();

            foreach (char symbol in input.Where(s => s != ' '))
            {
                if (symbolOccurances.ContainsKey(symbol) == false)
                {
                    symbolOccurances.Add(symbol, 0);
                }
                symbolOccurances[symbol]++;
            }

            foreach (var kvp in symbolOccurances)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
