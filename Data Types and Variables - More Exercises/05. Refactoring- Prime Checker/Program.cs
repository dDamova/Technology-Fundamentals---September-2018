using System;

namespace _05._RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int number = 2; number <= n; number++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor < number; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{number} -> {isPrime.ToString().ToLower()}");
            }
        }
    }
}
