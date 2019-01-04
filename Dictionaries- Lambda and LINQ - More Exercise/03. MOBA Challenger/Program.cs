using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> playersData = new Dictionary<string, Dictionary<string, int>>();

            while (inputLine != "Season end")
            {
                if (inputLine.Contains("->"))
                {
                    string[] tokens = inputLine.Split(" -> ");
                    string player = tokens[0];
                    string position = tokens[1];
                    int skill = int.Parse(tokens[2]);

                    if (playersData.ContainsKey(player) == false)
                    {
                        playersData.Add(player, new Dictionary<string, int>());
                    }
                    if (playersData[player].ContainsKey(position) == false)
                    {
                        playersData[player].Add(position, 0);
                    }
                    if (playersData[player][position] < skill)
                    {
                        playersData[player][position] = skill;
                    }
                }
                else
                {
                    string[] tokens = inputLine.Split(" vs ");
                    string player1 = tokens[0];
                    string player2 = tokens[1];

                    if (playersData.ContainsKey(player1) && playersData.ContainsKey(player2))
                    {
                        foreach (string position in playersData[player1].Keys)
                        {
                            if (playersData[player2].ContainsKey(position))
                            {
                                if (playersData[player1][position] > playersData[player2][position])
                                {
                                    playersData.Remove(player2);
                                }
                                else if (playersData[player2][position] > playersData[player1][position])
                                {
                                    playersData.Remove(player1);
                                }
                                break;
                            }
                        }
                    }
                }
                inputLine = Console.ReadLine();
            }

            foreach (var kvp in playersData.OrderByDescending(p => p.Value.Values.Sum()).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Values.Sum()} skill");

                foreach (var position in kvp.Value.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
