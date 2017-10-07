using System;
using System.Collections.Generic;

namespace BombNumbers
{
    internal class BombNumbers
    {
        public static void Main(string[] args)
        {
            var list = ParseInput(Console.ReadLine());
            var data = ParseInput(Console.ReadLine());
            var number = data[0];
            var power = data[1];
            Bomb(list, number, power);
            Console.WriteLine(Sum(list));
        }

        private static int Sum(IList<int> list)
        {
            var sum = 0;
            foreach (var num in list)
            {
                sum += num;
            }
            return sum;
        }

        private static void Bomb(IList<int> list, int number, int power)
        {
            var indexOf = list.IndexOf(number);
            while (indexOf != -1)
            {
                var index = Math.Max(0, indexOf - power);
                var count = Math.Min(list.Count - 1, indexOf + power) - index + 1;
                for (int i = 0; i < count; i++)
                {
                    list.RemoveAt(index);
                }
                indexOf = list.IndexOf(number);
            }
        }
        
        private static IList<int> ParseInput(string input)
        {
            var numbers = input.Split(' ');
            var result = new List<int>(input.Length);
            foreach (var number in numbers)
            {
                result.Add(int.Parse(number));
            }
            return result;
        }
    }
}