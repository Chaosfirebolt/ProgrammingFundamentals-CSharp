using System;
using System.Collections.Generic;

namespace RemoveNegativesAndReverse
{
    internal class RemoveReverse
    {
        public static void Main(string[] args)
        {
            var resultList = Process(Console.ReadLine());
            Console.Write(resultList.Count == 0 ? "empty" : string.Join(" ", resultList));
        }

        private static IList<int> Process(string input)
        {
            var result = new List<int>();
            var numbers = input.Split(' ');
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                var number = int.Parse(numbers[i]);
                if (number >= 0)
                {
                    result.Add(number);
                }
            }
            return result;
        }
    }
}