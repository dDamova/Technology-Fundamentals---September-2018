using System;

namespace PrintTriagle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintUpperHalf(n);
            PrintSecondHalf(n);
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static void PrintUpperHalf(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(1, i);
            }
        }

        static void PrintSecondHalf(int n)
        {
            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }


    }
}
