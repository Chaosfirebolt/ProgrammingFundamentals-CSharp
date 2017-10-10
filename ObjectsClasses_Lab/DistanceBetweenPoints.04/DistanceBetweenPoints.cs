using System;

namespace DistanceBetweenPoints
{
    internal class DistanceBetweenPoints
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var point1 = new Point(int.Parse(input[0]), int.Parse(input[1]));
            input = Console.ReadLine().Split(' ');
            var point2 = new Point(int.Parse(input[0]), int.Parse(input[1]));
            Console.WriteLine($"{point1.CalcDistance(point2):F3}");
        }
    }

    internal class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double CalcDistance(Point other)
        {
            var a = Math.Pow(Math.Abs(X - other.X), 2);
            var b = Math.Pow(Math.Abs(Y - other.Y), 2);
            return Math.Sqrt(a + b);
        }
    }
}