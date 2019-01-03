using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int sumOfRemovedElements = 0;

            while (sequence.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int element = 0;

                if (index < 0)
                {
                    element = sequence[0];
                    sequence.RemoveAt(0);
                    sequence.Insert(0, sequence[sequence.Count - 1]);
                }
                else if (index > sequence.Count - 1)
                {
                    element = sequence[sequence.Count - 1];
                    sequence.RemoveAt(sequence.Count - 1);
                    sequence.Add(sequence[0]);
                }
                else
                {
                    element = sequence[index];
                    sequence.RemoveAt(index);
                }
                sumOfRemovedElements += element;

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] <= element)
                    {
                        sequence[i] += element;
                    }
                    else
                    {
                        sequence[i] -= element;
                    }
                }
            }
            Console.WriteLine(sumOfRemovedElements);
        }
    }
}
