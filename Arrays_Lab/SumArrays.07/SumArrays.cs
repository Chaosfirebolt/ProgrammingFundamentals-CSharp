using System;
using System.Collections.Generic;

namespace SumArrays
{
    internal class SumArrays
    {
        public static void Main(string[] args)
        {
            var first = ParseInput(Console.ReadLine());
            var second = ParseInput(Console.ReadLine());
            EqualizeLists(first, second);
            var sums = new List<int>();
            for (int i = 0; i < first.Count; i++)
            {
                sums.Add(first[i] + second[i]);
            }
            foreach (var sum in sums)
            {
                Console.WriteLine(sum);
            }
        }

        private static void EqualizeLists(IList<int> first, IList<int> second)
        {
            if (first.Count > second.Count)
            {
                Duplicate(second, first.Count);
            }
            else
            {
                Duplicate(first, second.Count);
            }
        }

        private static void Duplicate(IList<int> list, int target)
        {
            var index = 0;
            var size = list.Count;
            while (list.Count < target)
            {
                list.Add(list[index]);
                index = (index + 1) % size;
            }
        }

        private static List<int> ParseInput(string input)
        {
            var numbers = input.Split(' ');
            var list = new List<int>(numbers.Length);
            foreach (var number in numbers)
            {
                list.Add(int.Parse(number));
            }
            return list;
        }
    }
}