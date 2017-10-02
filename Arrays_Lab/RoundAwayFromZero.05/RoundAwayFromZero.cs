using System;
using System.Collections.Generic;

namespace RoundAwayFromZero
{
    internal class RoundAwayFromZero
    {
        public static void Main(string[] args)
        {
            var numbers = ParseInput(Console.ReadLine());
            foreach (var number in numbers)
            {
                if (number > 0)
                {
                    Console.WriteLine($"{number} => {Math.Round(number, MidpointRounding.AwayFromZero)}");
                }
                else
                {
                    Console.WriteLine($"{number} => {Math.Round(number, MidpointRounding.AwayFromZero)}");
                }
            }
        }

        private static IEnumerable<double> ParseInput(string input)
        {
            var values = input.Split(' ');
            var result = new double [values.Length];
            for (var i = 0; i < values.Length; i++)
            {
                result[i] = double.Parse(values[i]);
            }
            return result;
        }
    }
}