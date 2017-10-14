using System;
using System.Collections.Generic;

namespace MagicExchangeable
{
    internal class MagicExchangeableWords
    {
        public static void Main(string[] args)
        {
            var input = ParseInput(Console.ReadLine());
            var areExchangeable = AreExchangeable(input[0], input[1]);
            Console.WriteLine(areExchangeable.ToString().ToLower());
        }

        private static bool AreExchangeable(string first, string second)
        {
            var mapping = new Dictionary<char, char>();
            for (int i = 0; i < first.Length; i++)
            {
                var keyChar = first[i];
                char valueChar;
                try
                {
                    valueChar = second[i];
                }
                catch (IndexOutOfRangeException exc)
                {
                    if (!mapping.ContainsKey(keyChar))
                    {
                        return false;
                    }
                    continue;
                }

                if (!mapping.ContainsKey(keyChar))
                {
                    mapping.Add(keyChar, valueChar);
                    continue;
                }
                if (valueChar != mapping[keyChar])
                {
                    return false;
                }
            }
            return true;
        }

        private static string[] ParseInput(string input)
        {
            var words = input.Split(' ');
            if (words[0].Length < words[1].Length)
            {
                var temp = words[0];
                words[0] = words[1];
                words[1] = temp;
            }
            return words;
        }
    }
}