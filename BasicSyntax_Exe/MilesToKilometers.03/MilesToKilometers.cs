using System;

namespace MilesToKilometers
{
    internal class MilesToKilometers
    {
        public static void Main(string[] args)
        {
            var miles = decimal.Parse(Console.ReadLine());
            const decimal convertionRate = 1.60934M;
            Console.WriteLine("{0:F2}", miles * convertionRate);
        }
    }
}