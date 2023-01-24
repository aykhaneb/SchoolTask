using P329ConsoleAppPractise.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTask.Models
{
   internal class Teacher :Person
    {
        public Group[] Groups { get; set; } = new Group[10];
        public object Firstname { get;  set; }
        public object Id { get;  set; }
        public object Lastname { get;  set; }
        public object FatherName { get;  set; }
        public object Age { get;  set; }
        public object Profession { get; set; }
        public DateTime EntryDate { get; internal set; }
        public P329ConsoleAppPractise.Models.Group Group { get; internal set; }

        public  string ToString()
        {
            string Groups = "";
            foreach (var item in this.Groups)
            {
                if (item == null)
                    continue;

                Groups += item + "\n";
            }

            return $"{Id} {Firstname} {Lastname} {FatherName} {Age}\nGroup:\n{Groups}";
        }

        public override bool Equals(object? obj)
        {
            var teacher = obj as Teacher;

            return teacher.Id == Id;
        }
    }

    internal class Group : Entity
    {
        internal string Name { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
    

