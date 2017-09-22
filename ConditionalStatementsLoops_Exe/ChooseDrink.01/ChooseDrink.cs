using System;

namespace ChooseDrink
{
    internal class ChooseDrink
    {
        public static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            switch (profession)
            {
                    case "Athlete":
                        Console.WriteLine("Water");
                        break;
                    case "Businessman":
                    case "Businesswoman":
                        Console.WriteLine("Coffee");
                        break;
                    case "SoftUni Student":
                        Console.WriteLine("Beer");
                        break;
                    default:
                        Console.WriteLine("Tea");
                        break;
            }
        }
    }
}