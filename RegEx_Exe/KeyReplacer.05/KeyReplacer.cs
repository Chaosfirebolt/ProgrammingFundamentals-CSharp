using System;
using System.Text;
using System.Text.RegularExpressions;

namespace KeyReplacer
{
    internal class KeyReplacer
    {
        private static readonly char[] Chars = {'|', '<', '\\'};
        
        public static void Main(string[] args)
        {
            var keyString = Console.ReadLine();
            var text = Console.ReadLine();
            
            var indexes = Indexes(keyString);
            var regex = BuildRegex(keyString, indexes);
            var output = new StringBuilder();
            var matches = Regex.Matches(text, regex);
            foreach (Match match in matches)
            {
                output.Append(match.Groups[1].Value);
            }
            Console.Write(output.Length > 0 ? output.ToString() : "Empty result");
        }

        private static string BuildRegex(string keyString, int[] indexes)
        {
            var start = keyString.Substring(0, indexes[0]);
            var end = keyString.Substring(indexes[1] + 1);
            return $@"{start}(.*?){end}";
        }

        private static int[] Indexes(string keyString)
        {
            var result = new[]{-1, -1};
            var firstIndex = int.MaxValue;
            var lastIndex = int.MinValue;
            foreach (var c in Chars)
            {
                var index = keyString.IndexOf(c);
                if (index > -1)
                {
                    firstIndex = Math.Min(firstIndex, index);
                }

                index = keyString.LastIndexOf(c);
                if (index > -1)
                {
                    lastIndex = Math.Max(lastIndex, index);
                }
            }
            result[0] = firstIndex;
            result[1] = lastIndex;
            return result;
        }
    }
}