using System;

namespace LastKNumbersSumSeq
{
    internal class LastNumbersSeq
    {
        public static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var prevCount = int.Parse(Console.ReadLine());
            var array = new long[size];
            array[0] = 1;
            for (int i = 1; i < size; i++)
            {
                var startIndex = Math.Max(0, i - prevCount);
                array[i] = GetNext(array, startIndex, i);
            }
            Console.Write(string.Join(" ", array));
        }

        private static long GetNext(long[] array, int startIndex, int endIndex)
        {
            var sum = 0L;
            for (int i = startIndex; i < endIndex; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}