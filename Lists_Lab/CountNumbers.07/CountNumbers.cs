using System;
using System.Collections.Generic;
using System.Text;

namespace CountNumbers
{
    internal class CountNumbers
    {
        public static void Main(string[] args)
        {
            var occurences = ProcessInput(Console.ReadLine());
            Print(occurences);
        }

        private static void Print(SortedDictionary<int, int> occurences)
        {
            var output = new StringBuilder();
            foreach (var pair in occurences)
            {
                output.Append($"{pair.Key} -> {pair.Value}").Append(Environment.NewLine);
            }
            Console.Write(output);
        }

        private static SortedDictionary<int, int> ProcessInput(string input)
        {
            var numbers = input.Split(' ');
            var occurenceCount = new SortedDictionary<int, int>();
            foreach (var str in numbers)
            {
                var number = int.Parse(str);
                if (!occurenceCount.ContainsKey(number))
                {
                    occurenceCount.Add(number, 1);
                }
                else
                {
                    occurenceCount[number] += 1;
                }
            }
            return occurenceCount;
        }
    }
}