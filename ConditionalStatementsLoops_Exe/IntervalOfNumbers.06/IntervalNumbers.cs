using System;

namespace IntervalOfNumbers
{
    internal class IntervalNumbers
    {
        public static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var temp = first;
            first = Math.Min(first, second);
            second = Math.Max(temp, second);

            for (var i = first; i <= second; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}