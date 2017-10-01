using System;
using System.Collections.Generic;

namespace PrimesInRange
{
    internal class PrimesRange
    {
        public static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var primes = GetPrimesInRange(start, end);
            Console.Write(string.Join(", ", primes));
        }

        private static List<int> GetPrimesInRange(int start, int end)
        {
            var result = new List<int>();
            if (2 >= start && 2 <= end)
            {
                result.Add(2);
            }
            if (start % 2 == 0)
            {
                start++;
            }
            for (int number = start; number <= end; number += 2)
            {
                if (IsPrime(number))
                {
                    result.Add(number);
                }
            }
            return result;
        }
        
        private static bool IsPrime(int n)
        {
            switch (n)
            {
                case 0:
                case 1:
                    return false;
                case 2:
                case 3:
                    return true;
                default:
                    if (n % 2 == 0)
                    {
                        return false;
                    }
                    var boundary = (int) Math.Sqrt(n);
                    for (int i = 3; i <= boundary; i += 2)
                    {
                        if (n % i == 0)
                        {
                            return false;
                        }
                    }
                    return true;
            }
        }
    }
}