using System;
using System.Text.RegularExpressions;

namespace TextFilter
{
    internal class TextFilter
    {
        public static void Main(string[] args)
        {
            var banned = ParseBanned(Console.ReadLine());
            var text = Console.ReadLine();
            if (text == null)
            {
                return;
            }
            foreach (var bannedWord in banned)
            {
                text = text.Replace(bannedWord, new string('*', bannedWord.Length));
            }
            Console.WriteLine(text);
        }

        private static string[] ParseBanned(string input)
        {
            return Regex.Split(input, ",\\s+");
        }
    }
}