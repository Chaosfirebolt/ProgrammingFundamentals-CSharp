using System;

namespace RectangleArea
{
    internal class RectangleArea
    {
        public static void Main(string[] args)
        {
            var a = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", a * b);
        }
    }
}