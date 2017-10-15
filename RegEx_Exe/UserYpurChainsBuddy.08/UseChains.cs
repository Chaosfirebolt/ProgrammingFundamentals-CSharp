using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserYourChainsBuddy
{
    internal class UseChains
    {
        private static readonly Regex ReplaceRegex = new Regex(@"[^a-z0-9]");
        private static readonly Regex ReduceRegex = new Regex(@"\s+");
        
        public static void Main(string[] args)
        {
            var values = ExtractTagValues(Console.ReadLine());
            var decoded = new StringBuilder();
            foreach (var value in values)
            {
                var temp = DecodeSpaces(value);
                foreach (var character in temp)
                {
                    var dec = character;
                    if (character >= 97 && character <= 109)
                    {
                        dec = (char)(character + 13);
                    }
                    else
                    {
                        if (character >= 110 && character <= 122)
                        {
                            dec = (char)(character - 13);
                        }
                    }
                    decoded.Append(dec);
                }
            }
            Console.Write(decoded);
        }

        private static LinkedList<string> ExtractTagValues(string input)
        {
            var matches = Regex.Matches(input, @"<p>(.+?)<\/p>");
            var result = new LinkedList<string>();
            foreach (Match match in matches)
            {
                result.AddLast(match.Groups[1].Value);
            }
            return result;
        }
        
        private static string DecodeSpaces(string str)
        {
            const string replacement = " ";
            var temp = ReplaceRegex.Replace(str, replacement);
            return ReduceRegex.Replace(temp, replacement);
        }
    }
}