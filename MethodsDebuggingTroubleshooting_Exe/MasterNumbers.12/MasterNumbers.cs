using System;
using System.Text;

namespace MasterNumbers
{
    internal class MasterNumbers
    {
        public static void Main(string[] args)
        {
            var boundary = int.Parse(Console.ReadLine());
            var outpput = new StringBuilder();
            for (int number = 1; number <= boundary; number++)
            {
                if (IsPalindrome(number) && IsSumDigitsDivisible(number) && HasEvenDigit(number))
                {
                    outpput.Append(number).Append(Environment.NewLine);
                }
            }
            Console.Write(outpput);
        }

        private static bool IsPalindrome(int number)
        {
            var str = number.ToString();
            var loopBound = str.Length / 2;
            for (int i = 0; i < loopBound; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsSumDigitsDivisible(int number)
        {
            var sum = 0;
            var str = number.ToString();
            foreach (var character in str)
            {
                sum += int.Parse(character.ToString());
            }
            return sum % 7 == 0;
        }

        private static bool HasEvenDigit(int number)
        {
            var str = number.ToString();
            foreach (var character in str)
            {
                if (int.Parse(character.ToString()) % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}