using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] tokens = input.Split(" -> ").ToArray();
                string company = tokens[0];
                string userId = tokens[1];

                if (companyUsers.ContainsKey(company) == false)
                {
                    companyUsers.Add(company, new List<string>());
                }
                if (companyUsers[company].Contains(userId) == false)
                {
                    companyUsers[company].Add(userId);
                }
                input = Console.ReadLine();
            }

            foreach (var kvp in companyUsers.OrderBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key);
                foreach (string id in kvp.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
