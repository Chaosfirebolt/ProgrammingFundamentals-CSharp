using System;

namespace BackInThirtyMin
{
    internal class BackInThirty
    {
        public static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine()) + 30;
            if (minutes >= 60)
            {
                hours++;
                minutes -= 60;
                if (hours == 24)
                {
                    hours = 0;
                }
            }
            Console.WriteLine($"{hours}:{minutes.ToString().PadLeft(2, '0')}");
        }
    }
}