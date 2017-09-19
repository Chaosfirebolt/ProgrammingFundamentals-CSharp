using System;
using System.Text;

namespace DebitCardNumber
{
    internal class DebitCardNumber
    {
        public static void Main(string[] args)
        {
            var output = new StringBuilder();
            for (var i = 0; i < 4; i++)
            {
                var input = Console.ReadLine();
                if (input != null)
                {
                    output.Append(input.PadLeft(4, '0')).Append(" ");
                }
            }
            Console.WriteLine(output.ToString().Trim());
        }
    }
}