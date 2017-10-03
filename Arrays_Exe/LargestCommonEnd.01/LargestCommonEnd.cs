using System;

namespace LargestCommonEnd
{
    internal class LargestCommonEnd
    {
        public static void Main(string[] args)
        {
            var first = Parse(Console.ReadLine());
            var second = Parse(Console.ReadLine());
            var bound = Math.Min(first.Length, second.Length);
            var result = Scan(first, second, bound);
            Console.WriteLine(result);
        }

        private static int Scan(string[] first, string[] second, int bound)
        {
            var leftMax = 0;
            var rightMax = 0;
            for (int i = 0; i < bound; i++)
            {
                if (first[i].Equals(second[i]))
                {
                    leftMax++;
                }
                if (first[first.Length - 1 - i].Equals(second[second.Length - 1 - i]))
                {
                    rightMax++;
                }
            }
            return Math.Max(leftMax, rightMax);
        }

        private static string[] Parse(string input)
        {
            return input.Split(' ');
        }
    }
}