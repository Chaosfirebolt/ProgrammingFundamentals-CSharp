using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace QueryMess
{
    internal class QueryMess
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output = new StringBuilder();
            while (input != null && input != "END")
            {
                ProcessQuery(input, output);
                input = Console.ReadLine();
            }
            Console.Write(output);
        }

        private static void ProcessQuery(string query, StringBuilder output)
        {
            var pairs = new Dictionary<string, LinkedList<string>>();
            var tokens = query.Split(new[] {'?'}, StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length > 1)
            {
                query = tokens[1];
            }
            tokens = query.Split('&');
            var replaceRegex = new Regex(@"\+|%20");
            var reduceRegex = new Regex(@"\s+");
            foreach (var token in tokens)
            {
                var data = token.Split('=');
                var key = DecodeSpaces(data[0], replaceRegex, reduceRegex);
                var value = DecodeSpaces(data[1], replaceRegex, reduceRegex);
                if (!pairs.ContainsKey(key))
                {
                    pairs.Add(key, new LinkedList<string>());
                }
                pairs[key].AddLast(value);
            }
            foreach (var pair in pairs)
            {
                output.Append($"{pair.Key}=[{string.Join(", ", pair.Value)}]");
            }
            output.Append(Environment.NewLine);
        }

        private static string DecodeSpaces(string str, Regex replaceRegex, Regex reduceRegex)
        {
            const string replacement = " ";
            var temp = replaceRegex.Replace(str, replacement);
            return reduceRegex.Replace(temp, replacement).Trim();
        }
    }
}