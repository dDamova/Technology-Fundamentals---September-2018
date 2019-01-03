using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxWagonCapacity = int.Parse(Console.ReadLine());
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split().ToArray();

                if (tokens[0] == "Add")
                {
                    int passengersToAdd = int.Parse(tokens[1]);
                    train.Add(passengersToAdd);
                }
                else
                {
                    int passengers = int.Parse(tokens[0]);

                    for (int i = 0; i < train.Count; i++)
                    {
                        int currentWagonPassengers = train[i];

                        if (currentWagonPassengers + passengers <= maxWagonCapacity)
                        {
                            train[i] = currentWagonPassengers + passengers;
                            break;
                        }
                    }
                }
                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}
