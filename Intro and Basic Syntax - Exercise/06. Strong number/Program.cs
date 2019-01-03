using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfFactorialOfDigits = 0;
            int numberToCheck = number;

            while (numberToCheck > 0)
            {
                int factorial = 1;
                int digit = numberToCheck % 10;

                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }
                sumOfFactorialOfDigits += factorial;
                numberToCheck /= 10;
            }

            if (sumOfFactorialOfDigits == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
