using System;

namespace BeverageLabels
{
    internal class BeverageLabels
    {
        public static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = decimal.Parse(Console.ReadLine());
            var energy = decimal.Parse(Console.ReadLine());
            var sugar = decimal.Parse(Console.ReadLine());

            const byte rate = 100;
            Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars", volume, name, volume * energy / rate, volume * sugar / rate);
        }
    }
}