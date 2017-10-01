using System;

namespace CenterPoint
{
    internal class CenterPoint
    {
        public static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var firstDistance = CalcDistance(x1, y1);
            var secondDistance = CalcDistance(x2, y2);
            Console.Write(firstDistance <= secondDistance ? $"({x1}, {y1})" : $"({x2}, {y2})");
        }

        private static double CalcDistance(double x, double y)
        {
            var a = Math.Abs(x);
            var b = Math.Abs(y);
            return Math.Sqrt(a * a + b * b);
        }
    }
}