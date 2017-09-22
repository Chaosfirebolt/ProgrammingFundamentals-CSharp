using System;
using System.Collections.Generic;
using System.Text;

namespace FiveDifferentNumbers
{
    internal class DifferentNumbers
    {
        private static readonly StringBuilder Output = new StringBuilder();
        private static readonly List<int> List = new List<int>();
        
        public static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            if (b - a < 4) {
                Console.Write("No");
            } else {
                Gen(a, b);
                Console.Write(Output);
            }
        }
        
        private static void Gen(int a, int b) {
            if (List.Count == 5) {
                Output.Append(string.Join(" ", List)).Append("\n");
                return;
            }
            for (var i = a; i <= b; i++) {
                if (b - i < 4 - List.Count) {
                    return;
                }
                if (List.Count > 0 && List[List.Count - 1] >= i) {
                    continue;
                }
                List.Add(i);
                Gen(a + 1, b);
                List.RemoveAt(List.Count - 1);
            }
        }
    }
}