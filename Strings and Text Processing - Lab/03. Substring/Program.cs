using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine().ToLower();
            string word = Console.ReadLine();

            while (true)
            {
                int index = word.IndexOf(wordToRemove);

                if (index == -1)
                {
                    break;
                }
                else
                {
                    word = word.Remove(index, wordToRemove.Length);
                }
            }

            Console.WriteLine(word);

        }
    }
}
