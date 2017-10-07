using System;
using System.Collections.Generic;
using System.Linq;

namespace FoldAndSum
{
    internal class FoldAndSum
    {
        public static void Main(string[] args)
        {
            var list = ParseInput(Console.ReadLine());
            var sideCount = list.Count / 4;
            var row1 = list.Take(sideCount).Reverse().ToList();
            row1.AddRange(list.Skip(list.Count - sideCount).Reverse().ToList());
            var row2 = list.GetRange(sideCount, list.Count / 2);
            var sum = row1.Select((num, index) => num + row2[index]);
            Console.WriteLine(string.Join(" ", sum));
        }

        private static List<int> ParseInput(string input)
        {
            return input.Split(' ').Select(int.Parse).ToList();
        }
    }
}