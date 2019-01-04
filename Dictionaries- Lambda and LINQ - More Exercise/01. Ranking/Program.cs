using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> ranking = new Dictionary<string, Dictionary<string, int>>();

            while (input != "end of contests")
            {
                string[] tokens = input.Split(":");
                string contest = tokens[0];
                string password = tokens[1];

                if (contests.ContainsKey(contest) == false)
                {
                    contests.Add(contest, password);
                }

                input = Console.ReadLine();
            }

            string inputLine = Console.ReadLine();

            while (inputLine != "end of submissions")
            {
                string[] tokens = inputLine.Split("=>");
                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (ranking.ContainsKey(username) == false)
                    {
                        ranking.Add(username, new Dictionary<string, int>());
                        ranking[username].Add(contest, points);
                    }
                    if (ranking[username].ContainsKey(contest) == false)
                    {
                        ranking[username].Add(contest, 0);
                    }
                    if (ranking[username][contest] <= points)
                    {
                        ranking[username][contest] = points;
                    }
                }
                inputLine = Console.ReadLine();
            }
            PrintBestCandidate(ranking);
            PrintAllStudents(ranking);
        }

        private static void PrintAllStudents(Dictionary<string, Dictionary<string, int>> ranking)
        {
            Console.WriteLine("Ranking:");

            foreach (var kvp in ranking.OrderBy(kvp => kvp.Key))
            {
                Console.WriteLine(kvp.Key);

                foreach (var user in kvp.Value.OrderByDescending(u => u.Value))
                {
                    Console.WriteLine($"#  {user.Key} -> {user.Value}");
                }
            }
        }

        private static void PrintBestCandidate(Dictionary<string, Dictionary<string, int>> ranking)
        {
            foreach (var kvp in ranking.OrderByDescending(kvp => kvp.Value.Values.Sum()))
            {
                Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value.Values.Sum()} points.");
                return;
            }
        }
    }
}
