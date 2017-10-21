using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace BookLibraryModification
{
    internal class BLM
    {
        public static void Main(string[] args)
        {
            var path = GetParentProjectPath(Environment.CurrentDirectory, 0, 2) + @"\IO";
            var lines = File.ReadAllLines(path + @"\input.txt");
            var count = int.Parse(lines[0]);
            var library = new Library();
            for (int i = 1; i <= count; i++)
            {
                library.Books.Add(ParseInput(lines[i]));
            }
            var date = ParseDate(lines[count + 1]);
            var output = new StringBuilder();
            library.Books
                .Where(b => b.ReleaseDate > date)
                .OrderBy(b => b.ReleaseDate)
                .ThenBy(b => b.Title)
                .ToList()
                .ForEach(b => output.Append($"{b.Title} -> {b.ReleaseDate:dd.MM.yyyy}").Append(Environment.NewLine));
            File.WriteAllText(path + @"\output.txt", output.ToString().Trim());
        }
        
        private static Book ParseInput(string input)
        {
            var data = input.Split(' ');
            return new Book(data[0], ParseDate(data[3]));
        }

        private static DateTime ParseDate(string date)
        {
            return DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);
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
    
    internal class Library
    {
        public List<Book> Books { get; }

        public Library()
        {
            Books = new List<Book>();
        }
    }

    internal class Book
    {
        public string Title { get; }
        public DateTime ReleaseDate { get; }

        public Book(string title, DateTime releaseDate)
        {
            Title = title;
            ReleaseDate = releaseDate;
        }
    }
}