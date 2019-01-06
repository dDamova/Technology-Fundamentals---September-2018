using System;

namespace _10._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isSpecial = false;
            for (int num = 1; num <= endNumber; num++)
            {
               int currentNum = num;

                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{currentNum} -> {isSpecial}");
                sum = 0;
                num = currentNum;
            }

        }
    }
}
