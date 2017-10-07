using System;
using System.Linq;

namespace ShortWordsSorted
{
    internal class ShortWordsSorted
    {
        public static void Main(string[] args)
        {
            ProcessInput(Console.ReadLine());
        }

        private static void ProcessInput(string input)
        {
            var sorted = input.ToLower().Split(new [] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, 
                    StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Distinct();
            Console.WriteLine(string.Join(", ", sorted));
        }
    }
}