using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BookLibrary
{
    internal class BookLibrary
    {
        public static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var library = new Library("My library");
            for (int i = 0; i < count; i++)
            {
                library.Books.Add(ParseInput(Console.ReadLine()));
            }
            var output = new StringBuilder();
            library.Books
                .GroupBy(b => b.Author)
                .OrderByDescending(gr => gr.Sum(b => b.Price))
                .ThenBy(gr => gr.Key)
                .ToList()
                .ForEach(gr => output.Append($"{gr.Key} -> {gr.Sum(b => b.Price):F2}").Append(Environment.NewLine));
            Console.Write(output);
        }

        private static Book ParseInput(string input)
        {
            var data = input.Split(' ');
            return new Book(data[0], data[1], data[2], ParseDate(data[3]), data[4], decimal.Parse(data[5]));
        }

        private static DateTime ParseDate(string date)
        {
            return DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        }
    }

    internal class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Library(string name)
        {
            Name = name;
            Books = new List<Book>();
        }
    }

    internal class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string Publisher { get; }
        public DateTime ReleaseDate { get; }
        public string ISBN { get; }
        public decimal Price { get; }

        public Book(string title, string author, string publisher, DateTime releaseDate, string isbn, decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            ISBN = isbn;
            Price = price;
        }
    }
}