using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Palindromes
{
    internal class Palindromes
    {
        public static void Main(string[] args)
        {
            var words = ParseInput(Console.ReadLine());
            var palindromes = new HashSet<string>();
            foreach (var word in words)
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }
            Console.Write(string.Join(", ", palindromes.OrderBy(w => w)));
        }

        private static bool IsPalindrome(string word)
        {
            var bound = word.Length / 2;
            for (int i = 0; i < bound; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        private static string[] ParseInput(string input)
        {
            return Regex.Split(input, "[\\s+,\\.?!]").Where(w => w != "").ToArray();
        }
    }
}