using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MaxSequenceEqual
{
    internal class MSE
    {
        public static void Main(string[] args)
        {
            var path = GetParentProjectPath(Environment.CurrentDirectory, 0, 2) + @"\IO";
            var lines = File.ReadAllLines(path + @"\input.txt");
            var output = new StringBuilder();
            foreach (var line in lines)
            {
                output.Append(FindSequence(line.Split(' '))).Append(Environment.NewLine);
            }
            File.WriteAllText(path + @"\output.txt", output.ToString().Trim());
        }
        
        private static string FindSequence(string[] arr)
        {
            var sequence = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (sequence.Count >= arr.Length - i)
                {
                    break;
                }
                var curr = arr[i];
                var currSeq = new List<string> {curr};
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (!curr.Equals(arr[j]))
                    {
                        break;
                    }
                    currSeq.Add(arr[j]);
                }
                if (currSeq.Count > sequence.Count)
                {
                    sequence = currSeq;
                }
            }
            return string.Join(" ", sequence);
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