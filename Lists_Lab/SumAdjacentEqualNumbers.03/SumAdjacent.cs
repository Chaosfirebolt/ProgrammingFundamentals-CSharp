using System;
using System.Collections.Generic;

namespace SumAdjacentEqualNumbers
{
    internal class SumAdjacent
    {
        public static void Main(string[] args)
        {
            var numbers = ParseInput(Console.ReadLine());
            SumAdjacentEquals(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void SumAdjacentEquals(IList<double> numbers)
        {
            for (int i = 1; i < numbers.Count; i++)
            {
                if (!numbers[i - 1].Equals(numbers[i]))
                {
                    continue;
                }
                var num = numbers[i];
                numbers.RemoveAt(i);
                numbers[i - 1] += num;
                SumAdjacentEquals(numbers);
            }
        }

        private static IList<double> ParseInput(string input)
        {
            var numbers = input.Split(' ');
            var result = new List<double>(numbers.Length);
            foreach (var number in numbers)
            {
                result.Add(double.Parse(number));
            }
            return result;
        }
    }
}