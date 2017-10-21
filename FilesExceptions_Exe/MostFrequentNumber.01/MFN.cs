using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MostFrequentNumber
{
    internal class MFN
    {
        public static void Main(string[] args)
        {
            var path = GetParentProjectPath(Environment.CurrentDirectory, 0, 2) + @"\IO";
            var lines = File.ReadAllLines(path + @"\input.txt");
            var output = new StringBuilder();
            foreach (var line in lines)
            {
                var numbers = line.Split(' ').Select(int.Parse).ToList();
                var numCount = new Dictionary<int, int>();
                foreach (var number in numbers)
                {
                    if (numCount.ContainsKey(number))
                    {
                        numCount[number]++;
                    }
                    else
                    {
                        numCount.Add(number, 0);
                    }
                }
                var num = 0;
                var count = int.MinValue;
                foreach (var pair in numCount)
                {
                    if (pair.Value > count)
                    {
                        count = pair.Value;
                        num = pair.Key;
                    }
                }
                output.Append(num).Append(Environment.NewLine);
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