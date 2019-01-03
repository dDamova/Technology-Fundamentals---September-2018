using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int topInteger = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTopInteger = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        isTopInteger = true;
                        topInteger = numbers[i];
                    }
                    else
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }

        }
    }
}
