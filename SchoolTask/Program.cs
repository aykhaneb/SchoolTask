using P329ConsoleAppPractise.Models;
using SchoolTask.Models;
using System;

namespace P329ConsoleAppPractise
{
    internal class Program
    {
        private static object teacherManager;
        private static Teacher teacher;

        static void Main(string[] args)
        {
            #region Day 1
            TeacherManager teacherManager = new TeacherManager();
            string command = "";

            do
            {
                Console.Write("Enter the command:");
                command = Console.ReadLine();


                if (command.ToLower().Equals("add teacher"))
                {
                    var teacher1 = new Teacher
                    {
                        Id = 1,
                        Firstname = "Rafet",
                        Lastname = "Rzayev",
                        Age = 25,    Profession="Math",
                        EntryDate = DateTime.Now,
                        Group = new Models.Group
                    
                        {
                            Id = 1,
                            Name = "P329",
                        },

                    };
                    teacherManager.Add(teacher1);
                }
                else if (command.ToLower().Equals("print teachers"))
                {
                    teacherManager.Print();
                }
                else if (command.ToLower().Equals("delete teacher"))
                {
                    Console.Write("Enter the id:");
                    var id = int.Parse(Console.ReadLine());

                    teacherManager.Delete(id);
                }
                else if (command.ToLower().Equals("update teacher"))
                {
                    Console.Write("Enter the id:");
                    var id = int.Parse(Console.ReadLine());

                    var existTeacher = teacherManager.Get(id);

                    if (existTeacher == null)
                        continue;

                    Console.WriteLine(existTeacher);

                    var teacher2 = new Teacher
                    {
                        Id = 1,
                        Firstname = "Rafet",
                        Lastname = "Rzayev",
                        Age = 25,
                        EntryDate = DateTime.Now,
                        Group = new Models.Group
                        {
                            Id = 1,
                            Name = "P329",
                        },
                    };

                    teacherManager.Update(id, teacher);
                }

            } while (command.ToLower() != "quit");
        }
    }
} 