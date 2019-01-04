using System;
using System.Linq;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            double leftTime = 0;
            double rightTime = 0;

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int currentTime = numbers[i];

                if (currentTime == 0)
                {
                    leftTime *= 0.8;
                }
                else
                {
                    leftTime += currentTime;
                }
            }

            for (int i = numbers.Length - 1; i > numbers.Length / 2; i--)
            {
                int currentTime = numbers[i];

                if (currentTime == 0)
                {
                    rightTime *= 0.8;
                }
                else
                {
                    rightTime += currentTime;
                }
            }

            Console.WriteLine((leftTime < rightTime) ? $"The winner is left with total time: {leftTime}" : $"The winner is right with total time: {rightTime}");
        }
    }
}
