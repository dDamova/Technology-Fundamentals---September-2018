using System;
using System.Linq;
using System.Numerics;

namespace _02._FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                BigInteger[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();

                long sumOfNumbers = 0;

                if (numbers[0] > numbers[1])
                {
                    while (numbers[0] != 0)
                    {
                        sumOfNumbers += Math.Abs((long)(numbers[0] % 10));
                        numbers[0] /= 10;
                    }
                }
                else
                {
                    while (numbers[1] != 0)
                    {
                        sumOfNumbers += Math.Abs((long)(numbers[1] % 10));
                        numbers[1] /= 10;
                    }
                }
                Console.WriteLine(sumOfNumbers);
            }
        }
    }
}
