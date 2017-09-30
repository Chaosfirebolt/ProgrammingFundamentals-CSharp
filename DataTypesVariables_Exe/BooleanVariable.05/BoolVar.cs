using System;

namespace BooleanVariable
{
    internal class BoolVar
    {
        public static void Main(string[] args)
        {
            bool boolean = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(boolean ? "Yes" : "No");
        }
    }
}