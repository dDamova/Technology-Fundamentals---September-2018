using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string[] teamInfo = Console.ReadLine().Split("-");

                if (teams.Any(t => t.TeamName == teamInfo[1]) == false)
                {
                    if (teams.Any(t => t.Creator == teamInfo[0]) == false)
                    {
                        teams.Add(new Team(teamInfo));
                        Console.WriteLine($"Team {teamInfo[1]} has been created by {teamInfo[0]}!");
                    }
                    else
                    {
                        Console.WriteLine($"{teamInfo[0]} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamInfo[1]} was already created!");
                }
            }

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] tokens = input.Split("->");
                string user = tokens[0];
                string teamName = tokens[1];

                if (teams.Any(t => t.TeamName == teamName) == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else
                {
                    if (teams.Any(t => t.Members.Contains(user) || teams.Any(x => x.Creator == user)))
                    {
                        Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    }
                    else
                    {
                        teams.Find(t => t.TeamName == teamName).Members.Add(user);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (Team team in teams.Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(x => x.TeamName))
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Creator}");

                foreach (string member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");

            foreach (Team team in teams.Where(t => t.Members.Count == 0).OrderBy(t => t.TeamName))
            {
                Console.WriteLine($"{team.TeamName}");
            }
        }
    }

    class Team
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; } = new List<string>();

        public Team(string[] teamInfo)
        {
            this.TeamName = teamInfo[1];
            this.Creator = teamInfo[0];
        }
    }
}
