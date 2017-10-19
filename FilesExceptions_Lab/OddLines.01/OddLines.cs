using System;
using System.IO;
using System.Text;

namespace OddLines
{
    internal class OddLines
    {
        public static void Main(string[] args)
        {
            var path = GetParentProjectPath(Environment.CurrentDirectory, 0, 2) + @"\IO. Odd Lines";
            var lines = File.ReadAllLines(path + @"\Input.txt");
            var output = new StringBuilder();
            for (int i = 1; i < lines.Length; i += 2)
            {
                output.Append(lines[i]).Append(Environment.NewLine);
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