using System;
using System.Collections.Generic;

namespace MaxSequenceOfEqualElements
{
    internal class MaxSequenceEqual
    {
        public static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ');
            var maxSeq = FindSequence(array);
            Console.WriteLine(maxSeq);
        }

        private static string FindSequence(string[] arr)
        {
            var sequence = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (sequence.Count >= arr.Length - i)
                {
                    break;
                }
                var curr = arr[i];
                var currSeq = new List<string> {curr};
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (!curr.Equals(arr[j]))
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
    }
}