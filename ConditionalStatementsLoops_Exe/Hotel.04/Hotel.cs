using System;

namespace Hotel
{
    internal class Hotel
    {
        public static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var stay = int.Parse(Console.ReadLine());
            
            double studioPrice;
            double doublePrice;
            double suitePrice;

            switch (month) {
                case "May":
                case "October":
                    studioPrice = 50 * stay;
                    doublePrice = 65 * stay;
                    suitePrice = 75 * stay;
                    if (stay > 7) {
                        studioPrice *= 0.95;
                        if (month == "October") {
                            studioPrice -= (0.95 * 50);
                        }
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 60 * stay;
                    doublePrice = 72 * stay;
                    suitePrice = 82 * stay;
                    if (stay > 7 && month == "September") {
                        studioPrice -= 60;
                    }
                    if (stay > 14) {
                        doublePrice *= 0.9;
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    studioPrice = 68 * stay;
                    doublePrice = 77 * stay;
                    suitePrice = 89 * stay;
                    if (stay > 14) {
                        suitePrice *= 0.85;
                    }
                    break;
                default:
                    return;
            }
            Console.WriteLine("Studio: {0:F2} lv.\nDouble: {1:F2} lv.\nSuite: {2:F2} lv.", studioPrice, doublePrice, suitePrice);
        }
    }
}