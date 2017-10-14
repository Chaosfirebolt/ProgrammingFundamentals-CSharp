using System;
using System.Numerics;

namespace ConvertFromBase
{
    internal class ConvertFromBase
    {
        public static void Main(string[] args)
        {
            var data = ParseInput(Console.ReadLine());
            var fromBase = BigInteger.Parse(data[0]);
            var number = data[1];
            var converted = Convert(fromBase, number);
            Console.WriteLine(converted);
        }

        private static BigInteger Convert(BigInteger fromBase, string number)
        {
            BigInteger result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                var index = number.Length - 1 - i;
                result += BigInteger.Parse(number[index].ToString()) * BigInteger.Pow(fromBase, i);
            }
            return result;
        }
        
        private static string[] ParseInput(string input)
        {
            return input.Split(' ');
        }
    }
}