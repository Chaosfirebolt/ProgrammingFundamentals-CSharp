using System;

namespace DayOfWeek
{
    internal class DayOfWeek
    {
        public static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day;
            var valid = int.TryParse(Console.ReadLine(), out day);
            const string errorMessage = "Invalid Day!";
            if (!valid)
            {
                Console.Write(errorMessage);
            }
            try
            {
                Console.Write(days[day - 1]);
            }
            catch (IndexOutOfRangeException exc)
            {
                Console.WriteLine(errorMessage);
            }
        }
    }
}