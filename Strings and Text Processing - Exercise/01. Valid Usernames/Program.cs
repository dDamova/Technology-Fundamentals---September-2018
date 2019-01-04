using System;
using System.Collections.Generic;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<string> validUsernames = new List<string>();

            for (int i = 0; i < usernames.Length; i++)
            {
                string currentUsername = usernames[i];

                if (currentUsername.Length >= 3 && currentUsername.Length <= 16)
                {
                    bool isValidContent = IsValidContent(currentUsername);

                    if (isValidContent)
                    {
                        validUsernames.Add(currentUsername);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validUsernames));
        }

        private static bool IsValidContent(string currentUsername)
        {
            foreach (char symbol in currentUsername)
            {
                if (char.IsLetterOrDigit(symbol) || symbol == '_' || symbol == '-')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
