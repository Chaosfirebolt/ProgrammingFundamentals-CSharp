using System;
using System.Collections.Generic;
using System.Text;

namespace CountRealNumbers
{
    internal class CountRealNumbers
    {
        public static void Main(string[] args)
        {
            var numbers = ParseInput(Console.ReadLine());
            var counts = new SortedDictionary<double, int>();
            foreach (var number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number] += 1;
                }
                else
                {
                    counts.Add(number, 1);
                }
            }
            var output = new StringBuilder();
            foreach (var pair in counts)
            {
                output.Append($"{pair.Key} -> {pair.Value}").Append(Environment.NewLine);
            }
            Console.Write(output);
        }

        private static double[] ParseInput(string input)
        {
            var numbers = input.Split(' ');
            var result = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = double.Parse(numbers[i]);
            }
            return result;
        }
    }
}