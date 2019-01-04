using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (input != "end")
            {
                string[] tokens = input.Split();

                students.Add(new Student(tokens));

                input = Console.ReadLine();
            }

            string filterTown = Console.ReadLine();

            foreach (Student student in students.Where(s => s.Hometown == filterTown))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }

        public Student(string[] tokens)
        {
            string firstName = tokens[0];
            string lastName = tokens[1];
            int age = int.Parse(tokens[2]);
            string hometown = tokens[3];

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Hometown = hometown;
        }
    }
}
