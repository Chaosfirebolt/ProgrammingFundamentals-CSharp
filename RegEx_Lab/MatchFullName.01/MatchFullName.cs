using System;
using System.Text;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    internal class MatchFullName
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var fullNames = Regex.Matches(input, "\\b[A-Z][a-z]+ [A-Z][a-z]+\\b");
            var output = new StringBuilder();
            foreach (Match fullName in fullNames)
            {
                output.Append(fullName.Value).Append(" ");
            }
            Console.Write(output);
        }
    }
}