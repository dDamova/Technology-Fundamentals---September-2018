using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();

            List<int> reversed = new List<int>();

            bool isEmpty = true;

            for (int i = input.Count - 1; i >= 0; i--)
            {
                if (input[i] > 0)
                {
                    reversed.Add(input[i]);
                    isEmpty = false;
                }
            }

            if (isEmpty)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(' ', reversed));
            }
        }
    }
}
