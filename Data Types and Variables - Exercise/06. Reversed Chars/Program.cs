using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());

            char temp = firstSymbol;
            firstSymbol = thirdSymbol;
            thirdSymbol = temp;

            Console.WriteLine($"{firstSymbol} {secondSymbol} {thirdSymbol}");
        }
    }
}
