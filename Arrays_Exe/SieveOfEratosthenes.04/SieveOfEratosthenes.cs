using System;
using System.Text;

namespace SieveOfEratosthenes
{
    internal class SieveOfEratosthenes
    {
        public static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var array = Initialize(num);
            FindPrimes(array, num);
            Print(array);
        }

        private static void Print(bool[] array)
        {
            var output = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i])
                {
                    output.Append(i).Append(" ");
                }
            }
            Console.WriteLine(output);
        }

        private static void FindPrimes(bool[] array, int num)
        {
            var boundary = (int) Math.Ceiling(Math.Sqrt(num));
            for (int i = 2; i <= boundary; i++)
            {
                if (array[i])
                {
                    for (int j = i * i; j <= num; j += i)
                    {
                        array[j] = false;
                    }
                }
            }
        }

        private static bool[] Initialize(int lastNum)
        {
            var arr = new bool[lastNum + 1];
            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = true;
            }
            return arr;
        }
    }
}