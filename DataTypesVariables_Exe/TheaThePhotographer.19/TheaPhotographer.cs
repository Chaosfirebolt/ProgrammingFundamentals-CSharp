using System;

namespace TheaThePhotographer
{
    internal class TheaPhotographer
    {
        public static void Main(string[] args)
        {
            ulong picturesTaken = ulong.Parse(Console.ReadLine());
            ulong filterTime = ulong.Parse(Console.ReadLine());
            ulong filterFactor = ulong.Parse(Console.ReadLine());
            ulong uploadTimePic = ulong.Parse(Console.ReadLine());

            ulong seconds = picturesTaken * filterTime;
            ulong filteredPictures = (ulong) Math.Ceiling(picturesTaken * filterFactor / 100.0);
            seconds += filteredPictures * uploadTimePic;

            ulong days = seconds / 86400;
            seconds %= 86400;
            ulong hours = seconds / 3600;
            seconds %= 3600;
            ulong minutes = seconds / 60;
            seconds %= 60;
            Console.Write($"{days}:{hours.ToString().PadLeft(2, '0')}:{minutes.ToString().PadLeft(2, '0')}:{seconds.ToString().PadLeft(2, '0')}");
        }
    }
}