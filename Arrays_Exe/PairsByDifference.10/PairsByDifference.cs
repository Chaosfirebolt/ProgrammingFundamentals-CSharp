using System;

namespace PairsByDifference
{
    internal class PairsByDifference
    {
        public static void Main(string[] args)
        {
            var numbers = ParseInput(Console.ReadLine());
            var diff = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (Math.Abs(numbers[i] - numbers[j]) == diff)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
        
        private static int[] ParseInput(string input)
        {
            var numbers = input.Split(' ');
            var result = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = int.Parse(numbers[i]);
            }
            return result;
        }
    }
}