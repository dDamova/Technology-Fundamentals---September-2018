using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> judge = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> individualStandings = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "no more time")
            {
                string[] tokens = input.Split(" -> ");
                string username = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);

                if (judge.ContainsKey(contest) == false)
                {
                    judge.Add(contest, new Dictionary<string, int>());
                }
                if (judge[contest].ContainsKey(username) == false)
                {
                    judge[contest].Add(username, points);
                }
                if (judge[contest][username] <= points)
                {
                    judge[contest][username] = points;
                }
                if (individualStandings.ContainsKey(username) == false)
                {
                    individualStandings.Add(username, new Dictionary<string, int>());
                }
                if (individualStandings[username].ContainsKey(contest) == false)
                {
                    individualStandings[username].Add(contest, 0);
                }
                if (individualStandings[username][contest] <= points)
                {
                    individualStandings[username][contest] = points;
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in judge)
            {
                int counter = 1;
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} participants");

                foreach (var user in kvp.Value.OrderByDescending(u => u.Value).ThenBy(u => u.Key))
                {
                    Console.WriteLine($"{counter}. {user.Key} <::> {user.Value}");
                    counter++;
                }
            }
            Console.WriteLine("Individual standings:");

            int position = 1;

            foreach (var kvp in individualStandings.OrderByDescending(u => u.Value.Values.Sum()).ThenBy(u => u.Key))
            {
                Console.WriteLine($"{position}. {kvp.Key} -> {kvp.Value.Values.Sum()}");
                position++;
            }
        }
    }
}
