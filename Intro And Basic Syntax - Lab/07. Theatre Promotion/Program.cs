using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            short age = short.Parse(Console.ReadLine());
            byte ticketPrice = 0;

            if (age >= 0 && age <= 18)
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        ticketPrice = 12;
                        Console.WriteLine($"{ticketPrice}$");
                        break;
                    case "Weekend":
                        ticketPrice = 15;
                        Console.WriteLine($"{ticketPrice}$");
                        break;
                    case "Holiday":
                        ticketPrice = 5;
                        Console.WriteLine($"{ticketPrice}$");
                        break;
                }
            }
            else if (age > 18 && age <= 64)
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        ticketPrice = 18;
                        Console.WriteLine($"{ticketPrice}$");
                        break;
                    case "Weekend":
                        ticketPrice = 20;
                        Console.WriteLine($"{ticketPrice}$");
                        break;
                    case "Holiday":
                        ticketPrice = 12;
                        Console.WriteLine($"{ticketPrice}$");
                        break;
                }
            }
            else if (age > 64 && age <= 122)
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        ticketPrice = 12;
                        Console.WriteLine($"{ticketPrice}$");
                        break;
                    case "Weekend":
                        ticketPrice = 15;
                        Console.WriteLine($"{ticketPrice}$");
                        break;
                    case "Holiday":
                        ticketPrice = 10;
                        Console.WriteLine($"{ticketPrice}$");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}

