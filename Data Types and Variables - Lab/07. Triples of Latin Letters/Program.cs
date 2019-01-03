using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char firstLetter = 'a'; firstLetter < ('a' + n); firstLetter++)
            {
                for (char secondletter = 'a'; secondletter < ('a' + n); secondletter++)
                {
                    for (char thirdLetter = 'a'; thirdLetter < ('a' + n); thirdLetter++)
                    {
                        Console.WriteLine($"{firstLetter}{secondletter}{thirdLetter}");
                    }
                }
            }
        }
    }
}
