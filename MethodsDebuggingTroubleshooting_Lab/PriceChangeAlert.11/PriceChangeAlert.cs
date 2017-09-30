using System;

namespace PriceChangeAlert
{
    internal class PriceChangeAlert
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var threshold = double. Parse(Console.ReadLine());
            var lastPrice = double.Parse(Console.ReadLine());
            for (var i = 0; i < count - 1; i++) {
                var currPrice = double.Parse(Console.ReadLine());
                var difference = CalcDifference(lastPrice, currPrice);
                var isChangeMajor = IsChangeMajor(threshold, difference);
                var message = GetMessage(currPrice, lastPrice, difference * 100, isChangeMajor);
                Console.WriteLine(message);
                lastPrice = currPrice;
            }             
        }

        private static string GetMessage(double currPrice, double lastPrice, double difference, bool isChangeMajor)
        {   
            var to = "";
            if (difference.Equals(0.00))
            {
                to = $"NO CHANGE: {currPrice}";
            }
            else if (!isChangeMajor)
            {
                to = $"MINOR CHANGE: {lastPrice} to {currPrice} ({difference:F2}%)";
            }
            else if (difference > 0)
            {
                to = $"PRICE UP: {lastPrice} to {currPrice} ({difference:F2}%)";
            }
            else if (difference < 0)
            {
                to = $"PRICE DOWN: {lastPrice} to {currPrice} ({difference:F2}%)";
            }
            return to;
        }
        
        private static bool IsChangeMajor(double threshold, double difference)
        {
            return Math.Abs(difference) >= threshold;
        }

        private static double CalcDifference(double lastPrice, double currPrice)
        {
            return (currPrice - lastPrice) / lastPrice;
        }
    }
}