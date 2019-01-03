using System;
using System.Collections.Generic;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal totalInsertedMoney = 0;
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();

            while (input != "Start")
            {
                decimal coins = decimal.Parse(input);

                if (coins == 0.1M || coins == 0.2M || coins == 0.5M || coins == 1 || coins == 2)
                {
                    totalInsertedMoney += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                input = Console.ReadLine();
            }

            string inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                string product = inputLine.ToLower();
                decimal productPrice = 0.0M;

                if (product == "nuts")
                {
                    productPrice = 2;
                }
                else if (product == "water")
                {
                    productPrice = 0.7M;
                }
                else if (product == "crisps")
                {
                    productPrice = 1.5M;
                }
                else if (product == "soda")
                {
                    productPrice = 0.8M;
                }
                else if (product == "coke")
                {
                    productPrice = 1;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                if (totalInsertedMoney < productPrice)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else if(product=="nuts" || product == "water" || product == "crisps" || product == "soda" || product == "coke")
                {
                    totalInsertedMoney -= productPrice;

                    Console.WriteLine($"Purchased {product }");
                }
                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"Change: {totalInsertedMoney:F2}");
        }
    }
}
