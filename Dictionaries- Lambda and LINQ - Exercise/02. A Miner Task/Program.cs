using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, long> mine = new Dictionary<string, long>();

            while (input != "stop")
            {
                string resource = input;
                long quantity = long.Parse(Console.ReadLine());

                if (mine.ContainsKey(resource) == false)
                {
                    mine.Add(resource, quantity);
                }
                else
                {
                    mine[resource] += quantity;
                }
                input = Console.ReadLine();
            }

            foreach (var kvp in mine)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
