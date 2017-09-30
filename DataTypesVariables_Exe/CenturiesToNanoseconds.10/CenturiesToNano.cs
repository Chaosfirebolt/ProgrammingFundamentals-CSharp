using System;
using System.Numerics;

namespace CenturiesToNanoseconds
{
    internal class CenturiesToNano
    {
        public static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int) (years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            long seconds = minutes * 60L;
            long milliseconds = seconds * 1000L;

            BigInteger thousand = 1000;
            BigInteger microseconds = milliseconds * thousand;
            BigInteger nanoseconds = microseconds * thousand;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds " +
                              $"= {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}