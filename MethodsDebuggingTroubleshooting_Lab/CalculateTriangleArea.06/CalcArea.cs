using System;

namespace CalculateTriangleArea
{
    internal class CalcArea
    {
        public static void Main(string[] args)
        {
            double width;
            double height;
            var validWidth = double.TryParse(Console.ReadLine(), out width);
            var validHeight = double.TryParse(Console.ReadLine(), out height);
            if (!validWidth || !validHeight)
            {
                return;
            }
            Console.WriteLine($"{Area(width, height)}");
        }

        private static double Area(double width, double height)
        {
            return width * height / 2;
        }
    }
}