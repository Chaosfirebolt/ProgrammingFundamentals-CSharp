using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace BePositive
{
    internal class BePositive
    {
        public static void Main(string[] args)
        {
            var countSequences = int.Parse(Console.ReadLine());
            var output = new StringBuilder();
            for (int i = 0; i < countSequences; i++)
            {
                var numbers = new List<int>();
                var input = Console.ReadLine().Split(' ');
                foreach (var str in input)
                {
                    if (!str.Equals(""))
                    {
                        numbers.Add(int.Parse(str));
                    }
                }
                var last = int.MinValue;
                var hasPositive = false;
                foreach (var number in numbers)
                {
                    if (last != int.MinValue)
                    {
                        var sum = last + number;
                        if (sum >= 0)
                        {
                            output.Append(sum).Append(" ");
                            hasPositive = true;
                        }
                        last = int.MinValue;
                    }
                    else
                    {
                        if (number < 0)
                        {
                            last = number;
                        }
                        else
                        {
                            output.Append(number).Append(" ");
                            hasPositive = true;
                        }
                    }
                }
                if (!hasPositive)
                {
                    output.Append("(empty)");
                }
                output.Append(Environment.NewLine);
            }
            Console.WriteLine(output);
        }
    }
}