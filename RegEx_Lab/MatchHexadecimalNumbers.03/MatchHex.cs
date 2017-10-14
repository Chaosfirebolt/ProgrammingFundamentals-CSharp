using System;
using System.Text;
using System.Text.RegularExpressions;

namespace MatchHexadecimalNumbers
{
    internal class MatchHex
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == null)
            {
                return;
            }
            var hexNumbers = Regex.Matches(input, "(0x|\\b)[0-9A-F]+\\b");
            var output = new StringBuilder();
            foreach (Match number in hexNumbers)
            {
                output.Append(number.Value).Append(" ");
            }
            Console.Write(output);
        }
    }
}