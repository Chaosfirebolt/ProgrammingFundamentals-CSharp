using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AppendLists
{
    internal class AppendLists
    {
        public static void Main(string[] args)
        {
            var resultList = ProcessInput(Console.ReadLine());
            Console.WriteLine(string.Join(" ", resultList));
        }

        private static IList<string> ProcessInput(string input)
        {
            var result = new List<string>();
            var lists = input.Split('|');
            for (int i = lists.Length - 1; i >= 0; i--)
            {
                var numbers = Regex.Split(lists[i], "\\s+");
                foreach (var number in numbers)
                {
                    if (!number.Equals(""))
                    {
                        result.Add(number);
                    }
                }
            }
            return result;
        }
    }
}