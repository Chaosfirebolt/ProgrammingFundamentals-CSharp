using System;
using System.Text;

namespace CompareCharArrays
{
    internal class CompareCharArrays
    {
        public static void Main(string[] args)
        {
            var first = Console.ReadLine().Split(' ');
            var second = Console.ReadLine().Split(' ');
            var result = Compare(first, second);
            if (result <= 0)
            {
                PrintResult(first, second);
            }
            else
            {
                PrintResult(second, first);
            }
        }

        private static void PrintResult(string[] arr1, string[] arr2)
        {
            PrintArray(arr1);
            PrintArray(arr2);
        }

        private static void PrintArray(string[] arr)
        {
            var output = new StringBuilder();
            foreach (var str in arr)
            {
                output.Append(str);
            }
            Console.WriteLine(output);
        }

        private static int Compare(string[] arr1, string[] arr2)
        {
            var boundary = Math.Min(arr1.Length, arr2.Length);
            for (int i = 0; i < boundary; i++)
            {
                var cmp = arr1[i].CompareTo(arr2[i]);
                if (cmp < 0)
                {
                    return -1;
                }
                if (cmp > 0)
                {
                    return 1;
                }
            }
            int lengthDiff = arr1.Length - arr2.Length;
            if (lengthDiff < 0)
            {
                return -1;
            }
            return lengthDiff > 0 ? 1 : 0;
        }
    }
}