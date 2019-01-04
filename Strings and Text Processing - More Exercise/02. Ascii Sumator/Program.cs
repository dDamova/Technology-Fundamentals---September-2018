using System;

namespace ASCIISimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (symbol > firstSymbol && symbol < secondSymbol)
                {
                    sum += symbol;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
