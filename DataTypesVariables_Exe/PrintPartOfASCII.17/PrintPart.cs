using System;
using System.Text;

namespace PrintPartOfASCII
{
    internal class PrintPart
    {
        public static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            var output = new StringBuilder();
            output.Append((char) start);
            for (int i = start + 1; i <= end; i++)
            {
                output.Append(" ").Append((char) i);
            }
            Console.WriteLine(output);
        }
    }
}