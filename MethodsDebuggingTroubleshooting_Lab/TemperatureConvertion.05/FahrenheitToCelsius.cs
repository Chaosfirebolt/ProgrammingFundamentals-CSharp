using System;

namespace TemperatureConvertion
{
    internal class FahrenheitToCelsius
    {
        public static void Main(string[] args)
        {
            double fahrenheit;
            var valid = double.TryParse(Console.ReadLine(), out fahrenheit);
            if (!valid)
            {
                return;
            }
            var celsius = ToCelsius(fahrenheit);
            Console.Write($"{celsius:F2}");
        }

        private static double ToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}