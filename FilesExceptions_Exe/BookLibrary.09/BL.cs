using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BookLibrary
{
    internal class BL
    {
        public static void Main(string[] args)
        {
            var path = GetParentProjectPath(Environment.CurrentDirectory, 0, 2) + @"\IO";
            var lines = File.ReadAllLines(path + @"\input.txt");
            var library = new Library();
            for (int i = 1; i < lines.Length; i++)
            {
                library.Books.Add(ParseInput(lines[i]));
            }
            var output = new StringBuilder();
            library.Books
                .GroupBy(b => b.Author)
                .OrderByDescending(gr => gr.Sum(b => b.Price))
                .ThenBy(gr => gr.Key)
                .ToList()
                .ForEach(gr => output.Append($"{gr.Key} -> {gr.Sum(b => b.Price):F2}").Append(Environment.NewLine));
            File.WriteAllText(path + @"\output.txt", output.ToString().Trim());
        }
        
        private static Book ParseInput(string input)
        {
            var data = input.Split(' ');
            return new Book(data[0], data[1], decimal.Parse(data[5]));
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
        private string Title { get; }
        public string Author { get; }
        public decimal Price { get; }

        public Book(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
    }
}