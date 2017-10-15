using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    internal class ValidUsernames
    {
        public static void Main(string[] args)
        {
            var usernames = ParseInput(Console.ReadLine());
            var valid = new List<string>();
            foreach (var username in usernames)
            {
                if (Regex.Match(username, @"^[a-zA-Z]\w{2,24}$").Success)
                {
                    valid.Add(username);
                }
            }
            PrintUsernamesHighestSum(valid);
        }

        private static void PrintUsernamesHighestSum(List<string> validUsernames)
        {
            var first = "";
            var second = "";
            var sum = 0;
            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                var curr = validUsernames[i].Length + validUsernames[i + 1].Length;
                if (curr > sum)
                {
                    sum = curr;
                    first = validUsernames[i];
                    second = validUsernames[i + 1];
                }
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
        }

        private static string[] ParseInput(string input)
        {
            return Regex.Split(input, @"[/\\ \(\)]");
        }
    }
}