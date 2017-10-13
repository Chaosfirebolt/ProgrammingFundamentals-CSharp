using System;
using System.Text;

namespace ReverseString
{
    internal class ReverseString
    {
        public static void Main(string[] args)
        {
            var str = Console.ReadLine();
            Console.WriteLine(Reverse(str));
        }

        private static string Reverse(string str)
        {
            var output = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                output.Append(str[i]);
            }
            return output.ToString();
        }
    }
}