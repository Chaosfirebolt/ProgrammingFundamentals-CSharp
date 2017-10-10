using System;

namespace RectanglePosition
{
    internal class RectanglePosition
    {
        public static void Main(string[] args)
        {
            var rectData = ParseInput(Console.ReadLine());
            var first = new Rectangle(rectData[0], rectData[1], rectData[2], rectData[3]);
            rectData = ParseInput(Console.ReadLine());
            var second = new Rectangle(rectData[0], rectData[1], rectData[2], rectData[3]);
            Console.WriteLine(first.IsInside(second) ? "Inside" : "Not Inside");
        }

        private static int[] ParseInput(string input)
        {
            var numbers = input.Split(' ');
            var result = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = int.Parse(numbers[i]);
            }
            return result;
        }
    }

    internal class Rectangle
    {
        public int Left { get; }
        public int Top { get; }
        public int Right { get; }
        public int Bottom { get; }

        public Rectangle(int left, int top, int width, int height)
        {
            Left = left;
            Top = top;
            Right = CalcRight(width);
            Bottom = CalcBottom(height);
        }

        public bool IsInside(Rectangle other)
        {
            return Left >= other.Left && Right <= other.Right && Top <= other.Top && Bottom <= other.Bottom;
        }

        private int CalcRight(int width)
        {
            return Left + width;
        }

        private int CalcBottom(int height)
        {
            return Top + height;
        }
    }
}