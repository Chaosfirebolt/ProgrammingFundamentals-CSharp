using System;

namespace CubeProperties
{
    internal class CubeProperty
    {
        public static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var prop = Console.ReadLine();
            switch (prop)
            {
                case "face":
                    Console.Write($"{Face(side):F2}");
                    return;
                case "volume":
                    Console.Write($"{Volume(side):F2}");
                    return;
                case "space":
                    Console.Write($"{Space(side):F2}");
                    return;
                case "area":
                    Console.Write($"{Area(side):F2}");
                    return;
            }
        }

        private static double Face(double side)
        {
            return Math.Sqrt(2 * side * side);
        }

        private static double Volume(double side)
        {
            return Math.Pow(side, 3);
        }
        
        private static double Space(double side)
        {
            return Math.Sqrt(3 * side * side);
        }

        private static double Area(double side)
        {
            return 6 * side * side;
        }
    }
}