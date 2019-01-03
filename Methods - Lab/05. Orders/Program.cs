using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PrintsPrice(product, quantity);
        }

        private static void PrintsPrice(string product, int quantity)
        {
            double price = 0;

            switch (product)
            {
                case "coffee":
                    price = 1.5 * quantity;
                    break;
                case "water":
                    price = 1 * quantity;
                    break;
                case "coke":
                    price = 1.4 * quantity;
                    break;
                case "snacks":
                    price = 2 * quantity;
                    break;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
