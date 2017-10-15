using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Weather
{
    internal class Weather
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var forecasts = new Dictionary<string, City>();
            while (input != null && input != "end")
            {
                var match = Regex.Match(input, @"([A-Z]{2})(\d+\.\d+)([a-zA-Z]+)\|");
                if (match.Success)
                {
                    var city = new City(match.Groups[1].Value, double.Parse(match.Groups[2].Value), match.Groups[3].Value);
                    if (!forecasts.ContainsKey(city.Name))
                    {
                        forecasts.Add(city.Name, city);
                    }
                    else
                    {
                        forecasts[city.Name] = city;
                    }
                }
                
                input = Console.ReadLine();
            }

            Console.Write(string.Join(Environment.NewLine, forecasts.Values.OrderBy(f => f.Temperature).ToList()));
        }
    }

    internal class City
    {
        public string Name { get; }
        public double Temperature { get; }
        private string WeatherType { get; }

        public City(string name, double temperature, string weatherType)
        {
            Name = name;
            Temperature = temperature;
            WeatherType = weatherType;
        }

        public override string ToString()
        {
            return $"{Name} => {Temperature:F2} => {WeatherType}";
        }
    }
}