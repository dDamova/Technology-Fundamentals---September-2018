using System;

namespace IntroAndBasicSyntax_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            float grade = float.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:F2}");
        }
    }
}
