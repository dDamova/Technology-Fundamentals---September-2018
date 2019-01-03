using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "subtract":
                    PrintSunstraction(firstNum, secondNum);
                    break;
                case "divide":
                    PrintDivision(firstNum, secondNum);
                    break;
                case "add":
                    PrintSum(firstNum, secondNum);
                    break;
                case "multiply":
                    PrintMultiplication(firstNum, secondNum);
                    break;
            }
        }

        private static void PrintMultiplication(int firstNum, int secondNum)
        {
            int result = firstNum * secondNum;

            Console.WriteLine(result);
        }

        private static void PrintSum(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;

            Console.WriteLine(result);
        }

        private static void PrintDivision(int firstNum, int secondNum)
        {
            int result = firstNum / secondNum;

            Console.WriteLine(result);
        }

        private static void PrintSunstraction(int firstNum, int secondNum)
        {
            int result = firstNum - secondNum;

            Console.WriteLine(result);
        }
    }
}
