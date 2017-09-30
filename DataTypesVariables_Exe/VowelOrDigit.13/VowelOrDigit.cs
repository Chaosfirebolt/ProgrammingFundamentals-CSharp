using System;

namespace VowelOrDigit
{
    internal class VowelOrDigit
    {
        public static void Main(string[] args)
        {
            char character = char.Parse(Console.ReadLine());
            if (char.IsDigit(character))
            {
                Console.WriteLine("digit");
            }
            else if (character == 65 || character == 69 || character == 73 || character == 79 || character == 85 || character == 89 ||
                                     character == 97 || character == 101 || character == 105 || character == 111 || character == 117 || character == 121)
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}