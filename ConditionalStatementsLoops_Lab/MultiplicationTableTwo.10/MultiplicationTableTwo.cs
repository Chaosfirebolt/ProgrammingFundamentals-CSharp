using System;

namespace MultiplicationTableTwo
{
    internal class MultiplicationTableTwo
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());
            if (multiplier > 10)
            {
                PrintMultiplication(number, multiplier);
            }
            else
            {
                for (var i = multiplier; i <= 10; i++)
                {
                    PrintMultiplication(number, i);
                }
            }
        }

        private static void PrintMultiplication(int number, int multiplier)
        {
            Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
        }
    }
}