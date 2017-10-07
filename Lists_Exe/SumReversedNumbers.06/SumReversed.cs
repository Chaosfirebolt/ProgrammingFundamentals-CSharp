using System;
using System.Text;

namespace SumReversedNumbers
{
    internal class SumReversed
    {
        public static void Main(string[] args)
        {
            var sum = CalcReversedSum(Console.ReadLine());
            Console.Write(sum);
        }

        private static int CalcReversedSum(string input)
        {
            var sum = 0;
            var numbers = input.Split(' ');
            foreach (var number in numbers)
            {
                sum += ReverseNumber(number);
            }
            return sum;
        }

        private static int ReverseNumber(string number)
        {
            var sb = new StringBuilder();
            for (int i = number.Length - 1; i >= 0; i--)
            {
                sb.Append(number[i]);
            }
            return int.Parse(sb.ToString());
        }
    }
}