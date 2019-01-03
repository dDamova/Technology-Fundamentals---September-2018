using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool areIdentical = true;
            int sum = 0;
            int index = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    index = i;
                    areIdentical = false;
                    break;
                }
                sum += arr2[i];
            }
            if (areIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }
        }
    }
}
