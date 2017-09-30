using System;

namespace StringsObjects
{
    internal class StringsObjects
    {
        public static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object obj = hello + " " + world;
            Console.WriteLine((string)obj);
        }
    }
}