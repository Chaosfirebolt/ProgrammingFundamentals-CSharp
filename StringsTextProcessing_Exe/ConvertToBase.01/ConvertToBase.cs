using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConvertToBase
{
    internal class ConvertToBase
    {
        public static void Main(string[] args)
        {
            var data = ParseInput(Console.ReadLine());
            var toBase = data[0];
            var number = data[1];
            var converted = Convert(toBase, number);
            Console.WriteLine(converted);
        }

        private static string Convert(BigInteger toBase, BigInteger number)
        {
            var args = new Stack<BigInteger>();
            while (number > 0)
            {
                args.Push(number % toBase);
                number /= toBase;
            }
            var result = new StringBuilder();
            while (args.Count > 0)
            {
                result.Append(args.Pop());
            }
            return result.ToString();
        }

        private static BigInteger[] ParseInput(string input)
        {
            return input.Split(' ').Select(BigInteger.Parse).ToArray();
        }
    }
}