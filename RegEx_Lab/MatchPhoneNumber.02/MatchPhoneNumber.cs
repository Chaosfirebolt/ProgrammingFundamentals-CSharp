using System;
using System.Text;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    internal class MatchPhoneNumber
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == null)
            {
                return;
            }
            var validPhones = Regex.Matches(input, "( |^)(\\+359( |-)2\\3\\d{3}\\3\\d{4})\\b");
            var output = new StringBuilder();
            foreach (Match phone in validPhones)
            {
                output.Append(phone.Groups[2]).Append(", ");
            }
            if (output.Length > 0)
            {
                output.Remove(output.Length - 2, 2);
            }
            Console.Write(output);
        }
    }
}