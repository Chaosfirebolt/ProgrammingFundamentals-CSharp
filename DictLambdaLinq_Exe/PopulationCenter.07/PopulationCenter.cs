using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PopulationCenter
{
    internal class PopulationCenter
    {
        public static void Main(string[] args)
        {
            var countries = new Dictionary<string, ulong>();
            var countriesCities = new Dictionary<string, Dictionary<string, int>>();
            var input = Console.ReadLine();
            while (input != null && input != "report")
            {
                var data = input.Split('|');
                var city = data[0];
                var country = data[1];
                var population = int.Parse(data[2]);
                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, (ulong) population);

                    var cityData = new Dictionary<string, int> {{city, population}};
                    countriesCities.Add(country, cityData);
                }
                else
                {
                    countries[country] += (ulong) population;
                    countriesCities[country].Add(city, population);
                }
                
                input = Console.ReadLine();
            }

            var output = new StringBuilder();
            countries
                .OrderByDescending(pair => pair.Value)
                .ToList()
                .ForEach(pair =>
                {
                    output.Append($"{pair.Key} (total population: {pair.Value})").Append(Environment.NewLine);
                    countriesCities[pair.Key]
                        .OrderByDescending(cp => cp.Value)
                        .ToList()
                        .ForEach(cp => output.Append($"=>{cp.Key}: {cp.Value}").Append(Environment.NewLine));
                });
            Console.Write(output);
        }
    }
}