using System;

namespace ChooseDrinkTwo
{
    internal class ChooseDrinkTwo
    {
        public static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine("The {0} has to pay {1:F2}.", profession, quantity * 0.7);
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine("The {0} has to pay {1:F2}.", profession, quantity);
                    break;
                case "SoftUni Student":
                    Console.WriteLine("The {0} has to pay {1:F2}.", profession, quantity * 1.7);
                    break;
                default:
                    Console.WriteLine("The {0} has to pay {1:F2}.", profession, quantity * 1.2);
                    break;
            }
        }
    }
}