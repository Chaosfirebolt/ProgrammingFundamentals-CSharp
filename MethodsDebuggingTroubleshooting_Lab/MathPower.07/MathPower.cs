using System;

namespace MathPower
{
    internal class MathPower
    {
        public static void Main(string[] args)
        {
            double num;
            int power;
            var validNumber = double.TryParse(Console.ReadLine(), out num);
            var validPower = int.TryParse(Console.ReadLine(), out power);
            if (!validNumber || !validPower)
            {
                return;
            }
            Console.Write(Power(num, power));
        }

        private static double Power(double num, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}