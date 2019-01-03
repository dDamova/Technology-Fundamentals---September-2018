using System;
using System.Linq;

namespace Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    array1[i] = temp[0];
                    array2[i] = temp[1];
                }
                else
                {
                    array2[i] = temp[0];
                    array1[i] = temp[1];

                }
            }
            Console.WriteLine(string.Join(" ", array1));
            Console.WriteLine(string.Join(" ", array2));

        }
    }
}
