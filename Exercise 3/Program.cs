using System;
using System.Collections.Generic;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudents = new();
            listStudents.Add(new Student("1", "Tan", 10));
            listStudents.Add(new Student("2", "Tan1", 10));
            listStudents.Add(new Student("3", "Tan2", 10));
            listStudents.Add(new Student("4", "Tan3", 10));
            listStudents.Add(new Student("5", "Tan4", 10));
            listStudents.Add(new Student("6", "Tan5", 10));
            listStudents.Sort(Student.Compare);
            foreach (var item in listStudents)
            {
                Console.WriteLine(item);
            }
        }
    }
}
