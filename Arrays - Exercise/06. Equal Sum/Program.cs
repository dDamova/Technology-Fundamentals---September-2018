using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int indexOfElement = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    rightSum += numbers[k];
                }
                if (leftSum == rightSum)
                {
                    indexOfElement = i;
                }
            }
            if (indexOfElement != -1)
            {
                Console.WriteLine(indexOfElement);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
