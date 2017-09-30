using System;

namespace ComparingFloats
{
    internal class ComparingFloats
    {
        public static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            
            const double eps = 0.000001;
            double diff = Math.Abs(first - second);
            bool areEqual = diff < eps;
            Console.WriteLine(areEqual);
        }
    }
}