using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNumber = bomb[0];
            int bombPower = bomb[1];

            for (int index = 0; index < numbers.Count; index++)
            {
                if (numbers[index] == bombNumber)
                {
                    numbers[index] = 0;

                    if (index >= bombPower)
                    {
                        for (int i = index - bombPower; i < index; i++)
                        {
                            numbers[i] = 0;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < index; i++)
                        {
                            numbers[i] = 0;
                        }
                    }
                    if (numbers.Count > index + bombPower)
                    {
                        for (int i = index + 1; i <= index + bombPower; i++)
                        {
                            numbers[i] = 0;
                        }
                    }
                    else
                    {
                        for (int i = index + 1; i < numbers.Count; i++)
                        {
                            numbers[i] = 0;
                        }
                    }
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
