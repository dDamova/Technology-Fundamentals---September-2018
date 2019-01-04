using System;
using System.Linq;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();

            string str1 = input[0];
            string str2 = input[1];
            int minLenght = Math.Min(str1.Length, str2.Length);
            long sum = 0;

            for (int i = 0; i < minLenght; i++)
            {
                sum += str1[i] * str2[i];
            }
            if (str1.Length>str2.Length)
            {
                for (int i = minLenght; i < str1.Length; i++)
                {
                    sum += str1[i];
                }
            }
            else if (str2.Length > str1.Length)
            {
                for (int i = minLenght; i < str2.Length; i++)
                {
                    sum += str2[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
