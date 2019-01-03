using System;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine(Math.Round(area,12));
        }
    }
}
