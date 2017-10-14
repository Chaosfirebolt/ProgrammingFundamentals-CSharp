using System;
using System.Text;
using System.Text.RegularExpressions;

namespace MatchDates
{
    internal class MatchDates
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == null)
            {
                return;
            }
            var matches = Regex.Matches(input, @"\b(?<day>\d{2})([.\-/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})");
            var output = new StringBuilder();
            foreach (Match match in matches)
            {
                output.Append($"Day: {match.Groups["day"].Value}, Month: {match.Groups["month"].Value}, Year: {match.Groups["year"].Value}")
                    .Append(Environment.NewLine);
            }
            Console.Write(output);
        }
    }
}