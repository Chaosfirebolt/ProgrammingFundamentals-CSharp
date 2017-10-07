using System;
using System.Collections.Generic;

namespace ChangeList
{
    internal class ChangeList
    {
        public static void Main(string[] args)
        {
            var numbers = ParseInput(Console.ReadLine());
            var result = ExecuteCommands(numbers);
            Console.WriteLine(string.Join(" ", result));
        }

        private static IList<int> ExecuteCommands(IList<int> numbers)
        {
            var command = Console.ReadLine().ToLower();
            while (!command.Equals("even") && !command.Equals("odd"))
            {
                var data = command.Split(' ');
                var element = int.Parse(data[1]);
                switch (data[0])
                {
                    case "delete":
                        for (int i = numbers.Count - 1; i >= 0; i--)
                        {
                            if (numbers[i] == element)
                            {
                                numbers.RemoveAt(i);
                            }
                        }
                        break;
                    case "insert":
                        var position = int.Parse(data[2]);
                        numbers.Insert(position, element);
                        break;
                }
                command = Console.ReadLine().ToLower();
            }
            IList<int> result;
            switch (command)
            {
                case "even":
                    result = GetElements(numbers, 0);
                    break;
                case "odd":
                    result = GetElements(numbers, 1);
                    break;
                default:
                    result = new List<int>();
                    break;
            }
            return result;
        }

        private static IList<int> GetElements(IList<int> numbers, int remainder)
        {
            var elements = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 == remainder)
                {
                    elements.Add(number);
                }
            }
            return elements;
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