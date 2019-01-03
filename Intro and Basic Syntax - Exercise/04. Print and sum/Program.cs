using System;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int currentNum = startNumber; currentNum <= endNumber; currentNum++)
            {
                Console.Write($"{currentNum} ");
                sum += currentNum;
            }
            Console.WriteLine();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
