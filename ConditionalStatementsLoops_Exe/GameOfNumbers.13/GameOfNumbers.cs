using System;

namespace GameOfNumbers
{
    internal class GameOfNumbers
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());
            
            if (magicNum < n * 2 || magicNum > m * 2) {
                Console.WriteLine("{0:F0} combinations - neither equals {1}", Math.Pow(m - n + 1, 2), magicNum);
            } else {
                var first = magicNum - n;
                if (first > m) {
                    first = m;
                }
                var second = magicNum - first;
                Console.WriteLine("Number found! {0} + {1} = {2}", first, second, magicNum);
            }
        }
    }
}