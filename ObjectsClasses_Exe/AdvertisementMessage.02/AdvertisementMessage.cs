using System;
using System.Collections.Generic;
using System.Text;

namespace AdvertisementMessage
{
    internal class AdvertisementMessage
    {
        public static void Main(string[] args)
        {
            var phrases = Phrases();
            var events = Events();
            var authors = Authors();
            var cities = Cities();
            var count = int.Parse(Console.ReadLine());
            var rnd = new Random();
            var output = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                output.Append($"{GetRandom(phrases, rnd)} {GetRandom(events, rnd)} {GetRandom(authors, rnd)} – {GetRandom(cities, rnd)}")
                    .Append(Environment.NewLine);
            }
            Console.Write(output);
        }

        private static string GetRandom(List<string> collection, Random random)
        {
            return collection[random.Next(collection.Count)];
        }

        private static List<string> Cities()
        {
            return new List<string>
                {
                    "Burgas",
                    "Sofia", 
                    "Plovdiv", 
                    "Varna",
                    "Ruse"
                };
        }

        private static List<string> Authors()
        {
            return new List<string>
                {
                    "Diana", 
                    "Petya",
                    "Stella", 
                    "Elena",
                    "Katya", 
                    "Iva",
                    "Annie", 
                    "Eva"
                };
        }

        private static List<string> Events()
        {
            return new List<string>
            {
                "Now I feel good.", 
                "I have succeeded with this product.", 
                "Makes miracles. I am happy of the results!", 
                "I cannot believe but now I feel awesome.", 
                "Try it yourself, I am very satisfied.", 
                "I feel great!"
            };
        }

        private static List<string> Phrases()
        {
            return new List<string>
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
        }
    }
}