using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace MentorGroup
{
    internal class MentorGroup
    {
        public static void Main(string[] args)
        {
            var students = new SortedDictionary<string, Student>();
            var input = Console.ReadLine();
            while (input != null && input != "end of dates")
            {
                var data = input.Split(' ');
                var name = data[0];
                if (!students.ContainsKey(name))
                {
                    students.Add(name, new Student(name));
                }
                if (data.Length > 1)
                {
                    var dates = data[1].Split(',')
                        .Select(str => DateTime.ParseExact(str, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                        .ToList();
                    students[name].DatesAttended.AddRange(dates);
                }
                
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != null && input != "end of comments")
            {
                var data = input.Split('-');
                var name = data[0];
                var comment = data[1];
                if (students.ContainsKey(name))
                {
                    students[name].Comments.Add(comment);
                }
                
                input = Console.ReadLine();
            }

            var output = new StringBuilder();
            foreach (var student in students.Values)
            {
                output.Append(student.Name).Append(Environment.NewLine);
                output.Append("Comments:").Append(Environment.NewLine);
                student.Comments
                    .ForEach(comment => output.Append($"- {comment}").Append(Environment.NewLine));
                output.Append("Dates attended:").Append(Environment.NewLine);
                student.DatesAttended
                    .OrderBy(d => d)
                    .ToList()
                    .ForEach(date => output.Append($"-- {date:dd/MM/yyyy}").Append(Environment.NewLine));
            }
            Console.Write(output);
        }
    }

    internal class Student
    {
        public string Name { get; }
        public List<string> Comments { get; }
        public List<DateTime> DatesAttended { get; }

        public Student(string name)
        {
            Name = name;
            Comments = new List<string>();
            DatesAttended = new List<DateTime>();
        }
    }
}