using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoldAndSum
{
    internal class FoldSum
    {
        public static void Main(string[] args)
        {
            var numbers = ParseInput(Console.ReadLine());
            var lowBind = numbers.Length / 4;
            var highBind = numbers.Length - numbers.Length / 4;
            var firstList = GetUpperPart(numbers, lowBind, highBind);
            var secondList = GetDownPart(numbers, lowBind, highBind);
            PrintResult(firstList, secondList);
        }

        private static void PrintResult(List<int> firstList, List<int> secondList)
        {
            var output = new StringBuilder();
            for (int i = 0; i < firstList.Count; i++)
            {
                output.Append(firstList[i] + secondList[i]).Append(" ");
            }
            Console.WriteLine(output);
        }

        private static List<int> GetUpperPart(int[] numbers, int lowBind, int highBind)
        {
            var list = new List<int>();
            var size = numbers.Length / 4;

            var range = CopyArrayPortion(numbers, size, 0, lowBind).Reverse();
            list.AddRange(range);
            range = CopyArrayPortion(numbers, size, highBind, numbers.Length).Reverse();
            list.AddRange(range);
            return list;
        }

        private static List<int> GetDownPart(int[] numbers, int lowBind, int highBind)
        {
            var list = new List<int>();
            var range = CopyArrayPortion(numbers, numbers.Length / 2, lowBind, highBind);
            list.AddRange(range);
            return list;
        }

        private static int[] CopyArrayPortion(int[] numbers, int size, int lowBind, int highBind)
        {
            var result = new int[size];
            for (int i = lowBind; i < highBind; i++)
            {
                result[i - lowBind] = numbers[i];
            }
            return result;
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