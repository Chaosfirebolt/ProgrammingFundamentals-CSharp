using System;
using System.Text;

namespace DrawFilledSquare
{
    internal class DrawFilledSquare
    {
        public static void Main(string[] args)
        {
            int num;
            var valid = int.TryParse(Console.ReadLine(), out num);
            if (!valid)
            {
                return;
            }
            PrintSquare(num);
        }

        private static void PrintSquare(int num)
        {
            var length = num * 2;
            PrintEndLine(length);
            for (int i = 0; i < num - 2; i++)
            {
                PrintBody(length);
            }
            PrintEndLine(length);
        }

        private static void PrintBody(int length)
        {
            var line = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                if (i == 0 || i == length - 1)
                {
                    line.Append('-');
                }
                else
                {
                    line.Append(i % 2 == 0 ? '/' : '\\');
                }
            }
            Console.WriteLine(line);
        }

        private static void PrintEndLine(int length)
        {
            var line = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                line.Append('-');
            }
            Console.WriteLine(line);
        }
    }
}