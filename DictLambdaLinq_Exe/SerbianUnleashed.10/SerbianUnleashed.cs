using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SerbianUnleashed
{
    internal class SerbianUnleashed
    {
        public static void Main(string[] args)
        {
            var venueSingerIncome = new Dictionary<string, Dictionary<string, long>>();
            var regex = new Regex("(.+?)\\s+@(.+?)\\s+(\\d+)\\s+(\\d+)");
            var input = Console.ReadLine();
            while (input != null && input != "End")
            {
                var match = regex.Match(input);
                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }
                var singer = match.Groups[1].Value;
                var venue = match.Groups[2].Value;
                var income = long.Parse(match.Groups[3].Value) * long.Parse(match.Groups[4].Value);
                if (venueSingerIncome.ContainsKey(venue))
                {
                    if (venueSingerIncome[venue].ContainsKey(singer))
                    {
                        venueSingerIncome[venue][singer] += income;
                    }
                    else
                    {
                        venueSingerIncome[venue].Add(singer, income);
                    }
                }
                else
                {
                    venueSingerIncome.Add(venue, new Dictionary<string, long>());
                    venueSingerIncome[venue].Add(singer, income);
                }
                
                input = Console.ReadLine();
            }

            var output = new StringBuilder();
            foreach (var pair in venueSingerIncome)
            {
                output.Append(pair.Key).Append(Environment.NewLine);
                pair.Value
                    .OrderByDescending(p => p.Value)
                    .ToList()
                    .ForEach(p => output.Append($"#  {p.Key} -> {p.Value}").Append(Environment.NewLine));
            }
            Console.Write(output);
        }
    }
}