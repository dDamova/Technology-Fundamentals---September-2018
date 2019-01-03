using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine
                    .Split()
                    .ToArray();
                string command = tokens[0];

                switch (command)
                {
                    case "exchange":
                        int index = int.Parse(tokens[1]);

                        if (index < 0 || index >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers = Exchange(numbers, index);
                        }
                        break;
                    case "max":
                        string evenOrOdd = tokens[1];
                        if (evenOrOdd == "even")
                        {
                            int maxIndex = GetMaxEvenIndex(numbers);

                            if (maxIndex < 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(maxIndex);
                            }
                        }
                        else if (evenOrOdd == "odd")
                        {
                            int maxIndex = GetMaxOddIndex(numbers);

                            if (maxIndex < 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(maxIndex);
                            }
                        }
                        break;
                    case "min":
                        if (tokens[1] == "even")
                        {
                            int minIndex = GetMinEvenIndex(numbers);

                            if (minIndex < 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(minIndex);
                            }
                        }
                        else if (tokens[1] == "odd")
                        {
                            int minIndex = GetMinOddIndex(numbers);

                            if (minIndex < 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(minIndex);
                            }
                        }
                        break;
                    case "first":
                        int count = int.Parse(tokens[1]);

                        if (count > numbers.Count)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }
                        if (tokens[2] == "even")
                        {
                            PrintsFirstEven(count, numbers);
                        }
                        else if (tokens[2] == "odd")
                        {
                            PrintsFirstOdd(count, numbers);
                        }
                        break;
                    case "last":
                        int countLast = int.Parse(tokens[1]);

                        if (countLast > numbers.Count)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }
                        if (tokens[2] == "even")
                        {
                            PrintsLastEven(countLast, numbers);
                        }
                        else if (tokens[2] == "odd")
                        {
                            PrintsLastOdd(countLast, numbers);
                        }
                        break;
                }
                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static void PrintsLastOdd(int countLast, List<int> numbers)
        {
            List<int> resultOdd = new List<int>();
            int counter = 0;

            if (countLast == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        resultOdd.Add(numbers[i]);
                        counter++;
                    }
                    if (counter == countLast)
                    {
                        break;
                    }
                }

                resultOdd.Reverse();

                Console.WriteLine($"[{string.Join(", ", resultOdd)}]");
            }
        }

        private static void PrintsLastEven(int countLast, List<int> numbers)
        {
            List<int> resultEven = new List<int>();
            int counter = 0;

            if (countLast == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        resultEven.Add(numbers[i]);
                        counter++;
                    }
                    if (counter == countLast)
                    {
                        break;
                    }
                }

                resultEven.Reverse();

                Console.WriteLine($"[{string.Join(", ", resultEven)}]");
            }
        }

        private static void PrintsFirstOdd(int count, List<int> numbers)
        {
            List<int> resultOdds = new List<int>();
            int oddCounter = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    resultOdds.Add(numbers[i]);
                    oddCounter++;
                }
                if (oddCounter == count)
                {
                    break;
                }
            }

            if (oddCounter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", resultOdds)}]");
            }
        }

        private static void PrintsFirstEven(int count, List<int> numbers)
        {
            List<int> resultEvens = new List<int>();
            int evenCounter = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    resultEvens.Add(numbers[i]);
                    evenCounter++;
                }
                if (evenCounter == count)
                {
                    break;
                }
            }

            if (evenCounter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", resultEvens)}]");
            }
        }

        private static int GetMinOddIndex(List<int> numbers)
        {
            int index = -1;
            int minElement = int.MaxValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    if (numbers[i] <= minElement)
                    {
                        minElement = numbers[i];
                        index = i;
                    }
                }
            }

            return index;
        }

        private static int GetMinEvenIndex(List<int> numbers)
        {
            int index = -1;
            int minElement = int.MaxValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] <= minElement)
                    {
                        minElement = numbers[i];
                        index = i;
                    }
                }
            }

            return index;
        }

        private static List<int> Exchange(List<int> numbers, int index)
        {
            int[] firstArr = numbers.Take(index + 1).ToArray();
            int[] secondArr = numbers.Skip(index + 1).ToArray();
            List<int> result = new List<int>();
            result.AddRange(secondArr);
            result.AddRange(firstArr);

            return result;
        }

        private static int GetMaxEvenIndex(List<int> numbers)
        {
            int index = -1;
            int maxElement = int.MinValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] >= maxElement)
                    {
                        maxElement = numbers[i];
                        index = i;
                    }
                }
            }

            return index;
        }

        private static int GetMaxOddIndex(List<int> numbers)
        {
            int index = -1;
            int maxElement = int.MinValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    if (numbers[i] >= maxElement)
                    {
                        maxElement = numbers[i];
                        index = i;
                    }
                }
            }

            return index;
        }
    }
}
