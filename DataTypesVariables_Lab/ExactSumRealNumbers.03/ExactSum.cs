using System;

namespace ExactSumRealNumbers
{
    internal class ExactSum
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.Write(sum);
        }
    }
}