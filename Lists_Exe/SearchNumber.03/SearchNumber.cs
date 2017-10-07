using System;
using System.Collections.Generic;

namespace SearchNumber
{
    internal class SearchNumber
    {
        public static void Main(string[] args)
        {
            var numbers = ParseList(Console.ReadLine());
            var data = ParseSearchData(Console.ReadLine());
            var startIndex = data[1];
            var length = data[0] - startIndex;
            var subList = numbers.GetRange(startIndex, length);
            Console.WriteLine(subList.Contains(data[2]) ? "YES!" : "NO!");
        }

        private static int[] ParseSearchData(string input)
        {
            var numbers = input.Split(' ');
            var result = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = int.Parse(numbers[i]);
            }
            return result;
        }

        private static List<int> ParseList(string input)
        {
            var numbers = input.Split(' ');
            var result = new List<int>(numbers.Length);
            foreach (var number in numbers)
            {
                result.Add(int.Parse(number));
            }
            return result;
        }
    }
}