using System;

namespace ConvertMetersToKIlometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            double km = meters / 1000.0;

            Console.WriteLine($"{km:F2}");
        }
    }
}
