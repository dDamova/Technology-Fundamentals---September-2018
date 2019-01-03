using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            if (letter >= 97 && letter <= 122)
            {
                Console.WriteLine("lower-case");
            }
            else if (letter >= 65 && letter <= 90)
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
