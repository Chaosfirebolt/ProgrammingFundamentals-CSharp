using System;
using System.Text;

namespace MagicLetter
{
    internal class MagicLetter
    {
        public static void Main(string[] args)
        {
            var first = Console.ReadLine()[0];
            var last = Console.ReadLine()[0];
            var excluded = Console.ReadLine()[0];
            var output = new StringBuilder();
            for (int i = first; i <= last; i++) {
                if (i == excluded) {
                    continue;
                }
                for (int j = first; j <= last; j++) {
                    if (j == excluded) {
                        continue;
                    }
                    for (int k = first; k <= last; k++) {
                        if (k == excluded) {
                            continue;
                        }
                        output.Append((char) i).Append((char) j).Append((char) k).Append(" ");
                    }
                }
            }
            Console.WriteLine(output);
        }
    }
}