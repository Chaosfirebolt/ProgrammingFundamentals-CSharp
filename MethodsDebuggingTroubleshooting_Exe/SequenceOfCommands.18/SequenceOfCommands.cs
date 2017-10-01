using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SequenceOfCommands
{
    internal class SequenceOfCommands
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();
            var numbers = new List<BigInteger>();
            var input = Console.ReadLine().Split(' ');
            var output = new StringBuilder();
            foreach (var str in input)
            {
                BigInteger number;
                var valid = BigInteger.TryParse(str, out number);
                if (valid)
                {
                    numbers.Add(number);
                }
            }
            var command = Console.ReadLine().ToLower();
            while (!command.Equals("stop"))
            {
                var data = command.Split(' ');
                int index;
                int value;
                BigInteger temp;
                switch (data[0])
                {
                    case "multiply":
                        index = int.Parse(data[1]) - 1;
                        value = int.Parse(data[2]);
                        numbers[index] *= value;
                        break;
                    case "add":
                        index = int.Parse(data[1]) - 1;
                        value = int.Parse(data[2]);
                        numbers[index] += value;
                        break;
                    case "subtract":
                        index = int.Parse(data[1]) - 1;
                        value = int.Parse(data[2]);
                        numbers[index] -= value;
                        break;
                    case "rshift":
                        index = numbers.Count - 1;
                        temp = numbers[index];
                        numbers.RemoveAt(index);
                        numbers.Insert(0, temp);
                        break;
                    case "lshift":
                        index = 0;
                        temp = numbers[index];
                        numbers.RemoveAt(index);
                        numbers.Add(temp);
                        break;
                }
                output.Append(string.Join(" ", numbers)).Append(Environment.NewLine);
                command = Console.ReadLine().ToLower();
            }
            Console.Write(output);
        }
    }
}