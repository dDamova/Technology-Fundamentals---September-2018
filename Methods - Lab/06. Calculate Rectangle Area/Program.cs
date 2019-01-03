using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());

            double result = GetRectangleArea(width, heigth);

            Console.WriteLine(result);
        }

        private static double GetRectangleArea(double width, double heigth)
        {
            return width * heigth;
        }
    }
}
