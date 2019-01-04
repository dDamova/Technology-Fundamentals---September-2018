using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] tokens = input.Split();

                boxes.Add(new Box(tokens));

                input = Console.ReadLine();
            }

            foreach (Box box in boxes.OrderByDescending(b => b.PriceForABox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.CurrentItem.Name} - ${box.CurrentItem.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public Item CurrentItem { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox { get; set; }

        public Box(string[] tokens)
        {
            this.SerialNumber = tokens[0];

            string itemName = tokens[1];
            decimal itemPrice = decimal.Parse(tokens[3]);

            this.CurrentItem = new Item(itemName, itemPrice);
            this.ItemQuantity = int.Parse(tokens[2]);
            this.PriceForABox = ItemQuantity * CurrentItem.Price;
        }
    }
}
