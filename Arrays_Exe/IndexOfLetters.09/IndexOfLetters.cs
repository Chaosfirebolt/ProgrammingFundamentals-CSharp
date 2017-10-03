using System;

namespace IndexOfLetters
{
    internal class IndexOfLetters
    {
        public static void Main(string[] args)
        {
            const int asciiOffset = 97;
            var word = Console.ReadLine();
            foreach (var character in word)
            {
                Console.WriteLine($"{character} -> {character - asciiOffset}");
            }
        }
    }
}