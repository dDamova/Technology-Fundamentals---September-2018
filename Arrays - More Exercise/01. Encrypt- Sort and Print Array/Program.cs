using System;
using System.Linq;

namespace _01._EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[] vowels = { 'a', 'e', 'o', 'u', 'i', 'A', 'E', 'O', 'U', 'I' };
            int[] encruptedArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                string currentWord = Console.ReadLine();

                for (int j = 0; j < currentWord.Length; j++)
                {
                    if (vowels.Contains(currentWord[j]))
                    {
                        encruptedArr[i] += currentWord[j] * currentWord.Length;
                    }
                    else
                    {
                        encruptedArr[i] += currentWord[j] / currentWord.Length;
                    }
                }
            }
            encruptedArr = encruptedArr.OrderBy(x => x).ToArray();

            for (int i = 0; i < encruptedArr.Length; i++)
            {
                Console.WriteLine($"{encruptedArr[i]}");
            }
        }
    }
}
