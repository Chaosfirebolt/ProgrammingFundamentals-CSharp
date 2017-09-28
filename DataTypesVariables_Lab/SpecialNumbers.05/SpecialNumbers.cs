using System;

namespace SpecialNumbers
{
    internal class SpecialNumbers
    {
        public static void Main(string[] args)
        {
            int lastNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= lastNum; i++)
            {
                int num = i;
                int sum = 0;
                while (num > 0) {
                    sum += num % 10;
                    num /= 10;
                }
                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}