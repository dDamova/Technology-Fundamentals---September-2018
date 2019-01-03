using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int coursesCount = 0;
            if (numberOfPeople%capacity==0)
            {
                coursesCount = numberOfPeople / capacity;
            }
            else
            {
                coursesCount = (numberOfPeople / capacity) + 1;
            }

            Console.WriteLine(coursesCount);
        }
    }
}
