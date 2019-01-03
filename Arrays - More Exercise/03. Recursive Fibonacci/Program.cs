using System;

namespace _03._RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long result = GetFibonacci(n);

            Console.WriteLine(result);
        }

        private static long GetFibonacci(int n)
        {
            long fib = 1;
            long fibPrev = 1;
            long fibPrevPrev = 1;

            for (int i = 2; i < n; i++)
            {
                fib = fibPrev + fibPrevPrev;
                fibPrevPrev = fibPrev;
                fibPrev = fib;
            }

            return fib;
        }
    }
}
