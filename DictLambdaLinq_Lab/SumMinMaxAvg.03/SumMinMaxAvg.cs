using System;
using System.Collections.Generic;
using System.Linq;

namespace SumMinMaxAvg
{
    internal class SumMinMaxAvg
    {
        public static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var numbers = new List<int>();
            for (int i = 0; i < count; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}