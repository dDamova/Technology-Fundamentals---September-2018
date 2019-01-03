using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();
            string firstVariable = Console.ReadLine();
            string secondVariable = Console.ReadLine();

            switch (valueType)
            {
                case "int":
                    int firstNum = int.Parse(firstVariable);
                    int secondNum = int.Parse(secondVariable);

                    int maxInt = GetMax(firstNum, secondNum);

                    Console.WriteLine(maxInt);
                    break;
                case "char":
                    char firstChar = char.Parse(firstVariable);
                    char secondChar = char.Parse(secondVariable);

                    char maxChar = GetMax(firstChar, secondChar);

                    Console.WriteLine(maxChar);
                    break;
                case "string":
                    string maxString = GetMax(firstVariable, secondVariable);

                    Console.WriteLine(maxString);
                    break;
            }
        }

        private static string GetMax(string firstVariable, string secondVariable)
        {
            if (firstVariable.CompareTo(secondVariable) > 0)
            {
                return firstVariable;
            }
            else
            {
                return secondVariable;
            }
        }

        private static int GetMax(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }

        private static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }
    }
}
