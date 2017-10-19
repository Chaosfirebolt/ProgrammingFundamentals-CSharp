using System;
using System.IO;

namespace FolderSize
{
    internal class FolderSize
    {
        private static double _size;
        private const double ToMegabyte = 1024 * 1024;
        
        public static void Main(string[] args)
        {
            var inputPath = GetParentProjectPath(Environment.CurrentDirectory, 0, 4);
            var info = new DirectoryInfo(inputPath);
            CalcSize(info);
            var outputPath = GetParentProjectPath(Environment.CurrentDirectory, 0, 2) + @"\IO. Folder Size";
            File.WriteAllText(outputPath + @"\Output.txt", $"{_size}");
        }

        private static void CalcSize(DirectoryInfo directoryInfo)
        {
            var files = directoryInfo.EnumerateFiles();
            foreach (var fileInfo in files)
            {
                _size += fileInfo.Length / ToMegabyte;
            }
            var dirs = directoryInfo.EnumerateDirectories();
            foreach (var dirInfo in dirs)
            {
                CalcSize(new DirectoryInfo(directoryInfo.FullName + @"\" + dirInfo.Name));
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