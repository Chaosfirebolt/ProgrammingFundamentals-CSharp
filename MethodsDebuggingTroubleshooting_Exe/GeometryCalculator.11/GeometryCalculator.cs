using System;

namespace GeometryCalculator
{
    internal class GeometryCalculator
    {
        public static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            switch (figure)
            {
                case "triangle":
                    var side = double.Parse(Console.ReadLine());
                    var height = double.Parse(Console.ReadLine());
                    Console.Write($"{TriangleArea(side, height):F2}");
                    break;
                case "square":
                    var sqSide = double.Parse(Console.ReadLine());
                    Console.Write($"{RectArea(sqSide, sqSide):F2}");
                    break;
                case "rectangle":
                    var rectWidth = double.Parse(Console.ReadLine());
                    var rectHeight = double.Parse(Console.ReadLine());
                    Console.Write($"{RectArea(rectWidth, rectHeight):F2}");
                    break;
                case "circle":
                    var radius = double.Parse(Console.ReadLine());
                    Console.Write($"{CircleArea(radius):F2}");
                    break;
            }
        }

        private static double CircleArea(double radius)
        {
            return Math.PI * RectArea(radius, radius);
        }

        private static double TriangleArea(double width, double height)
        {
            return RectArea(width, height) / 2;
        }

        private static double RectArea(double width, double height)
        {
            return width * height;
        }
    }
}