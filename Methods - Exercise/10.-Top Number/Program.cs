using System;

namespace TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int currentNum = 1; currentNum <= n; currentNum++)
            {
                bool isMaster = false;
                bool hasOddDigit = false;
                int sumOfDigits = 0;
                int currentNumCopy = currentNum;

                while (currentNumCopy != 0)
                {
                    int currentDigit = Math.Abs(currentNumCopy % 10);

                    if (currentDigit % 2 != 0)
                    {
                        hasOddDigit = true;
                    }
                    sumOfDigits += currentDigit;

                    currentNumCopy /= 10;
                }

                isMaster = ((sumOfDigits % 8 == 0) && hasOddDigit);

                if (isMaster)
                {
                    Console.WriteLine(currentNum);
                }
            }
        }

    }
}
