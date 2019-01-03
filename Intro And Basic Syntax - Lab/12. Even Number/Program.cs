using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenNumber = int.Parse(Console.ReadLine());

            while (true)
            {
                if (evenNumber % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(evenNumber)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
                evenNumber = int.Parse(Console.ReadLine());
            }
        }
    }
