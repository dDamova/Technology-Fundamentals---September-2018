using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstArr = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();
            List<int> secondtArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int minLength = Math.Min(firstArr.Count, secondtArr.Count);
            List<int> resultArr = new List<int>();

            for (int i = 0; i < minLength; i++)
            {
                resultArr.Add(firstArr[i]);
                resultArr.Add(secondtArr[i]);
            }
            if (firstArr.Count > minLength)
            {
                for (int i = minLength; i < firstArr.Count; i++)
                {
                    resultArr.Add(firstArr[i]);
                }
            }
            else
            {
                for (int i = minLength; i < secondtArr.Count; i++)
                {
                    resultArr.Add(secondtArr[i]);
                }
            }

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
