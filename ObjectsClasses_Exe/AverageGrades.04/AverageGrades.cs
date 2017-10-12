using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AverageGrades
{
    internal class AverageGrades
    {
        public static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var students = new List<Student>(count);
            for (int i = 0; i < count; i++)
            {
                students.Add(ParseInput(Console.ReadLine()));
            }
            var output = new StringBuilder();
            students
                .Where(st => st.AverageGrade >= 5.00)
                .OrderBy(st => st.Name)
                .ThenByDescending(st => st.AverageGrade)
                .ToList()
                .ForEach(st => output.Append($"{st.Name} -> {st.AverageGrade:F2}").Append(Environment.NewLine));
            Console.Write(output);
        }

        private static Student ParseInput(string input)
        {
            var data = input.Split(' ');
            var grades = new double[data.Length - 1];
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = double.Parse(data[i + 1]);
            }
            return new Student(data[0], grades);
        }
    }

    internal class Student
    {
        public string Name { get; }
        public double[] Grades { get; }
        public double AverageGrade { get; }

        public Student(string name, double[] grades)
        {
            Name = name;
            Grades = grades;
            AverageGrade = grades.Average();
        }
    }
}