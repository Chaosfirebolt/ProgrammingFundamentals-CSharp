using System;
using System.Text;

namespace TriangleOfNumbers
{
    internal class NumbersTriangle
    {
        public static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var output = new StringBuilder();
            for (var i = 1; i <= count; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    output.Append(i).Append(" ");
                }
                output.Append("\n");
            }
            Console.Write(output);
        }
    }
}