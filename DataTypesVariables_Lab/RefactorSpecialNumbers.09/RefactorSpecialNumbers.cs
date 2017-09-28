using System;

namespace RefactorSpecialNumbers
{
    internal class RefactorSpecialNumbers
    {
        public static void Main(string[] args)
        {
            int lastNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= lastNum; i++)
            {
                int current = i;
                int sum = 0;
                while (current > 0)
                {
                    sum += current % 10;
                    current /= 10;
                }
                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}