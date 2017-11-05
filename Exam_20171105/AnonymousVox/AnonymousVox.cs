using System;
using System.Text;
using System.Text.RegularExpressions;

namespace AnonymousVox
{
    internal class AnonymousVox
    {
        public static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var textMatches = Regex.Matches(text, @"([a-zA-Z]+)(.+)(\1)");
            var valuesEnumerator = Regex.Matches(Console.ReadLine(), @"{([^{}]+)}").GetEnumerator();
            foreach (Match textMatch in textMatches)
            {
                var replacement = new StringBuilder();
                replacement.Append(textMatch.Groups[1].Value);
                if (valuesEnumerator.MoveNext())
                {
                    var match = (Match) valuesEnumerator.Current;
                    replacement.Append(match.Groups[1].Value);
                }
                else
                {
                    replacement.Append(textMatch.Groups[2].Value);
                }
                replacement.Append(textMatch.Groups[3].Value);
                text = text.Replace(textMatch.Groups[0].Value, replacement.ToString());
            }
            Console.Write(text);
        }
    }
}