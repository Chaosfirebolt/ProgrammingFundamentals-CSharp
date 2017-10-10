using System;
using System.Globalization;

namespace DayOfWeek
{
    internal class DayOfWeek
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.Write(date.DayOfWeek);
        }
    }
}