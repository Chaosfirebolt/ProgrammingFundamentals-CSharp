using System;

namespace ConvertSpeedUnits
{
    internal class ConvertSpeedUnits
    {
        public static void Main(string[] args)
        {
            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            Console.WriteLine("{0}", meters / (seconds + minutes * 60 + hours * 3600));
            Console.WriteLine("{0}", meters / 1000 / (hours + minutes / 60 + seconds / 3600));
            Console.WriteLine("{0}", meters / 1609 / (hours + minutes / 60 + seconds / 3600));
        }
    }
}