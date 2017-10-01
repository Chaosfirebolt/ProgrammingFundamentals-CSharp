using System;

namespace LongerLine
{
    internal class LongerLine
    {
        public static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            var firstLength = CalcDistance(x1, y1, x2, y2);
            var secondLength = CalcDistance(x3, y3, x4, y4);
            Console.Write(firstLength >= secondLength ? Line(x1, y1, x2, y2) : Line(x3, y3, x4, y4));
        }

        private static string Line(double x1, double y1, double x2, double y2)
        {
            var firstDistance = CalcDistance(x1, y1, 0, 0);
            var secondDistance = CalcDistance(x2, y2, 0, 0);
            return firstDistance <= secondDistance ? $"({x1}, {y1})({x2}, {y2})" : $"({x2}, {y2})({x1}, {y1})";
        }
        
        private static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            var a = Math.Abs(x1 - x2);
            var b = Math.Abs(y1 - y2);
            return Math.Sqrt(a * a + b * b);
        }
    }
}