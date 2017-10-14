using System;

namespace CharacterMultiplier
{
    internal class CharacterMultiplier
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var sum = Sum(input[0], input[1]);
            Console.WriteLine(sum);
        }

        private static int Sum(string word1, string word2)
        {
            var sum = 0;
            var lowBind = Math.Min(word1.Length, word2.Length);
            var highBind = Math.Max(word1.Length, word2.Length);
            for (int i = 0; i < lowBind; i++)
            {
                sum += word1[i] * word2[i];
            }
            var longer = GetLonger(word1, word2);
            for (int i = lowBind; i < highBind; i++)
            {
                sum += longer[i];
            }
            return sum;
        }

        private static string GetLonger(string word1, string word2)
        {
            return word1.Length >= word2.Length ? word1 : word2;
        }
    }
}