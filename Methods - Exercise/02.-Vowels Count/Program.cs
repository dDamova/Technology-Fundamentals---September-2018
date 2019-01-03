using System;
using System.Linq;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int count = GetVowelsCount(str);

            Console.WriteLine(count);
        }

        private static int GetVowelsCount(string str)
        {
            char[] vowels = { 'a', 'o', 'e', 'u', 'i', 'A', 'O', 'E', 'U', 'I' };
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
