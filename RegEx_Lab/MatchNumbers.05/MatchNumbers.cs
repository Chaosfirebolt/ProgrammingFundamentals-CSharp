using System;
using System.Text;
using System.Text.RegularExpressions;

namespace MatchNumbers
{
    internal class MatchNumbers
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == null)
            {
                return;
            }
            var matches = Regex.Matches(input, @"(^|(?<=\s))(-*?\d+(\.\d*)*)($|(?=\s))");
            var output = new StringBuilder();
            foreach (Match match in matches)
            {
                output.Append(match.Groups[2]).Append(" ");
            }
            Console.WriteLine(output);
        }
    }
}