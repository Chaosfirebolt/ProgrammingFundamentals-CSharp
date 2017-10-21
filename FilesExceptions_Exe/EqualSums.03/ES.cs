using System;
using System.IO;
using System.Linq;
using System.Text;

namespace EqualSums
{
    internal class ES
    {
        public static void Main(string[] args)
        {
            
            var path = GetParentProjectPath(Environment.CurrentDirectory, 0, 2) + @"\IO";
            var lines = File.ReadAllLines(path + @"\input.txt");
            var output = new StringBuilder();
            foreach (var line in lines)
            {
                var numbers = line.Split(' ').Select(int.Parse).ToArray();
                var leftSums = new int[numbers.Length];
                var rightSums = new int[numbers.Length];
                CalcSums(numbers, leftSums, rightSums);
                var index = FindIndex(leftSums, rightSums);
                output.Append(index == -1 ? "no" : index.ToString()).Append(Environment.NewLine);
            }
            File.WriteAllText(path + @"\output.txt", output.ToString().Trim());
        }
        
        private static int FindIndex(int[] leftSums, int[] rightSums)
        {
            for (int i = 0; i < leftSums.Length; i++)
            {
                if (leftSums[i] != rightSums[i])
                {
                    continue;
                }
                return i;
            }
            return -1;
        }

        private static void CalcSums(int[] numbers, int[] leftSums, int[] rightSums)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                leftSums[i] = leftSums[i - 1] + numbers[i - 1];
                var rightSumsIndex = numbers.Length - i;
                rightSums[numbers.Length - 1 - i] = rightSums[rightSumsIndex] + numbers[rightSumsIndex];
            }
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