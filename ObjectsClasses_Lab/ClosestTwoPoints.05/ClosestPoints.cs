using System;
using System.Collections.Generic;

namespace ClosestTwoPoints
{
    internal class ClosestPoints
    {
        public static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var points = new List<Point>();
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split(' ');
                points.Add(new Point(int.Parse(input[0]), int.Parse(input[1])));
            }

            var index1 = -1;
            var index2 = -1;
            var minDistance = double.MaxValue;
            for (int i = 0; i < points.Count; i++)
            {
                var point = points[i];
                for (int j = i + 1; j < points.Count; j++)
                {
                    var next = points[j];
                    var currDistance = point.CalcDistance(next);
                    if (currDistance < minDistance)
                    {
                        index1 = i;
                        index2 = j;
                        minDistance = currDistance;
                    }
                }
            }
            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine(points[index1]);
            Console.WriteLine(points[index2]);
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

            public override string ToString()
            {
                return $"({X}, {Y})";
            }

            public double CalcDistance(Point other)
            {
                var a = Math.Pow(Math.Abs(X - other.X), 2);
                var b = Math.Pow(Math.Abs(Y - other.Y), 2);
                return Math.Sqrt(a + b);
            }
        }
    }
}