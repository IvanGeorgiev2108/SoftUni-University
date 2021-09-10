using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] studentInfo = Console.ReadLine().Split(" ");
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                //  studentInfo[2] = studentInfo[2].Replace('.', ',');
                double grade = double.Parse(studentInfo[2]);

                students.Add(new Student(firstName, lastName, grade));
            }

            students = students.OrderByDescending(s => s.Grade).ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
        class Student
        {
            public Student(string f_name, string l_name, double grade)
            {
                FirstName = f_name;
                LastName = l_name;
                Grade = grade;
            }

            public string FirstName { get; private set; }
            public string LastName { get; private set; }
            public double Grade { get; private set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade.ToString("F").Replace(',', '.')}";
            }
        }
    }
}