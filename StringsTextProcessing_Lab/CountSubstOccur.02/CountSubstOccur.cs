using System;

namespace CountSubstOccur
{
    internal class CountSubstOccur
    {
        public static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var str = Console.ReadLine();
            Console.WriteLine(CountOccurences(text, str));
        }

        private static int CountOccurences(string text, string str)
        {
            text = text.ToLower();
            str = str.ToLower();
            var count = 0;
            for (int i = 0; i <= text.Length - str.Length; i++)
            {
                if (text.Substring(i, str.Length) == str)
                {
                    count++;
                }
            }
            return count;
        }
    }
}