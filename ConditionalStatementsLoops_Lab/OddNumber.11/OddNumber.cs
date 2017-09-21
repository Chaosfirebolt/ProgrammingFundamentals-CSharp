using System;

namespace OddNumber
{
    internal class OddNumber
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (input != null)
            {
                var number = int.Parse(input);
                var output = number % 2 != 0 ? $"The number is: {Math.Abs(number)}" : "Please write an odd number.";
                Console.WriteLine(output);
                
                input = Console.ReadLine();
            }
        }
    }
}