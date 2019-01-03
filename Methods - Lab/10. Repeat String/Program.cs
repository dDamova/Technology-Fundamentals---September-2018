using System;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string result = RepeatString(str, count);

            Console.WriteLine(result);
        }

        private static string RepeatString(string str, int count)
        {
            StringBuilder resultString = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                resultString.Append(str);
            }

            return resultString.ToString();
        }
    }
}
