using System;

namespace PrimeChecker
{
    internal class PrimalityChecker
    {
        public static void Main(string[] args)
        {
            Console.Write(IsPrime(ulong.Parse(Console.ReadLine())));
        }

        private static bool IsPrime(ulong n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }
            if (n == 2 || n == 3)
            {
                return true;
            }
            if (n % 2 == 0)
            {
                return false;
            }
            var boundary = (int) Math.Sqrt(n);
            for (int i = 3; i <= boundary; i += 2)
            {
                if (n % (ulong)i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}