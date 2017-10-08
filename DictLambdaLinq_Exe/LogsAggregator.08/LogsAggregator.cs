using System;
using System.Collections.Generic;
using System.Text;

namespace LogsAggregator
{
    internal class LogsAggregator
    {
        public static void Main(string[] args)
        {
            int count;
            if (!int.TryParse(Console.ReadLine(), out count))
            {
                return;
            }
            
            var userTimes = new SortedDictionary<string, int>();
            var userIps = new Dictionary<string, SortedSet<string>>();
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine();
                if (input == null)
                {
                    continue;
                }

                var data = input.Split(' ');
                var ip = data[0];
                var user = data[1];
                var time = int.Parse(data[2]);

                if (userIps.ContainsKey(user))
                {
                    userIps[user].Add(ip);
                    userTimes[user] += time;
                }
                else
                {
                    var ips = new SortedSet<string> {ip};
                    userIps.Add(user, ips);
                    userTimes.Add(user, time);
                }
            }

            var output = new StringBuilder();
            foreach (var pair in userTimes)
            {
                output.Append($"{pair.Key}: {pair.Value} [{string.Join(", ", userIps[pair.Key])}]").Append(Environment.NewLine);
            }
            Console.Write(output);
        }
    }
}