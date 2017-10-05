using System;
using System.Collections.Generic;
using System.Linq;

namespace SortNumbers
{
    internal class SortNumbers
    {
        public static void Main(string[] args)
        {
            var list = ParseInput(Console.ReadLine());
            list.Sort();
            Console.WriteLine(string.Join(" <= ", list));
        }

        private static List<double> ParseInput(string input)
        {
            return input.Split(' ').Select(double.Parse).ToList();
        }
    }
}