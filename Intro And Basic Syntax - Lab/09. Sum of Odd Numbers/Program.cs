using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            short sum = 0;
            byte counter = 0;

            while (counter != n)
            {
                for (int currentNum = 1; currentNum < 100; currentNum++)
                {
                    if (currentNum % 2 != 0)
                    {
                        Console.WriteLine(currentNum);
                        sum += (byte)currentNum;
                        counter++;

                    }
                    if (counter == n)
                    {
                        break;
                    }
                }
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
