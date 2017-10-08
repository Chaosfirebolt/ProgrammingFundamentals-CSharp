using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserLogs
{
    internal class UserLogs
    {
        public static void Main(string[] args)
        {
            var users = new SortedDictionary<string, Dictionary<string, int>>();
            var input = Console.ReadLine();
            while (input != null && input != "end")
            {
                var data = input.Split(' ');
                var ip = GetValue(data, 0);
                var username = GetValue(data, 2);
                if (!users.ContainsKey(username))
                {
                    users.Add(username, new Dictionary<string, int>());
                    users[username].Add(ip, 1);
                }
                else
                {
                    if (!users[username].ContainsKey(ip))
                    {
                        users[username].Add(ip, 1);
                    }
                    else
                    {
                        users[username][ip] += 1;
                    }
                }
                
                input = Console.ReadLine();
            }

            var output = new StringBuilder();
            foreach (var pair in users)
            {
                output.Append($"{pair.Key}:").Append(Environment.NewLine)
                    .Append(string.Join(", ", pair.Value.Select(ip => $"{ip.Key} => {ip.Value}").ToList()))
                    .Append(".").Append(Environment.NewLine);
            }
            Console.Write(output);
        }

        private static string GetValue(string[] data, int index)
        {
            return data[index].Split('=')[1];
        }
    }
}