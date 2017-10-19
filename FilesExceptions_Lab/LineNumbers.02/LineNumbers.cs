using System;
using System.IO;
using System.Text;

namespace LineNumbers
{
    internal class LineNumbers
    {
        public static void Main(string[] args)
        {
            var path = GetParentProjectPath(Environment.CurrentDirectory, 0, 2) + @"\IO. Line Numbers";
            var lines = File.ReadAllLines(path + @"\Input.txt");
            var output = new StringBuilder();
            for (int i = 0; i < lines.Length; i++)
            {
                output.Append($"{i + 1}. {lines[i]}").Append(Environment.NewLine);
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