using System;

namespace Greeting
{
    internal class Greeting
    {
        public static void Main(string[] args)
         {
             var name = Console.ReadLine();
             Console.WriteLine($"Hello, {name}!");
         }
    }
}