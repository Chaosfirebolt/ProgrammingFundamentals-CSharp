using System;
using System.Collections.Generic;

namespace CondenseArrayToNumber
{
    internal class CondenseArray
    {
        public static void Main(string[] args)
        {
            var numbers = ParseInput(Console.ReadLine());
            var result = Condense(numbers);
            Console.WriteLine(result);
        }

        private static int Condense(IList<int> numbers)
        {
            if (numbers.Count == 1)
            {
                return numbers[0];
            }
            
            var nextList = new List<int>();
            for (int i = 1; i < numbers.Count; i++)
            {
                nextList.Add(numbers[i - 1] + numbers[i]);
            }
            return Condense(nextList);
        }

        private static IList<int> ParseInput(string input)
        {
            var numbers = input.Split(' ');
            var list = new List<int>(numbers.Length);
            foreach (var number in numbers)
            {
                list.Add(int.Parse(number));
            }
            return list;
        }
    }
}