using System;

namespace ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                int startIndexOfName = input.IndexOf('@') + 1;
                int endindexOfName = input.IndexOf('|');
                int lengthOfName = endindexOfName - startIndexOfName;
                string name = input.Substring(startIndexOfName, lengthOfName);

                int startIndexOfAge = input.IndexOf('#') + 1;
                int endindexOfAge = input.IndexOf('*');
                int lengthOfAge = endindexOfAge - startIndexOfAge;
                string age = input.Substring(startIndexOfAge, lengthOfAge);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
