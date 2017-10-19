using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WordCount
{
    internal class WordCount
    {
        public static void Main(string[] args)
        {
            var path = GetParentProjectPath(Environment.CurrentDirectory, 0, 2) + @"\IO. Word Count";
            var lines = File.ReadAllLines(path + @"\words.txt");
            var wordCount = GetWords(lines);
            lines = File.ReadAllLines(path + @"\text.txt");
            var allWords = GetAllWords(lines);
            foreach (var word in allWords)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word] += 1;
                }
            }
            var output = new StringBuilder();
            wordCount
                .OrderByDescending(e => e.Value)
                .ToList()
                .ForEach(e => output.Append($"{e.Key} - {e.Value}").Append(Environment.NewLine));
            File.WriteAllText(path + @"\Output.txt", output.ToString().Trim());
        }

        private static List<string> GetAllWords(string[] lines)
        {
            var result = new List<string>();
            foreach (var line in lines)
            {
                var words = Regex.Split(line.ToLower(), "\\b");
                foreach (var word in words)
                {
                    if (word != "")
                    {
                        result.Add(word);
                    }
                }
            }
            return result;
        }

        private static Dictionary<string, int> GetWords(string[] lines)
        {
            var wordCount = new Dictionary<string, int>();
            foreach (var line in lines)
            {
                var words = line.ToLower().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    if (!wordCount.ContainsKey(word))
                    {
                        wordCount.Add(word, 0);
                    }
                }
            }
            return wordCount;
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