using System;
using System.Linq;

namespace LargestThreeNumbers
{
    internal class LargestThreeNumbers
    {
        public static void Main(string[] args)
        {
            ProcessInput(Console.ReadLine());
        }

        private static void ProcessInput(string input)
        {
            var nums = input.Split(' ')
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToArray();
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}