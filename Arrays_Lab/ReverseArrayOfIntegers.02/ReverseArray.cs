using System;

namespace ReverseArrayOfIntegers
{
    internal class ReverseArray
    {
        public static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var array = new string[size];
            for (int i = size - 1; i >= 0; i--)
            {
                array[i] = Console.ReadLine();
            }
            Console.Write(string.Join(" ", array));
        }
    }
}