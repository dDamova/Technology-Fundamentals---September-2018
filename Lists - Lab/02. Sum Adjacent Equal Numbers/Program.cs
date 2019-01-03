using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> numbers = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

            int i = 0;

            while (i < numbers.Count - 1)
            {
                if (numbers[i] == numbers[i + 1])
                {

                    double num = numbers[i] + numbers[i + 1];
                    numbers.Insert(i, num);
                    numbers.RemoveAt(i + 1);
                    numbers.RemoveAt(i + 1);
                    i = 0;
                    continue;
                }
                i++;
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
