using System;
using System.Collections.Generic;

namespace TripleSum
{
    internal class TripleSum
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var numbers = new int[input.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }
            
            var sums = new List<string>();
            GenerateSums(numbers, sums);
            Console.Write(sums.Count > 0 ? string.Join(Environment.NewLine, sums) : "No");
        }

        private static void GenerateSums(int[] numbers, ICollection<string> sums)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                var a = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    var b = numbers[j];
                    if (ContainsSum(numbers, a + b))
                    {
                        sums.Add($"{a} + {b} == {a + b}");
                    }
                }
            }
        }

        private static bool ContainsSum(IEnumerable<int> numbers, int sum)
        {
            foreach (var number in numbers)
            {
                if (number == sum)
                {
                    return true;
                }
            }
            return false;
        }
    }
}