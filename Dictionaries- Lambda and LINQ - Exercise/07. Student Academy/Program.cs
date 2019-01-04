using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentAcademy = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentAcademy.ContainsKey(student) == false)
                {
                    studentAcademy.Add(student, new List<double>());
                }
                studentAcademy[student].Add(grade);
            }

            foreach (var kvp in studentAcademy.Where(s => s.Value.Average() >= 4.5).OrderByDescending(s => s.Value.Average()))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
            }
        }
    }
}
