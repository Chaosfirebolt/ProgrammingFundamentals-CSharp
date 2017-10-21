using System;
using System.IO;
using System.Text;

namespace FixEmails
{
    internal class FE
    {
        public static void Main(string[] args)
        {
            var path = GetParentProjectPath(Environment.CurrentDirectory, 0, 2) + @"\IO";
            var lines = File.ReadAllLines(path + @"\input.txt");
            var output = new StringBuilder();
            for (int i = 0; i < lines.Length; i += 2)
            {
                var name = lines[i];
                if (name == "stop")
                {
                    break;
                }
                var email = lines[i + 1].ToLower();
                if (!email.EndsWith("us") && !email.EndsWith("uk"))
                {
                    output.Append($"{name} -> {email}").Append(Environment.NewLine);
                }
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