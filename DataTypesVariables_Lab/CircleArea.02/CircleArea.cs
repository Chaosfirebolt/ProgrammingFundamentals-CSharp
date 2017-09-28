using System;

namespace CircleArea
{
    internal class CircleArea
    {
        public static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.PI * rad * rad:F12}");
        }
    }
}