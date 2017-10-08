using System;
using System.Text;

namespace FixEmails
{
    internal class FixEmails
    {
        public static void Main(string[] args)
        {
            var output = new StringBuilder();
            var input = Console.ReadLine();
            while (input != null && input != "stop")
            {
                var name = input;
                var email = Console.ReadLine();
                if (email != null && !email.EndsWith("us") && !email.EndsWith("uk"))
                {
                    output.Append($"{name} -> {email}").Append(Environment.NewLine);
                }
                
                input = Console.ReadLine();
            }
            Console.Write(output);
        }
    }
}