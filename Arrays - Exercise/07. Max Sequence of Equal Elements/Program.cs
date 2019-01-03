using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 1;
            int startIndex = 0;
            int endIndex = 0;
            int maxSequence = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxSequence)
                {
                    maxSequence = counter;
                    startIndex = i - (counter - 1);
                    endIndex = i;
                }
            }
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
