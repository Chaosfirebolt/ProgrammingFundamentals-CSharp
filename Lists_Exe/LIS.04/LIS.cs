using System;
using System.Collections.Generic;

namespace LIS
{
    internal class LIS
    {
        public static void Main(string[] args)
        {
            var numbers = ParseInput(Console.ReadLine());
            var lis = CalcLIS(numbers);
            Console.WriteLine(string.Join(" ", lis));
        }

        private static IList<int> CalcLIS(int[] sequence)
        {
            var length = new int[sequence.Length];
            var previous = new int[sequence.Length];
            var maxLength = 0;
            var lastIndex = -1;
            for (int x = 0; x < sequence.Length; x++)
            {
                length[x] = 1;
                previous[x] = -1;
                for (int i = 0; i <= x - 1; i++)
                {
                    if (sequence[i] < sequence[x] && length[i] + 1 > length[x])
                    {
                        length[x] = length[i] + 1;
                        previous[x] = i;
                    }
                }
                if (length[x] > maxLength)
                {
                    maxLength = length[x];
                    lastIndex = x;
                }
            }
            return RestoreLIS(sequence, previous, lastIndex);
        }

        private static IList<int> RestoreLIS(int[] sequence, int[] previous, int lastIndex)
        {
            var longestSeq = new List<int>();
            while (lastIndex != -1)
            {
                longestSeq.Add(sequence[lastIndex]);
                lastIndex = previous[lastIndex];
            }
            longestSeq.Reverse();
            return longestSeq;
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