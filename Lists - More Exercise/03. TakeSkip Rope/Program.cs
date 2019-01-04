using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<char> nonNumbers = new List<char>();

            foreach (char symbol in input)
            {
                if (char.IsDigit(symbol))
                {
                    numbers.Add(int.Parse(symbol.ToString()));
                }
                else
                {
                    nonNumbers.Add(symbol);
                }
            }

            List<int> take = new List<int>();
            List<int> skip = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    take.Add(numbers[i]);
                }
                else
                {
                    skip.Add(numbers[i]);
                }
            }

            string result = "";
            int total = 0;
            for (int i = 0; i < take.Count; i++)
            {
                int takeCount = take[i];
                int skipCount = skip[i];

                result += new string(nonNumbers.Skip(total).Take(takeCount).ToArray());
                total += skipCount + takeCount;
            }
            Console.WriteLine(result);
        }
    }
}
