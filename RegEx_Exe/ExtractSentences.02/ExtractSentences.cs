using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtractSentences
{
    internal class ExtractSentences
    {
        public static void Main(string[] args)
        {
            var keyWord = Console.ReadLine();
            var text = Console.ReadLine();
            var output = Extract(text, keyWord);
            Console.Write(output);
        }

        private static string Extract(string text, string key)
        {
            var result = new StringBuilder();
            var sentences = Regex.Split(text, @"[.!?]\s*");
            var extractionRegex = $@"\b{key}\b";
            foreach (var sentence in sentences)
            {
                if (Regex.Match(sentence, extractionRegex).Success)
                {
                    result.Append(sentence).Append(Environment.NewLine);
                }
            }
            return result.ToString();
        }
    }
}