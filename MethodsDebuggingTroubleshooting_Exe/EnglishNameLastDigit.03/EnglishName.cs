using System;

namespace EnglishNameLastDigit
{
    internal class EnglishName
    {
        private static readonly string[] Names = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        
        public static void Main(string[] args)
        {
            var num = Console.ReadLine();
            Console.Write(GetName(num));
        }

        private static string GetName(string num)
        {
            var lastDigit = int.Parse(num.Substring(num.Length - 1));
            return Names[lastDigit];
        }
    }
}