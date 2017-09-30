using System;
using System.Text;

namespace PrintTriangle
{
    internal class PrintTriangle
    {
        public static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            Print(num);
        }

        private static void Print(int num)
        {
            var output = new StringBuilder();
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    output.Append(j).Append(" ");
                }
                output.Append(Environment.NewLine);
            }
            for (int i = num - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    output.Append(j).Append(" ");
                }
                output.Append(Environment.NewLine);
            }
            Console.Write(output);
        }
    }
}