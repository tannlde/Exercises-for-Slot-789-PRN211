using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Student
    {
        private string id;
        private string name;
        private int age;

        public Student()
        {
        }

        public Student(string id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = (value > 0 && value < 150) ? value : throw new Exception("Age must be between 0 and 150"); }

        public override string ToString() => $"id ={Id}, Name = {Name}, Age= {Age}";

        public static int Compare(Student x, Student y) => y.Name.CompareTo(x.Name);
    }
}
