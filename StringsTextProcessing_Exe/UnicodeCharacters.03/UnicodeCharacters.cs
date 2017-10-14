using System;
using System.Text;

namespace UnicodeCharacters
{
    internal class UnicodeCharacters
    {
        public static void Main(string[] args)
        {
            var text = Console.ReadLine();
            Console.WriteLine(Convert(text));
        }

        private static string Convert(string text)
        {
            var output = new StringBuilder();
            foreach (var character in text)
            {
                output.Append("\\u");
                output.Append($"{(int) character:x4}");
            }
            return output.ToString();
        }
    }
}