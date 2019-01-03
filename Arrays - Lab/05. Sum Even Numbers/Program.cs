using System;
using System.Linq;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumOfEvenNumbers = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                if (currentNum % 2 == 0)
                {
                    sumOfEvenNumbers += currentNum;
                }
            }
            Console.WriteLine(sumOfEvenNumbers);
        }
    }
}
