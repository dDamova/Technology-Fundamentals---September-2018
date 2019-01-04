using System;
using System.Linq;
using System.Numerics;

namespace MultiplyBigNumber_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine().TrimStart('0');
            int secondNumber = int.Parse(Console.ReadLine());

            string resultNumber = string.Empty;
            int onMind = 0;
            string reversedFirstNumber = string.Join("", firstNumber.ToCharArray().Reverse());

            if (firstNumber == "0" || secondNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < reversedFirstNumber.Length; i++)
            {
                int firstDigit = int.Parse(reversedFirstNumber[i].ToString());
                int result = firstDigit * secondNumber + onMind;

                resultNumber += result % 10;
                onMind = result / 10;

                if (i == reversedFirstNumber.Length - 1 && onMind != 0)
                {
                    resultNumber += onMind;
                }
            }

            Console.WriteLine(string.Join("", resultNumber.ToArray().Reverse()));
        }
    }
}
