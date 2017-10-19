using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MergeFiles
{
    internal class MergeFiles
    {
        public static void Main(string[] args)
        {
            var path = GetParentProjectPath(Environment.CurrentDirectory, 0, 2) + @"\IO. Merge Files";
            var linesFirst = File.ReadAllLines(path + @"\FileOne.txt");
            var linesSecond = File.ReadAllLines(path + @"\FileTwo.txt");
            var lines = new List<string>();
            lines.AddRange(linesFirst);
            lines.AddRange(linesSecond);
            lines.Sort();
            var output = new StringBuilder();
            foreach (var line in lines)
            {
                output.Append(line).Append(Environment.NewLine);
            }
            File.WriteAllText(path + @"\Output.txt", output.ToString().Trim());
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