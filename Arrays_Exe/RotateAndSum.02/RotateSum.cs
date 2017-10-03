using System;

namespace RotateAndSum
{
    internal class RotateSum
    {
        public static void Main(string[] args)
        {
            var numbers = ParseInput(Console.ReadLine());
            int rotations;
            int.TryParse(Console.ReadLine(), out rotations);
            var sums = new int [numbers.Length];
            for (int i = 0; i < rotations; i++)
            {
                RotateArray(numbers);
                SumArrays(sums, numbers);
            }
            Console.WriteLine(string.Join(" ", sums));
        }

        private static void SumArrays(int[] sums, int[] numbers)
        {
            for (int i = 0; i < sums.Length; i++)
            {
                sums[i] += numbers[i];
            }
        }

        private static void RotateArray(int[] numbers)
        {
            var temp = numbers[numbers.Length - 1];
            for (int i = numbers.Length - 2; i >= 0; i--)
            {
                numbers[i + 1] = numbers[i];
            }
            numbers[0] = temp;
        }

        private static int[] ParseInput(string input)
        {
            var numbers = input.Split(' ');
            var result = new int [numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = int.Parse(numbers[i]);
            }
            return result;
        }
    }
}