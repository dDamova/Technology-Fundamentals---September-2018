using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int result = GetMin(firstNum, secondNum, thirdNum);

            Console.WriteLine(result);
        }

        private static int GetMin(int a, int b, int c)
        {
            int min = 0;

            min = Math.Min(Math.Min(a, b), c);

            return min;
        }
    }
}
