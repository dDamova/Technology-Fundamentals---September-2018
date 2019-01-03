using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            if (dataType == "int")
            {
                int numberInt = int.Parse(Console.ReadLine());

                int result = GetResult(numberInt);

                Console.WriteLine(result);
            }
            else if (dataType == "real")
            {
                double numberDouble = double.Parse(Console.ReadLine());

                double result = GetResult(numberDouble);

                Console.WriteLine($"{result:f2}");
            }
            else if (dataType == "string")
            {
                string str = Console.ReadLine();

                string result = GetResult(str);

                Console.WriteLine(result);
            }
        }

        private static string GetResult(string str)
        {
            return $"${str}$";
        }

        private static double GetResult(double numberDouble)
        {
            return numberDouble * 1.5;
        }

        private static int GetResult(int numberInt)
        {
            return numberInt * 2;
        }
    }
}
