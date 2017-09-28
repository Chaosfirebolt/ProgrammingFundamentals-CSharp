using System;

namespace Elevator
{
    internal class Elevator
    {
        public static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int result = people / capacity + (people % capacity == 0 ? 0 : 1);
            Console.WriteLine(result);
        }
    }
}