using System;

namespace MonthPrinter
{
    internal class MonthPrinter
    {
        public static void Main(string[] args)
        {
            string[] months = {"January", "February", "March", "April", "May", "June", 
                "July", "August", "September", "October", "November", "December"};
            var month = int.Parse(Console.ReadLine());
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(months[month - 1]);
            }
        }
    }
}