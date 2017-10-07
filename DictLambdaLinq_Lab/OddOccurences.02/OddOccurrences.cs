using System;
using System.Collections.Generic;
using System.Text;

namespace OddOccurences
{
    internal class OddOccurrences
    {
        public static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ');
            var counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word] += 1;
                }
                else
                {
                    counts.Add(word, 1);
                }
            }
            var output = new StringBuilder();
            foreach (var pair in counts)
            {
                if (pair.Value % 2 != 0)
                {
                    output.Append($"{pair.Key}").Append(", ");
                }
            }
            if (output.Length > 0)
            {
                output.Remove(output.Length - 2, 2);
            }
            Console.Write(output);
        }
    }
}