using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] peopleInput = Console.ReadLine().Split(";");

            foreach (var person in peopleInput)
            {
                string name = person.Split("=")[0];
                decimal money = decimal.Parse(person.Split("=")[1]);

                people.Add(new Person(name, money));
            }


            string[] productInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var product in productInput)
            {
                string name = product.Split("=")[0];
                decimal cost = decimal.Parse(product.Split("=")[1]);

                products.Add(new Product(name, cost));
            }


            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string personName = tokens[0];
                string productN = tokens[1];

                people.Find(p => p.Name == personName).Buy(products.Find(p => p.ProductName == productN));

                command = Console.ReadLine();
            }

            foreach (var person in people)
            {
                if (person.BagOfProducts.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts)}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }

            }
        }
    }

    class Product
    {
        public string ProductName { get; set; }

        public decimal Cost { get; set; }

        public Product(string name, decimal cost)
        {
            this.ProductName = name;
            this.Cost = cost;
        }
    }

    class Person
    {
        public string Name { get; set; }

        public decimal Money { get; set; }

        public List<string> BagOfProducts { get; set; } = new List<string>();

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
        }

        public void Buy(Product productToBuy)
        {
            if (this.Money >= productToBuy.Cost)
            {
                this.BagOfProducts.Add(productToBuy.ProductName);
                this.Money -= productToBuy.Cost;

                Console.WriteLine($"{this.Name} bought {productToBuy.ProductName}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {productToBuy.ProductName}");
            }
        }
    }
}
