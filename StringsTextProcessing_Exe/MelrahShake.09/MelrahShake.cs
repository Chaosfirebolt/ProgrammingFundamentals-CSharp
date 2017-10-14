using System;
using System.Collections.Generic;
using System.Text;

namespace MelrahShake
{
    internal class MelrahShake
    {
        public static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();
            if (text == null || pattern == null)
            {
                return;
            }

            var indexes = Matches(text, pattern);
            var output = new StringBuilder();
            while (indexes.Count > 1 && pattern.Length > 0)
            {
                output.Append("Shaked it.").Append(Environment.NewLine);
                text = RemoveMatch(text, indexes.Last.Value, pattern.Length);
                text = RemoveMatch(text, indexes.First.Value, pattern.Length);
                pattern = UpdatePattern(pattern);
                indexes = Matches(text, pattern);
            }
            output.Append("No shake.").Append(Environment.NewLine).Append(text);
            Console.Write(output);
        }

        private static string RemoveMatch(string text, int index, int length)
        {
            return text.Remove(index, length);
        }

        private static LinkedList<int> Matches(string text, string pattern)
        {
            var indexes = new LinkedList<int>();
            for (int i = 0; i <= text.Length - pattern.Length; i++)
            {
                if (text.Substring(i, pattern.Length) == pattern)
                {
                    indexes.AddLast(i);
                }
            }
            return indexes;
        }

        private static string UpdatePattern(string pattern)
        {
            return pattern.Remove(pattern.Length / 2, 1);
        }
    }
}