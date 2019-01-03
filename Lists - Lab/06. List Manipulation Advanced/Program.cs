using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();
            string input = Console.ReadLine();
            bool isMadeChange = false;

            while (input != "end")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        isMadeChange = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        isMadeChange = true;
                        break;
                    case "RemoveAt":
                        int indexToRemoveAt = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemoveAt);
                        isMadeChange = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        numbers.Insert(index, numberToInsert);
                        isMadeChange = true;
                        break;
                    case "Contains":
                        int numberToContain = int.Parse(tokens[1]);

                        Console.WriteLine(numbers.Contains(numberToContain) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

                        Console.WriteLine(string.Join(" ", evenNumbers));
                        break;
                    case "PrintOdd":
                        List<int> oddNumbers = numbers.Where(n => n % 2 != 0).ToList();

                        Console.WriteLine(string.Join(" ", oddNumbers));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        string condition = tokens[1];
                        int number = int.Parse(tokens[2]);

                        switch (condition)
                        {
                            case "<":
                                List<int> smallerNumbers = numbers.Where(n => n < number).ToList();

                                Console.WriteLine(string.Join(" ", smallerNumbers));
                                break;
                            case ">":
                                List<int> greaterNumbers = numbers.Where(n => n > number).ToList();

                                Console.WriteLine(string.Join(" ", greaterNumbers));
                                break;
                            case ">=":
                                List<int> greaterOrEqualNumbers = numbers.Where(n => n >= number).ToList();

                                Console.WriteLine(string.Join(" ", greaterOrEqualNumbers));
                                break;
                            case "<=":
                                List<int> smallerOrEqualNumbers = numbers.Where(n => n <= number).ToList();

                                Console.WriteLine(string.Join(" ", smallerOrEqualNumbers));
                                break;
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            if (isMadeChange)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
