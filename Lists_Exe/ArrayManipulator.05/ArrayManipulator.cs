using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayManipulator
{
    internal class ArrayManipulator
    {
        public static void Main(string[] args)
        {
            var output = new StringBuilder();
            var list = Parse(Console.ReadLine(), 0);
            var input = Console.ReadLine();
            while (input != "print")
            {
                if (input == null)
                {
                    continue;
                }
                var data = input.Split(' ');
                int index;
                int element;
                switch (data[0])
                {
                    case "add":
                        index = int.Parse(data[1]);
                        element = int.Parse(data[2]);
                        list.Insert(index, element);
                        break;
                    case "addMany":
                        index = int.Parse(data[1]);
                        var elements = Parse(input, 2);
                        list.InsertRange(index, elements);
                        break;
                    case "contains":
                        element = int.Parse(data[1]);
                        var elemIndex = list.IndexOf(element);
                        output.Append(elemIndex).Append(Environment.NewLine);
                        break;
                    case "remove":
                        index = int.Parse(data[1]);
                        list.RemoveAt(index);
                        break;
                    case "shift":
                        list = ShiftLeft(list, int.Parse(data[1]));
                        break;
                    case "sumPairs":
                        list = SumPairs(list);
                        break;
                }
                
                input = Console.ReadLine();
            }
            output.Append($"[{string.Join(", ", list)}]");
            Console.Write(output);
        }

        private static List<int> SumPairs(List<int> list)
        {
            var newList = new List<int>();
            for (int i = 0; i < list.Count; i += 2)
            {
                var first = list[i];
                var second = i + 1 < list.Count ? list[i + 1] : 0;
                newList.Add(first + second);
            }
            return newList;
        }

        private static List<int> ShiftLeft(List<int> list, int offset)
        {
            var result = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(list[(i + offset) % list.Count]);
            }
            return result;
        }
        
        private static List<int> Parse(string input, int startIndex)
        {
            var numbers = input.Split(' ');
            var result = new List<int>(numbers.Length);
            for (int i = startIndex; i < numbers.Length; i++)
            {
                result.Add(int.Parse(numbers[i]));
            }
            return result;
        }
    }
}