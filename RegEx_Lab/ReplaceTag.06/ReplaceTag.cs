using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ReplaceTag
{
    internal class ReplaceTag
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();
            while (input != null && input != "end")
            {
                sb.Append(input).Append(Environment.NewLine);
                input = Console.ReadLine();
            }
            var text = sb.ToString();
            var matches = Regex.Matches(text, @"<a(.+?)>(.+?)</a>");
            foreach (Match match in matches)
            {
                text = text.Replace(match.Value, Replacement(match.Groups[1].Value, match.Groups[2].Value));
            }
            Console.Write(text);
        }
        
        private static string Replacement(string href, string val)
        {
            return $"[URL{href}]{val}[/URL]";
        }
    }
}