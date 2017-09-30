using System;

namespace SignOfIntegerNumber
{
    internal class IntegerSign
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }

        private static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.Write($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.Write($"The number {number} is negative.");
            }
            else
            {
                Console.Write($"The number {number} is zero.");
            }
        }
    }
}