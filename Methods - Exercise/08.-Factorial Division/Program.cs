using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            double result = Factorial(firstNum) / Factorial(secondNum);

            Console.WriteLine($"{result:f2}");
        }

        private static double Factorial(double number)
        {
            double fact = 1;

            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
