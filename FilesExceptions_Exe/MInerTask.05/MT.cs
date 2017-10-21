using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MinerTask
{
    internal class MT
    {
        public static void Main(string[] args)
        {
            var path = GetParentProjectPath(Environment.CurrentDirectory, 0, 2) + @"\IO";
            var lines = File.ReadAllLines(path + @"\input.txt");
            var output = new StringBuilder();
            var resources = new Dictionary<string, long>();
            for (int i = 0; i < lines.Length; i += 2)
            {
                var resource = lines[i];
                if (resource == "stop")
                {
                    break;
                }
                var quantity  = long.Parse(lines[i + 1]);
                if (resources.ContainsKey(resource))
                {
                    resources[resource] += quantity;
                }
                else
                {
                    resources.Add(resource, quantity);
                }
            }
            foreach (var pair in resources)
            {
                output.Append($"{pair.Key} -> {pair.Value}").Append(Environment.NewLine);
            }
            File.WriteAllText(path + @"\output.txt", output.ToString().Trim());
        }
        
        private static string GetParentProjectPath(string currPath, int currDirCount, int dirUpCount)
        {
            if (currDirCount == dirUpCount)
            {
                return currPath;
            }
            var parent = GetParentProjectPath(Directory.GetParent(currPath).ToString(), currDirCount + 1, dirUpCount);
            return parent;
        }
    }
}