using System;
using System.Collections.Generic;

namespace MaxSequenceOfIncreasingElements
{
    internal class MaxSequenceIncreasing
    {
        public static void Main(string[] args)
        {
            var array = ParseInput(Console.ReadLine());
            var maxSeq = FindSequence(array);
            Console.WriteLine(maxSeq);
        }

        private static string FindSequence(int[] arr)
        {
            var sequence = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (sequence.Count >= arr.Length - i)
                {
                    break;
                }
                var currSeq = new List<int> {arr[i]};
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] <= currSeq[currSeq.Count - 1])
                    {
                        break;
                    }
                    currSeq.Add(arr[j]);
                }
                if (currSeq.Count > sequence.Count)
                {
                    sequence = currSeq;
                }
            }
            return string.Join(" ", sequence);
        }

        private static int[] ParseInput(string input)
        {
            var numbers = input.Split(' ');
            var result = new int[input.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = int.Parse(numbers[i]);
            }
            return result;
        }
    }
}