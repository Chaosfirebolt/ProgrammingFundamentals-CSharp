using System;

namespace MaxMethod
{
    internal class MaxMethod
    {
        public static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var max = GetMax(a, b);
            max = GetMax(max, c);
            Console.Write(max);
        }

        private static int GetMax(int a, int b)
        {
            return a >= b ? a : b;
        }
    }
}