using System;
using System.Collections.Generic;

namespace SplitByWordCasing
{
    internal class SplitByCasing
    {
        public static void Main(string[] args)
        {
            Process(Console.ReadLine());
        }

        private static void Process(string input)
        {
            var words = input.Split(new [] {',', ';', ' ', '.', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']'},
                StringSplitOptions.RemoveEmptyEntries );
            var lower = new List<string>();
            var mixed = new List<string>();
            var upper = new List<string>();
            foreach (var word in words)
            {
                AddToList(lower, mixed, upper, word);
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lower)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixed)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upper)}");
        }

        private static void AddToList(List<string> lower, List<string> mixed, List<string> upper, string word)
        {
            var lowerCount = 0;
            var upperCount = 0;
            foreach (var character in word)
            {
                if (char.IsLower(character))
                {
                    lowerCount++;
                }
                else if (char.IsUpper(character))
                {
                    upperCount++;
                }
            }
            if (lowerCount == word.Length)
            {
                lower.Add(word);
                return;
            }
            if (upperCount == word.Length)
            {
                upper.Add(word);
                return;
            }
            mixed.Add(word);
        }
    }
}