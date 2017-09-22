using System;

namespace CountTheIntegers
{
    internal class CountIntegers
    {
        public static void Main(string[] args)
        {
            var count = 0;
            while (true)
            {
                int num;
                var isNumber = int.TryParse(Console.ReadLine(), out num);
                if (isNumber)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}