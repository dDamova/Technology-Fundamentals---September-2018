using System;
using System.Text;

namespace PalindromeIntegrs
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                bool isPalindrome = IsPalindrome(inputLine);
                Console.WriteLine(isPalindrome? "true":"false");

                inputLine = Console.ReadLine();
            }
        }

        private static bool IsPalindrome(string inputLine)
        {
            StringBuilder reversed = new StringBuilder();

            for (int i = inputLine.Length - 1; i >= 0; i--)
            {
                reversed.Append(inputLine[i]);
            }

            bool isPalindrome = (inputLine.CompareTo(reversed.ToString()) == 0);

            return isPalindrome;
        }
    }
}
