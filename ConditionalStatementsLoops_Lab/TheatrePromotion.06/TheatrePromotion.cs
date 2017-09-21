using System;

namespace TheatrePromotion
{
    internal class TheatrePromotion
    {
        public static void Main(string[] args)
        {
            var day = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            var childTicket = 0;
            var adultTicket = 0;
            var seniorTicket = 0;

            switch (day) {
                case "Weekday":
                    childTicket = 12;
                    adultTicket = 18;
                    seniorTicket = 12;
                    break;
                case "Weekend":
                    childTicket = 15;
                    adultTicket = 20;
                    seniorTicket = 15;
                    break;
                case "Holiday":
                    childTicket = 5;
                    adultTicket = 12;
                    seniorTicket = 10;
                    break;
            }
            
            if (age >= 0 && age <= 18) {
                Console.WriteLine($"{childTicket}$");
            } else if (age > 18 && age <= 64) {
                Console.WriteLine($"{adultTicket}$");
            } else if (age > 64 && age <= 122) {
                Console.WriteLine($"{seniorTicket}$");
            } else {
                Console.WriteLine("Error!");
            }
        }
    }
}