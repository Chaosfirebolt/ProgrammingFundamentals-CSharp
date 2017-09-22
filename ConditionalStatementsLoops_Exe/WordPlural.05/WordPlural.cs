using System;

namespace WordPlural
{
    internal class WordPlural
    {
        public static void Main(string[] args)
        {
            var word = Console.ReadLine();
            Console.WriteLine(Pluralize(word));
        }

        private static string Pluralize(string word)
        {
            if (word.EndsWith("y"))
            {
                return word.Substring(0, word.Length - 1) + "ies";
            }
            if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") 
                     || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
            {
                return word + "es";
            }
            return word + "s";
        }
    }
}