using System;

namespace TestNumbers
{
    internal class TestNumbers
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var boundary = int.Parse(Console.ReadLine());
            var sum = 0;
            var count = 0;
            for (var i = n; i >= 1; i--)
            {
                for (var j = 1; j <= m; j++)
                {
                    sum += 3 * i * j;
                    count++;
                    if (sum >= boundary)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {sum} >= {boundary}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}