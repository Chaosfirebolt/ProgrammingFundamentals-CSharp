using System;

namespace FactorialTrailingZeroes
{
    internal class FactorialTrailingZeroes
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var zeroes = CalcTrailingZeroes(number);
            Console.WriteLine(zeroes);
        }

        private static int CalcTrailingZeroes(int number)
        {
            var count = 0;
            var power = 1;
            var powerOfFive = CalcPowerOfFive(power);
            while (powerOfFive <= number)
            {
                count += number / powerOfFive;
                powerOfFive = CalcPowerOfFive(++power);
            }
            return count;
        }

        private static int CalcPowerOfFive(int power)
        {
            return (int) Math.Pow(5, power);
        }
    }
}