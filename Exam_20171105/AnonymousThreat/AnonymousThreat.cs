using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace AnonymousThreat
{
    internal class AnonymousThreat
    {
        public static void Main(string[] args)
        {
            var list = Regex.Split(Console.ReadLine(), @"\s+").ToList();
            var input = Console.ReadLine();
            while (input != null && input != "3:1")
            {
                var data = Regex.Split(input, @"\s+");
                switch (data[0])
                {
                    case "merge":
                        var startIndex = Math.Max(int.Parse(data[1]), 0);
                        var endIndex = Math.Min(list.Count - 1, int.Parse(data[2]));
                        if (endIndex < startIndex)
                        {
                            break;
                        }
                        var length = endIndex - startIndex + 1;
                        var joined = string.Join("", list.GetRange(startIndex, length));
                        list.RemoveRange(startIndex, length);
                        list.Insert(startIndex, joined);
                        break;
                    case "divide":
                        var index = int.Parse(data[1]);
                        var partitions = int.Parse(data[2]);
                        var elem = list[index];
                        list.RemoveAt(index);
                        var len = elem.Length / partitions;
                        var elemIndex = 0;
                        var count = 1;
                        while (count < partitions)
                        {
                            list.Insert(index, elem.Substring(elemIndex, len));
                            elemIndex += len;
                            count++;
                            index++;
                        }
                        list.Insert(index, elem.Substring(elemIndex));
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}