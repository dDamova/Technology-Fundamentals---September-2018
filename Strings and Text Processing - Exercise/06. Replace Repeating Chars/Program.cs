using System;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = string.Empty;
            result += input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    result += input[i];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(result);
        }
    }
}
