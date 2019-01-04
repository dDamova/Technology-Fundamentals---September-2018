using System;
using System.Linq;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] badWords = Console.ReadLine().Split(", ").ToArray();
            string text = Console.ReadLine();

            for (int i = 0; i < badWords.Length; i++)
            {
                int index = text.IndexOf(badWords[i]);

                while (index != -1)
                {
                    text = text.Replace(badWords[i], new string('*', badWords[i].Length));
                    index = text.IndexOf(badWords[i] + 1);
                }
            }
            Console.WriteLine(text);
        }
    }
}
