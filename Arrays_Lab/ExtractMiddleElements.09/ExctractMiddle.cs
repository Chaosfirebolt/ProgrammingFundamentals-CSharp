using System;

namespace ExtractMiddleElements
{
    internal class ExctractMiddle
    {
        public static void Main(string[] args)
        {
            var array = ParseInput(Console.ReadLine());
            if (array.Length == 1)
            {
                Print(array);
                return;
            }
            var result = array.Length % 2 == 0 ? GetMiddle(array, 2) : GetMiddle(array, 3);
            Print(result);
        }

        private static string[] GetMiddle(string[] array, int count)
        {
            var result = new string [count];
            for (int i = -1; i < count - 1; i++)
            {
                result[i + 1] = array[array.Length / 2 + i];
            }
            return result;
        }

        private static void Print(string[] array)
        {
            Console.WriteLine("{ " + string.Join(", ", array) + " }");
        }

        private static string[] ParseInput(string input)
        {
            return input.Split(' ');
        }
    }
}