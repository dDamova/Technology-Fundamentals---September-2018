using System;
using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string input = Console.ReadLine();
            string password = "";
            int counter = 0;

            for (int currentLetter = username.Length - 1; currentLetter >= 0; currentLetter--)
            {
                password += username[currentLetter];
            }

            while (input != password)
            {
                counter++;

                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
