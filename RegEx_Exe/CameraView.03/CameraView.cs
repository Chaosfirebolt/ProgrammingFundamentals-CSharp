using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CameraView
{
    internal class CameraView
    {
        public static void Main(string[] args)
        {
            var quantifiers = ParseQuantifiers(Console.ReadLine());
            var view = Console.ReadLine();
            Console.WriteLine(Capture(view, quantifiers[0], quantifiers[1]));
        }

        private static string Capture(string view, int skip, int take)
        {
            var regex = $@"\|<([^|<]{{0,{skip}}})([^|<]{{0,{take}}})";
            var matches = Regex.Matches(view, regex);
            var shots = new List<string>();
            foreach (Match match in matches)
            {
                shots.Add(match.Groups[2].Value);
            }
            return string.Join(", ", shots);
        }

        private static int[] ParseQuantifiers(string input)
        {
            return input.Split(' ').Select(int.Parse).ToArray();
        }
    }
}