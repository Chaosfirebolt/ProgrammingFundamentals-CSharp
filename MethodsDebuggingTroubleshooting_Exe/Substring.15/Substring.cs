using System;

namespace Substring
{
    internal class Substring
    {
        public static void Main(string[] args)
        {
            var text = Console.ReadLine();
            int jump;
            var valid = int.TryParse(Console.ReadLine(), out jump);
            if (text == null || !valid)
            {
                return;
            }

            const char search = 'p';
            var hasMatch = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == search)
                {
                    hasMatch = true;
                    var length = Math.Min(jump + 1, text.Length - i);
                    var matchedString = text.Substring(i, length);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }
            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}