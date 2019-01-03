using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            byte theInteger = byte.Parse(Console.ReadLine());
            byte startMultiplier = byte.Parse(Console.ReadLine());

            if (startMultiplier <= 10)
            {
                for (int times = startMultiplier; times <= 10; times++)
                {
                    short product = (short)(theInteger * times);

                    Console.WriteLine($"{theInteger} X {times} = {product}");
                }
            }
            else
            {
                short product = (short)(theInteger * startMultiplier);


                Console.WriteLine($"{theInteger} X {startMultiplier} = {product}");
            }
        }
    }
}
