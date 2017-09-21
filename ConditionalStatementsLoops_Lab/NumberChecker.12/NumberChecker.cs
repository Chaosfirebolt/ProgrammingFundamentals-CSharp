using System;

namespace NumberChecker
{
    internal class NumberChecker
    {
        public static void Main(string[] args)
        {
            int num;
            var isNumber = int.TryParse(Console.ReadLine(), out num);
            var output = isNumber ? "It is a number." : "Invalid input!";
            Console.WriteLine(output);
        }
    }
}