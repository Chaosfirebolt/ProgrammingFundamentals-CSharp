using System;
using System.Collections.Generic;

namespace SquareNumbers
{
    internal class SquareNumbers
    {
        public static void Main(string[] args)
        {
            var squareNumbers = Process(Console.ReadLine());
            Console.WriteLine(string.Join(" ", squareNumbers));
        }

        private static IList<int> Process(string input)
        {
            var numbers = input.Split(' ');
            var result = new List<int>();
            const double zero = 0;
            foreach (var str in numbers)
            {
                var number = int.Parse(str);
                if (zero.Equals(Math.Sqrt(number) % 1))
                {
                    result.Add(number);
                }
            }
            result.Sort((a, b) => b.CompareTo(a));
            return result;
        }
    }
}