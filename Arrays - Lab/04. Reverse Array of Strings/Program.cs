using System;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                string currentElement = arr[i];

                Console.Write($"{currentElement} ");
            }
            Console.WriteLine();
        }
    }
}
