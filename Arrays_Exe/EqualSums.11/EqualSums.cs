using System;

namespace EqualSums
{
    internal class EqualSums
    {
        public static void Main(string[] args)
        {
            var numbers = ParseInput(Console.ReadLine());
            var leftSums = new int[numbers.Length];
            var rightSums = new int[numbers.Length];
            CalcSums(numbers, leftSums, rightSums);
            var index = FindIndex(leftSums, rightSums);
            Console.WriteLine(index == -1 ? "no" : index.ToString());
        }

        private static int FindIndex(int[] leftSums, int[] rightSums)
        {
            for (int i = 0; i < leftSums.Length; i++)
            {
                if (leftSums[i] != rightSums[i])
                {
                    continue;
                }
                return i;
            }
            return -1;
        }

        private static void CalcSums(int[] numbers, int[] leftSums, int[] rightSums)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                leftSums[i] = leftSums[i - 1] + numbers[i - 1];
                var rightSumsIndex = numbers.Length - i;
                rightSums[numbers.Length - 1 - i] = rightSums[rightSumsIndex] + numbers[rightSumsIndex];
            }
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