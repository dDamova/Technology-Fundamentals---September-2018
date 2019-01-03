using System;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = Sum(firstNum, secondNum);
            int totalResult = Subtract(sum, thirdNum);

            Console.WriteLine(totalResult);
        }

        private static int Sum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        private static int Subtract(int sum, int number)
        {
            return sum - number;
        }
    }
}
