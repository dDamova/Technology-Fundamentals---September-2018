using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int currentNum = 1; currentNum <= n; currentNum++)
            {
                int sumOfDigits = 0;
                int currentNumCopy = currentNum;
                bool isSpecial = false;

                while (currentNumCopy>0)
                {
                    sumOfDigits += currentNumCopy % 10;
                    currentNumCopy /= 10;
                }

                if (sumOfDigits==5 || sumOfDigits==7 || sumOfDigits==11)
                {
                    isSpecial = true;
                }

                Console.WriteLine($"{currentNum} -> {isSpecial}");
            }
        }
    }
}
