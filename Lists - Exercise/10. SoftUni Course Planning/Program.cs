using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string inputLine = Console.ReadLine();

            while (inputLine != "course start")
            {
                string[] tokens = inputLine.Split(":").ToArray();
                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        string lessonTitleToAdd = tokens[1];

                        if (schedule.Contains(lessonTitleToAdd) == false)
                        {
                            schedule.Add(lessonTitleToAdd);
                        }
                        break;
                    case "Insert":
                        string lessonTitleToInsert = tokens[1];
                        int index = int.Parse(tokens[2]);

                        if (schedule.Contains(lessonTitleToInsert) == false)
                        {
                            schedule.Insert(index, lessonTitleToInsert);
                        }
                        break;
                    case "Remove":
                        string lessonTitleToRemove = tokens[1];

                        if (schedule.Contains(lessonTitleToRemove))
                        {
                            schedule.Remove(lessonTitleToRemove);
                        }
                        if (schedule.Contains($"{lessonTitleToRemove}-Exercise"))
                        {
                            schedule.Remove($"{lessonTitleToRemove}-Exercise");
                        }
                        break;
                    case "Swap":
                        string lesson1 = tokens[1];
                        string lesson2 = tokens[2];

                        if (schedule.Contains(lesson1) && schedule.Contains(lesson2))
                        {
                            for (int i = 0; i < schedule.Count; i++)
                            {
                                if (schedule[i] == lesson1)
                                {
                                    schedule[i] = lesson2;

                                    if (schedule.Contains($"{lesson2}-Exercise"))
                                    {
                                        schedule.Remove($"{lesson2}-Exercise");
                                        schedule.Insert(i + 1, $"{lesson2}-Exercise");
                                    }
                                }
                                else if (schedule[i] == lesson2)
                                {
                                    schedule[i] = lesson1;

                                    if (schedule.Contains($"{lesson1}-Exercise"))
                                    {
                                        schedule.Remove($"{lesson1}-Exercise");
                                        schedule.Insert(i + 1, $"{lesson1}-Exercise");
                                    }
                                }
                            }
                        }
                        break;
                    case "Exercise":
                        string lessonExercise = tokens[1];

                        if (schedule.Contains(lessonExercise) && schedule.Contains($"{lessonExercise}-Exercise") == false)
                        {
                            for (int i = 0; i < schedule.Count; i++)
                            {
                                if (schedule[i] == lessonExercise)
                                {
                                    schedule.Insert(i + 1, $"{lessonExercise}-Exercise");
                                }
                            }
                        }
                        else if (schedule.Contains(lessonExercise) == false)
                        {
                            schedule.Add(lessonExercise);
                            schedule.Add($"{lessonExercise}-Exercise");
                        }
                        break;
                }
                inputLine = Console.ReadLine();
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}
