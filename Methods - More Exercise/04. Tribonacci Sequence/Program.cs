using System;
using System.Collections.Generic;
using System.Numerics;

namespace TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintsTribonacciSequence(num);
        }

        private static void PrintsTribonacciSequence(int num)
        {
            List<long> tribonacciSequence = new List<long>();

            tribonacciSequence.Add(1);
            tribonacciSequence.Add(1);
            tribonacciSequence.Add(2);

            if (num == 1)
            {
                Console.WriteLine(tribonacciSequence[0]);
                return;
            }
            else if (num == 2)
            {
                Console.WriteLine($"{tribonacciSequence[0]} {tribonacciSequence[1]}");
            }
            else if (num >= 3)
            {
                for (int i = 3; i < num; i++)
                {
                    long currentElement = tribonacciSequence[i - 1] + tribonacciSequence[i - 2] + tribonacciSequence[i - 3];

                    tribonacciSequence.Add(currentElement);
                }

                Console.WriteLine(string.Join(" ", tribonacciSequence));
            }
        }
    }
}
