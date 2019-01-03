using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double currentNumber = numbers[i];

                Console.WriteLine($"{currentNumber} => {Math.Round(currentNumber, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
