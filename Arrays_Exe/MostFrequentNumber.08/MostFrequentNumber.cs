using System;
using System.Collections.Generic;

namespace MostFrequentNumber
{
    internal class MostFrequentNumber
    {
        public static void Main(string[] args)
        {
            var numbers = ParseInput(Console.ReadLine());
            var order = new LinkedList<int>();
            var frequencyCount = new Dictionary<int, int>();
            foreach (var number in numbers)
            {
                if (!frequencyCount.ContainsKey(number))
                {
                    frequencyCount.Add(number, 1);
                    order.AddLast(number);
                }
                else
                {
                    var old = frequencyCount[number];
                    frequencyCount[number] = old + 1;
                }
            }

            var result = -1;
            var count = 0;
            foreach (var number in order)
            {
                if (frequencyCount[number] > count)
                {
                    result = number;
                    count = frequencyCount[number];
                }
            }
            Console.WriteLine(result);
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