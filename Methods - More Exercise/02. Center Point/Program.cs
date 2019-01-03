using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            if (DistanceBetweenPointAndCenter(x1, y1) == DistanceBetweenPointAndCenter(x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (DistanceBetweenPointAndCenter(x1, y1) < DistanceBetweenPointAndCenter(x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        private static double DistanceBetweenPointAndCenter(double x1, double y1)
        {
            double distance = Math.Sqrt(x1 * x1 + y1 * y1);

            return distance;
        }
    }
}
