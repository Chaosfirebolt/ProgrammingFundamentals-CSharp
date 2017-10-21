using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace AdvertisementMessage
{
    internal class AM
    {
        public static void Main(string[] args)
        {
            var path = GetParentProjectPath(Environment.CurrentDirectory, 0, 2) + @"\IO";
            var lines = File.ReadAllLines(path + @"\input.txt");
            var phrases = Phrases();
            var events = Events();
            var authors = Authors();
            var cities = Cities();
            var count = int.Parse(lines[0]);
            var rnd = new Random();
            var output = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                output.Append($"{GetRandom(phrases, rnd)} {GetRandom(events, rnd)} {GetRandom(authors, rnd)} – {GetRandom(cities, rnd)}")
                    .Append(Environment.NewLine);
            }
            File.WriteAllText(path + @"\output.txt", output.ToString().Trim());
        }
        
        private static string GetRandom(List<string> collection, Random random)
        {
            Thread.Sleep(100);
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
}