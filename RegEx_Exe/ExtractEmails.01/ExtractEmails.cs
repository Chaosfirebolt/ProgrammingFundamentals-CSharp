using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    internal class ExtractEmails
    {
        public static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var emails = Regex.Matches(text, @"[a-zA-Z0-9]+[a-zA-Z0-9._-]*[a-zA-Z0-9]*@[a-zA-Z]+[a-zA-Z-]*[a-zA-Z]+(\.[a-zA-Z]+[a-zA-Z-]*[a-zA-Z]+)+");
            var output = new StringBuilder();
            foreach (Match email in emails)
            {
                var prevIndex = email.Index - 1;
                if (prevIndex >= 0)
                {
                    var character = text[prevIndex];
                    if (character == '.' || character == '_' || character == '-')
                    {
                        continue;
                    }
                }
                output.Append(email.Value).Append(Environment.NewLine);
            }
            Console.Write(output);
        }
    }
}