using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AverageGrades
{
    internal class AG
    {
        public static void Main(string[] args)
        {
            var path = GetParentProjectPath(Environment.CurrentDirectory, 0, 2) + @"\IO";
            for (int i = 1; i <= 2; i++)
            {
                var lines = File.ReadAllLines(path + $@"\input{i}.txt");
                var students = new List<Student>();
                for (int j = 1; j < lines.Length; j++)
                {
                    var data = lines[j].Split(' ');
                    students.Add(new Student(data[0], data.Where((str, index) => index > 0).Select(double.Parse).ToArray()));
                }
                var output = new StringBuilder();
                students
                    .Where(st => st.AverageGrade >= 5.00)
                    .OrderBy(st => st.Name)
                    .ThenByDescending(st => st.AverageGrade)
                    .ToList()
                    .ForEach(st => output.Append(st.ToString()).Append(Environment.NewLine));
                File.WriteAllText(path + $@"\output{i}.txt", output.ToString().Trim());
            }
        }
        
        private static string GetParentProjectPath(string currPath, int currDirCount, int dirUpCount)
        {
            if (currDirCount == dirUpCount)
            {
                return currPath;
            }
            var parent = GetParentProjectPath(Directory.GetParent(currPath).ToString(), currDirCount + 1, dirUpCount);
            return parent;
        }
    }

    internal class Student
    {
        public string Name { get; }
        private double[] Grades { get; }
        public double AverageGrade { get; }

        public Student(string name, double[] grades)
        {
            Name = name;
            Grades = grades;
            AverageGrade = Grades.Average();
        }

        public override string ToString()
        {
            return $"{Name} -> {AverageGrade:F2}";
        }
    }
}