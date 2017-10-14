using System;
using System.Collections.Generic;
using System.Text;

namespace SumBigNumbers
{
    internal class SumBigNumbers
    {
        public static void Main(string[] args)
        {
            var firstNumber = new BigNumber(Console.ReadLine());
            var secondNumber = new BigNumber(Console.ReadLine());
            var result = firstNumber.Add(secondNumber);
            Console.Write(result.ToString());
        }
    }

    internal class BigNumber
    {
        private string Value { get; }

        public BigNumber(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }

        public BigNumber Add(BigNumber number)
        {
            var first = GetLonger(Value, number.Value);
            var diff = Math.Abs(Value.Length - number.Value.Length);
            var second = PadLeftZeroes(GetShorter(Value, number.Value), diff);
            var sum = Add(first, second);
            return new BigNumber(sum);
        }

        private static string Add(string first, string second)
        {
            var digits = new LinkedList<int>();
            var nextIncr = 0;
            for (int i = first.Length - 1; i >= 0; i--)
            {
                var a = int.Parse(first[i].ToString());
                var b = int.Parse(second[i].ToString());
                var next = a + b + nextIncr;
                nextIncr = next / 10;
                next %= 10;
                digits.AddFirst(next);
            }
            digits.AddFirst(nextIncr);
            RemoveStartingZeroes(digits);
            var result = new StringBuilder();
            foreach (var digit in digits)
            {
                result.Append(digit);
            }
            return result.ToString();
        }

        private static void RemoveStartingZeroes(LinkedList<int> digits)
        {
            while (digits.Count > 1 && digits.First.Value == 0)
            {
                digits.RemoveFirst();
            }
        }
        
        private string GetShorter(string value, string otherValue) {
            return value.Length <= otherValue.Length ? value : otherValue;
        }

        private string GetLonger(string value, string otherValue) {
            return value.Length > otherValue.Length ? value : otherValue;
        }

        private string PadLeftZeroes(string value, int count) {
            var sb = new StringBuilder();
            for (int i = 0; i < count; i++) {
                sb.Append("0");
            }
            sb.Append(value);
            return sb.ToString();
        }
    }
}