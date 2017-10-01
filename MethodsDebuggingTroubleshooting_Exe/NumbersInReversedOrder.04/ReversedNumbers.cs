using System;
using System.Text;

namespace NumbersInReversedOrder
{
    internal class ReversedNumbers
    {
        public static void Main(string[] args)
        {
            var num = Console.ReadLine();
            PrintReversed(num);
        }

        private static void PrintReversed(string num)
        {
            var output = new StringBuilder();
            for (int i = num.Length - 1; i >= 0; i--)
            {
                output.Append(num[i]);
            }
            Console.Write(output);
        }
    }
}