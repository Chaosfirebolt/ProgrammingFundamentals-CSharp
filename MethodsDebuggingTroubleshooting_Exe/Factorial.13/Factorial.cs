using System;
using System.Collections.Generic;
using System.Numerics;

namespace Factorial
{
    internal class Factorial
    {
        private static readonly Dictionary<BigInteger, BigInteger> Memo = new Dictionary<BigInteger, BigInteger>();
        
        public static void Main(string[] args)
        {
            var number = new BigInteger(int.Parse(Console.ReadLine()));
            InitializeMemo();
            var result = CalcFactorial(number);
            Console.Write(result);
        }

        private static void InitializeMemo()
        {
            Memo[1] = 1;
        }

        private static BigInteger CalcFactorial(BigInteger number)
        {
            if (Memo.ContainsKey(number))
            {
                return Memo[number];
            }

            var factorial = number * CalcFactorial(number - 1);
            Memo[number] = factorial;
            return factorial;
        }
    }
}