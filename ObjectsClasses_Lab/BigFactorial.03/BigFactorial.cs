using System;
using System.Numerics;

namespace BigFactorial
{
    internal class BigFactorial
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var factorial = new BigInteger(1);
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}