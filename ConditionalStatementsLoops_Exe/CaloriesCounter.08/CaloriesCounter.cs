using System;

namespace CaloriesCounter
{
    internal class CaloriesCounter
    {
        public static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var total = 0;
            for (var i = 0; i < count; i++)
            {
                var ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                        case "cheese":
                            total += 500;
                            break;
                        case "tomato sauce":
                            total += 150;
                            break;
                        case "salami":
                            total += 600;
                            break;
                        case "pepper":
                            total += 50;
                            break;
                }
            }
            Console.WriteLine($"Total calories: {total}");
        }
    }
}