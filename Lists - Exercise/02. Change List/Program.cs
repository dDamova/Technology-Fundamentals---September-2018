using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split().ToArray();
                string command = tokens[0];

                switch (command)
                {
                    case "Delete":
                        int elementToDelete = int.Parse(tokens[1]);
                        numbers.RemoveAll(n => n == elementToDelete);
                        break;
                    case "Insert":
                        int elementToInsert = int.Parse(tokens[1]);
                        int position = int.Parse(tokens[2]);
                        numbers.Insert(position, elementToInsert);
                        break;
                }
                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
