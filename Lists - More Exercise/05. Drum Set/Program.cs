using System;
using System.Collections.Generic;
using System.Linq;

namespace DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();

            List<int> copyOfDrumSet = new List<int>();
            copyOfDrumSet.AddRange(drumSet);

            while (input != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                for (int i = 0; i < copyOfDrumSet.Count; i++)
                {
                    if (copyOfDrumSet[i] != 0)
                    {
                        copyOfDrumSet[i] -= hitPower;
                    }

                    if (copyOfDrumSet[i] <= 0)
                    {
                        decimal price = drumSet[i] * 3;

                        if (money < price)
                        {
                            copyOfDrumSet[i] = 0;
                        }
                        else
                        {
                            money -= price;
                            copyOfDrumSet[i] = drumSet[i];
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", copyOfDrumSet.Where(x => x > 0)));
            Console.WriteLine($"Gabsy has {money:f2}lv.");
        }
    }
}
