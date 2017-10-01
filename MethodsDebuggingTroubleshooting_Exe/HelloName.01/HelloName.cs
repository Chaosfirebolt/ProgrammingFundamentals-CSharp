using System;

namespace HelloName
{
    internal class HelloName
    {
        public static void Main(string[] args)
        {
            var name = Console.ReadLine();
            Greet(name);
        }

        private static void Greet(string name)
        {
            Console.Write($"Hello, {name}!");
        }
    }
}