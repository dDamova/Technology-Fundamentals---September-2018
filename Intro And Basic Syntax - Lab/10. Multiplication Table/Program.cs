using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            byte theInteger = byte.Parse(Console.ReadLine());

            for (int times = 1; times <= 10; times++)
            {
                short product = (short)(theInteger * times);

                Console.WriteLine($"{theInteger} X {times} = {product}");
            }
        }
    }
