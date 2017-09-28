using System;
using System.Text;

namespace Triples
{
    internal class Triples
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder output = new StringBuilder();
            const char a = 'a';
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    for (int k = 0; k < n; k++) {
                        output.Append((char) (a + i)).Append((char) (a + j)).Append((char) (a + k)).Append("\r\n");
                    }
                }
            }
            Console.Write(output);
        }
    }
}