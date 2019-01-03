using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int resultNum = numbers[i] + numbers[numbers.Count - 1 - i];
                result.Add(resultNum);
            }
            if (numbers.Count % 2 != 0)
            {
                result.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
