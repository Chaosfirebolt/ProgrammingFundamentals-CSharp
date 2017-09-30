using System;

namespace ReverseCharacters
{
    internal class ReverseChars
    {
        public static void Main(string[] args)
        {
            const int count = 3;
            char[] chars = new char[count];
            for (int i = 0; i < count; i++)
            {
                chars[i] = Console.ReadLine()[0];
            }
            for (int i = count - 1; i >= 0; i--)
            {
                Console.Write(chars[i]);
            }
        }
    }
}