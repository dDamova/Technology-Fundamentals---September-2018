using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> resultList = new List<int>();
            int minLength = Math.Min(firstArr.Count, secondArr.Count);
            secondArr.Reverse();

            for (int i = 0; i < minLength; i++)
            {
                resultList.Add(firstArr[i]);
                resultList.Add(secondArr[i]);
            }

            int[] range = new int[2];

            if (firstArr.Count > secondArr.Count)
            {
                range[0] = firstArr[firstArr.Count - 2];
                range[1] = firstArr[firstArr.Count - 1];
            }
            else if (secondArr.Count > firstArr.Count)
            {
                range[0] = secondArr[secondArr.Count - 2];
                range[1] = secondArr[secondArr.Count - 1];
            }

            int from = Math.Min(range[0], range[1]);
            int to = Math.Max(range[0], range[1]);

            Console.WriteLine(string.Join(" ", resultList.Where(x => x > from && x < to).OrderBy(x => x).ToList()));
        }
    }
}
