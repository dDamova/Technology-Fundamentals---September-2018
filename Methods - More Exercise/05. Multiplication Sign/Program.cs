using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            PrintsSignOfProduct(num1, num2, num3);
        }

        private static void PrintsSignOfProduct(double num1, double num2, double num3)
        {
            if ((num1 > 0 && num2 > 2 && num3 < 0) || (num1 > 0 && num3 > 0 && num2 < 0) || (num2 > 0 && num3 > 0 && num1 < 0) || (num1 < 0 && num2 < 0 && num3 < 0))
            {
                Console.WriteLine("negative");
            }
            else if ((num1 > 0 && num2 > 0 && num3 > 0) || (num1 < 0 && num2 < 0 && num3 > 0) || (num1 < 0 && num3 < 0 && num2 > 0) || (num1 > 0 && num2 < 0 && num3 < 0))
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }
    }
}
