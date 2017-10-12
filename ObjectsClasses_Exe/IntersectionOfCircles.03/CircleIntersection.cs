using System;

namespace IntersectionOfCircles
{
    internal class CircleIntersection
    {
        public static void Main(string[] args)
        {
            var firstCircle = ParseInput(Console.ReadLine());
            var secondCircle = ParseInput(Console.ReadLine());
            Console.WriteLine(firstCircle.Intersects(secondCircle) ? "Yes" : "No");
        }

        private static Circle ParseInput(string input)
        {
            var data = input.Split(' ');
            return new Circle(new Point(int.Parse(data[0]), int.Parse(data[1])), int.Parse(data[2]));
        }
    }

    internal class Circle
    {
        public Point Center { get; }
        public int Radius { get; }

        public Circle(Point center, int radius)
        {
            Center = center;
            Radius = radius;
        }

        public bool Intersects(Circle other)
        {
            var distance = Center.Distance(other.Center);
            return distance <= Radius + other.Radius;
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

        public double Distance(Point other)
        {
            double a = Math.Abs(X - other.X);
            double b = Math.Abs(Y - other.Y);
            return Math.Sqrt(a * a + b * b);
        }
    }
}