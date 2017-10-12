using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StudentGroups
{
    internal class StudentGroups
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var towns = new List<Town>();
            while (input != null && input != "End")
            {
                if (input.Contains("=>"))
                {
                    var data = Regex.Split(input, "\\s*=>\\s*");
                    towns.Add(new Town(data[0], int.Parse(data[1].Split(' ')[0])));
                }
                else
                {
                    var town = towns[towns.Count - 1];
                    var data = Regex.Split(input, "\\s*\\|\\s*");
                    var student = new Student(data[0], data[1], ParseDate(data[2]));
                    town.Students.Add(student);
                }
                input = Console.ReadLine();
            }

            var output = new StringBuilder();
            var groupCount = 0;
            towns
                .OrderBy(t => t.Name)
                .ToList()
                .ForEach(town =>
                {
                    var groups = town.CreateGroups();
                    foreach (var group in groups)
                    {
                        groupCount++;
                        output.Append($"{town.Name} => {string.Join(", ", group.Select(gr => gr.Email))}").Append(Environment.NewLine);
                    }
                });
            Console.WriteLine($"Created {groupCount} groups in {towns.Count} towns:");
            Console.Write(output);
        }

        private static DateTime ParseDate(string input)
        {
            return DateTime.ParseExact(input, "d-MMM-yyyy", CultureInfo.InvariantCulture);
        }
    }

    internal class Town
    {
        public string Name { get; }
        public int SeatCount { get; }
        public List<Student> Students { get; }

        public Town(string name, int seatCount)
        {
            Name = name;
            SeatCount = seatCount;
            Students = new List<Student>();
        }

        public List<List<Student>> CreateGroups()
        {
            var groups = new List<List<Student>> {new List<Student>(SeatCount)};
            Students
                .OrderBy(st => st.RegDate)
                .ThenBy(st => st.Name)
                .ThenBy(st => st.Email)
                .ToList()
                .ForEach(student =>
                {
                    var group = groups[groups.Count - 1];
                    if (group.Count == SeatCount)
                    {
                        group = new List<Student>();
                        groups.Add(group);
                    }
                    group.Add(student);
                });
            return groups;
        }
    }

    internal class Student
    {
        public string Name { get; }
        public string Email { get; }
        public DateTime RegDate { get; }

        public Student(string name, string email, DateTime regDate)
        {
            Name = name;
            Email = email;
            RegDate = regDate;
        }
    }
}