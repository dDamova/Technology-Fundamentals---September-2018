using System;
using System.Collections.Generic;
using System.Linq;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            Family family = new Family();
            for (int i = 0; i < peopleCount; i++)
            {
                string[] personData = Console.ReadLine().Split();
                string name = personData[0];
                int age = int.Parse(personData[1]);

                family.AddMember(new Person(name, age));
            }

            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    class Family
    {
        public List<Person> People { get; set; } = new List<Person>();

        public void AddMember(Person personMember)
        {
            this.People.Add(personMember);
        }

        public Person GetOldestMember()
        {
            return this.People.OrderByDescending(x => x.Age).First();
        }
    }
}
