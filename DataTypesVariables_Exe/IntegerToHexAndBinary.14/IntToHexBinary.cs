using System;

namespace IntegerToHexAndBinary     
{
    internal class IntToHexBinary
    {
        public static void Main(string[] args)
        {
            int dec = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(dec, 16).ToUpper());
            Console.WriteLine(Convert.ToString(dec, 2).ToUpper());
        }
    }
}