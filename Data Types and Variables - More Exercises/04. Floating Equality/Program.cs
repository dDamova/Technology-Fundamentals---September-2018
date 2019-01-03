using System;

namespace _04._FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            double diff = Math.Abs(a - b);

            Console.WriteLine(diff < eps);
        }
    }
}
