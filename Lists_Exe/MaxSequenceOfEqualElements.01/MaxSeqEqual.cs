using System;
using System.Text;

namespace MaxSequenceOfEqualElements
{
    internal class MaxSeqEqual
    {
        public static void Main(string[] args)
        {
            var numbers = ParseInput(Console.ReadLine());
            FindMaxSequence(numbers);
        }

        private static void FindMaxSequence(int[] numbers)
        {
            var maxNumber = 0;
            var maxCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                var currCount = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    currCount++;
                }
                if (currCount <= maxCount)
                {
                    continue;
                }
                maxCount = currCount;
                maxNumber = numbers[i];
            }
            Print(maxNumber, maxCount);
        }

        private static void Print(int maxNumber, int maxCount)
        {
            var output = new StringBuilder();
            for (int i = 0; i < maxCount; i++)
            {
                output.Append(maxNumber).Append(" ");
            }
            Console.Write(output);
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