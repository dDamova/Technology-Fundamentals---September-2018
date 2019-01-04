using System;
using System.Linq;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine()
                .Split(new[] {' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                string currentString = sequence[i];
                string numberAsString = currentString.Substring(1, currentString.Length - 2);
                double number = double.Parse(numberAsString);
                char firstLetter = currentString.First();
                int firstLetterPosition = FindLetterPosition(firstLetter);

                if (char.IsUpper(firstLetter))
                {
                    number /= firstLetterPosition;
                }
                else
                {
                    number *= firstLetterPosition;
                }

                char secondLetter = currentString.Last();
                int lastLetterPosition = FindLetterPosition(secondLetter);


                if (char.IsUpper(secondLetter))
                {
                    number -= lastLetterPosition;
                }
                else
                {
                    number += lastLetterPosition;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }

        private static int FindLetterPosition(char letter)
        {
            int position = 0;

            if (char.IsUpper(letter))
            {
                position = letter - 65 + 1;
            }
            else
            {
                position = letter - 97 + 1;
            }

            return position;
        }
    }
}
