using System;

namespace MultiplyEvensByOdds
{
    internal class Multiply
    {
        public static void Main(string[] args)
        {
            var number = Console.ReadLine();
            Console.Write(CalcResult(number));
        }

        private static long CalcResult(string number)
        {
            var sumEvens = 0L;
            var sumOdds = 0L;
            var startIndex = number.StartsWith("-") ? 1 : 0;
            for (int i = startIndex; i < number.Length; i++)
            {
                var digit = int.Parse(number[i].ToString());
                if (digit % 2 == 0)
                {
                    sumEvens += digit;
                }
                else
                {
                    sumOdds += digit;
                }
            }
            return sumEvens * sumOdds;
        }
    }
}