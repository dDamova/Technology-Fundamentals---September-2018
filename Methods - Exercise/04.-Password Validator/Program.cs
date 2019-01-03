using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (IsLongEnough(password) && ConsistsLettersAndDigits(password) && Have2Digits(password))
            {
                Console.WriteLine("Password is valid");
            }
            else if (!IsLongEnough(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!ConsistsLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!Have2Digits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        private static bool IsLongEnough(string password)
        {
            bool isLongEnough = (password.Length >= 6 && password.Length <= 10);

            return isLongEnough;
        }

        private static bool ConsistsLettersAndDigits(string password)
        {
            bool isLetterOrDigit = false;

            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] >= 65 && password[i] <= 90) || (password[i] >= 97 && password[i] <= 122) || (password[i] >= 48 && password[i] <= 57))
                {
                    isLetterOrDigit = true;
                }
                else
                {
                    isLetterOrDigit = false;
                    break;
                }
            }

            return isLetterOrDigit;
        }

        private static bool Have2Digits(string password)
        {
            bool have2Digits = false;
            int counter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    counter++;
                }
                if (counter == 2)
                {
                    have2Digits = true;
                    break;
                }
            }

            return have2Digits;
        }
    }
}
