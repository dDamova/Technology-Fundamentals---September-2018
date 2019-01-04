using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, double> productPrice = new Dictionary<string, double>();
            Dictionary<string, int> productQuantity = new Dictionary<string, int>();

            while (input != "buy")
            {
                string[] tokens = input.Split(" ").ToArray();
                string product = tokens[0];
                double price = double.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

                if (productPrice.ContainsKey(product) == false)
                {
                    productPrice.Add(product, price);
                    productQuantity.Add(product, quantity);
                }
                else
                {
                    productPrice[product] = price;
                    productQuantity[product] += quantity;
                }
                input = Console.ReadLine();
            }

            foreach (var kvp in productPrice)
            {
                foreach (var keyvp in productQuantity.Where(x => x.Key == kvp.Key))
                {
                    double totalSum = kvp.Value * keyvp.Value;

                    Console.WriteLine($"{kvp.Key} -> {totalSum:f2}");
                }
            }
        }
    }
}
