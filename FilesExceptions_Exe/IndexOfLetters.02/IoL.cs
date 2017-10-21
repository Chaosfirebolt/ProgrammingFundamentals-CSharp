using System;
using System.IO;
using System.Text;

namespace IndexOfLetters
{
    internal class IoL
    {
        public static void Main(string[] args)
        {
            var path = GetParentProjectPath(Environment.CurrentDirectory, 0, 2) + @"\IO";
            var lines = File.ReadAllLines(path + @"\input.txt");
            var output = new StringBuilder();
            foreach (var line in lines)
            {
                foreach (var character in line)
                {
                    output.Append($"{character} -> {character - 97}").Append(Environment.NewLine);
                }
                output.Append(Environment.NewLine);
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