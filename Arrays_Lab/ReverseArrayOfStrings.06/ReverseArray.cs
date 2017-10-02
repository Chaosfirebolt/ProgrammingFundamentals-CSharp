using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseArrayOfStrings
{
    internal class ReverseArray
    {
        public static void Main(string[] args)
        {
            Console.Write(string.Join(" ", Reverse(Console.ReadLine())));
        }

        private static IEnumerable<string> Reverse(string input)
        {
            return input.Split(' ').Reverse().ToArray();
        }
    }
}