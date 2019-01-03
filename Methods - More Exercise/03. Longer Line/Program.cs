using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double lenght1 = GetLengthOfLine(x1, y1, x2, y2);
            double lenght2 = GetLengthOfLine(x3, y3, x4, y4);

            if (lenght1 >= lenght2)
            {
                double distance1 = GetdistanceBetweenPointAndCenter(x1, y1);
                double distance2 = GetdistanceBetweenPointAndCenter(x2, y2);

                if (distance1 <= distance2)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else 
            {
                double distance3 = GetdistanceBetweenPointAndCenter(x3, y3);
                double distance4 = GetdistanceBetweenPointAndCenter(x4, y4);

                if (distance3 <= distance4)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        private static double GetdistanceBetweenPointAndCenter(double x, double y)
        {
            double distance = Math.Sqrt(x * x + y * y);

            return distance;
        }

        private static double GetLengthOfLine(double x1, double y1, double x2, double y2)
        {
            double lenght = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            return lenght;
        }
    }
}
