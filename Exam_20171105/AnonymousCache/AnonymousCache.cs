using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AnonymousCache
{
    internal class AnonymousCache
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dataSets = new Dictionary<string, LinkedList<Data>>();
            var cache = new Dictionary<string, LinkedList<Data>>();
            var regex = new Regex(@"^(.+?)\s+->\s+(\d+)\s+\|\s+(.+?)$");
            while (input != null && input != "thetinggoesskrra")
            {
                var match = regex.Match(input);
                if (match.Success)
                {
                    var key = match.Groups[1].Value;
                    var size = long.Parse(match.Groups[2].Value);
                    var data = new Data(key, size);
                    var set = match.Groups[3].Value;
                    if (dataSets.ContainsKey(set))
                    {
                        dataSets[set].AddLast(data);
                    }
                    else
                    {
                        if (!cache.ContainsKey(set))
                        {
                            cache.Add(set, new LinkedList<Data>());
                        }
                        cache[set].AddLast(data);
                    }
                }
                else
                {
                    if (cache.ContainsKey(input))
                    {
                        dataSets.Add(input, cache[input]);
                        cache.Remove(input);
                    }
                    else
                    {
                        dataSets.Add(input, new LinkedList<Data>());
                    }
                }
                
                input = Console.ReadLine();
            }

            var maxSet = "";
            var maxSize = long.MinValue;
            foreach (var dataSet in dataSets)
            {
                long size = 0;
                foreach (var data in dataSet.Value)
                {
                    size += data.Size;
                }
                if (size > maxSize)
                {
                    maxSize = size;
                    maxSet = dataSet.Key;
                }
            }

            var output = new StringBuilder();
            if (dataSets.ContainsKey(maxSet))
            {
                output.Append($"Data Set: {maxSet}, Total Size: {maxSize}");
                var dataSet = dataSets[maxSet];
                foreach (var data in dataSet)
                {
                    output.Append(Environment.NewLine).Append($"$.{data.Key}");
                }
            }
            Console.Write(output);
        }
    }

    internal class Data
    {
        public string Key { get; }
        public long Size { get; }

        public Data(string key, long size)
        {
            Key = key;
            Size = size;
        }
    }
}