using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parkingLot = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = tokens[0];

                switch (command)
                {
                    case "register":
                        string username = tokens[1];
                        string licensePlateNumber = tokens[2];

                        if (parkingLot.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {parkingLot[username]}");
                        }
                        else
                        {
                            parkingLot.Add(username, licensePlateNumber);

                            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        }
                        break;
                    case "unregister":
                        string usernameToUnregister = tokens[1];

                        if (parkingLot.ContainsKey(usernameToUnregister) == false)
                        {
                            Console.WriteLine($"ERROR: user {usernameToUnregister} not found");
                        }
                        else
                        {
                            parkingLot.Remove(usernameToUnregister);

                            Console.WriteLine($"{usernameToUnregister} unregistered successfully");
                        }
                        break;
                }
            }

            foreach (var kvp in parkingLot)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
