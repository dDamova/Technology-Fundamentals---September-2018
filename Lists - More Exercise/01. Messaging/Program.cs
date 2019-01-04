using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string text = Console.ReadLine();
            string result = "";

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                int index = GetIndex(currentNumber);
                int realIndex = index % text.Length;
                result += text[realIndex];
                text = GetRestOtText(text, realIndex);
            }

            Console.WriteLine(result);
        }

        private static string GetRestOtText(string text, int realIndex)
        {
            string restOfText = "";

            for (int i = 0; i < realIndex; i++)
            {
                restOfText += text[i];
            }

            for (int i = realIndex + 1; i < text.Length; i++)
            {
                restOfText += text[i];
            }
            return restOfText;
        }

        private static int GetIndex(int currentNumber)
        {
            int sum = 0;

            while (currentNumber != 0)
            {
                sum += currentNumber % 10;
                currentNumber /= 10;
            }
            return sum;
        }
    }
}
