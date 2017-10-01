using System;

namespace FibonacciNumbers
{
    internal class FibonacciNumbers
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write(Fib(n));
        }

        private static int Fib(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            var first = 1;
            var second = 1;
            var result = 0;
            for (int i = 2; i <= n; i++)
            {
                result = first + second;
                first = second;
                second = result;
            }
            return result;
        }
    }
}