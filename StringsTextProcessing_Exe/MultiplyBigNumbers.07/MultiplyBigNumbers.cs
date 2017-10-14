using System;
using System.Collections.Generic;
using System.Text;

namespace MultiplyBigNumbers
{
    internal class MultiplyBigNumbers
    {
        public static void Main(string[] args)
        {
            var a = new BigNumber(Console.ReadLine());
            var b = new BigNumber(Console.ReadLine());
            var result = a.Multiply(b);
            Console.Write(result);
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

        public BigNumber Multiply(BigNumber number)
        {
            var first = GetLonger(Value, number.Value);
            var second = GetShorter(Value, number.Value);
            var result = Multiply(first, second);
            return new BigNumber(result);
        }

        private static string Multiply(string first, string second)
        {
            var operands = new LinkedList<BigNumber>();
            for (int i = second.Length - 1; i >= 0; i--)
            {
                var a = int.Parse(second[i].ToString());
                var digits = new LinkedList<int>();
                for (int count = 0; count < operands.Count; count++)
                {
                    digits.AddFirst(0);
                }
                var increase = 0;
                for (int j = first.Length - 1; j >= 0; j--)
                {
                    var b = int.Parse(first[j].ToString());
                    var next = a * b + increase;
                    increase = next / 10;
                    next %= 10;
                    digits.AddFirst(next);
                }
                digits.AddFirst(increase);
                RemoveStartingZeroes(digits);
                operands.AddLast(new BigNumber(BuildValueString(digits)));
            }
            var result = operands.First.Value;
            operands.RemoveFirst();
            while (operands.Count > 0)
            {
                result = result.Add(operands.First.Value);
                operands.RemoveFirst();
            }
            return result.ToString();
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
            return BuildValueString(digits);
        }

        private static string BuildValueString(LinkedList<int> digits)
        {
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