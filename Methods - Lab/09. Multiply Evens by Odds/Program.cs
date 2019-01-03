using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = GetMultipleOfEvenAndOdds(number);

            Console.WriteLine(result);
        }

        private static int GetSumOfEvenDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;

            while (number != 0)
            {
                int currentDigit = number % 10;

                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;
                }

                number /= 10;
            }

            return sum;
        }

        private static int GetSumOfOddDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;

            while (number != 0)
            {
                int currentDigit = number % 10;

                if (currentDigit % 2 != 0)
                {
                    sum += currentDigit;
                }

                number /= 10;
            }

            return sum;
        }

        private static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }
    }
}
