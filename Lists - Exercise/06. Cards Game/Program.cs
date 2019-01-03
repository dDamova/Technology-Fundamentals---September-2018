using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayerCards = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (firstPlayerCards.Count > 0 && secondPlayerCards.Count > 0)
            {
                int firstPlayerCard = firstPlayerCards[0];
                int secondPlayerCard = secondPlayerCards[0];
                firstPlayerCards.RemoveAt(0);
                secondPlayerCards.RemoveAt(0);

                if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayerCards.Add(firstPlayerCard);
                    firstPlayerCards.Add(secondPlayerCard);
                }
                else if (secondPlayerCard > firstPlayerCard)
                {
                    secondPlayerCards.Add(secondPlayerCard);
                    secondPlayerCards.Add(firstPlayerCard);
                }
            }

            Console.WriteLine((firstPlayerCards.Count != 0) ? $"First player wins! Sum: {firstPlayerCards.Sum()}" : $"Second player wins! Sum: {secondPlayerCards.Sum()}");
        }
    }
}
