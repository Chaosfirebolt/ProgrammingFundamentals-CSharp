using System;
using System.Collections.Generic;
using System.Globalization;

namespace CountWorkingDays
{
    internal class CountWorkingDays
    {
        public static void Main(string[] args)
        {
            const string format = "dd-MM-yyyy";
            var startDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
            var holidays = Holidays();
            var count = 0;
            for (var curr = startDate; curr <= endDate; curr = curr.AddDays(1))
            {
                var day = curr.DayOfWeek;
                if (day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
                {
                    continue;
                }
                var date = new Date(curr.Day, curr.Month);
                if (holidays.Contains(date))
                {
                    continue;
                }
                count++;
            }
            Console.WriteLine(count);

        }

        private static HashSet<Date> Holidays()
        {
            return new HashSet<Date>
            {
                new Date(1, 1), new Date(3, 3), new Date(1, 5), new Date(6, 5), new Date(24, 5), new Date(6, 9), new Date(22, 9),
                new Date(1, 11), new Date(24, 12), new Date(25, 12), new Date(26, 12)
            };
        }
    }

    internal class Date
    {

        public int Day { get; }
        public int Month { get; }

        public Date(int day, int month)
        {
            Day = day;
            Month = month;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Date))
            {
                return false;
            }
            var other = (Date) obj;
            return Day == other.Day && Month == other.Month;
        }

        public override int GetHashCode()
        {
            return Day.GetHashCode() * 17 + Month.GetHashCode() * 31;
        }
    }
}