using System;
using System.Collections.Generic;
using System.Text;

namespace MinerTask
{
    internal class MinerTask
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var resources = new Dictionary<string, long>();
            while (input != null && input != "stop")
            {
                var resource = input;
                long quantity;
                var valid = long.TryParse(Console.ReadLine(), out quantity);
                if (!valid)
                {
                    continue;
                }
                if (resources.ContainsKey(resource))
                {
                    resources[resource] += quantity;
                }
                else
                {
                    resources.Add(resource, quantity);
                }
                
                input = Console.ReadLine();
            }

            var output = new StringBuilder();
            foreach (var pair in resources)
            {
                output.Append($"{pair.Key} -> {pair.Value}").Append(Environment.NewLine);
            }
            Console.Write(output);
        }
    }
}