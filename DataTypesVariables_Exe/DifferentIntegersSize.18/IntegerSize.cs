using System;
using System.Text;

namespace DifferentIntegersSize
{
    internal class IntegerSize
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var count = 0;
            var output = new StringBuilder();
            output.Append($"{input} can fit in:\r\n");
            
            sbyte num;
            var result = sbyte.TryParse(input, out num);
            count = result ? count + 1 : count;
            output.Append(result ? "* sbyte\r\n" : "");
            
            byte num2;
            result = byte.TryParse(input, out num2);
            count = result ? count + 1 : count;
            output.Append(result ? "* byte\r\n" : "");
            
            short num3;
            result = short.TryParse(input, out num3);
            count = result ? count + 1 : count;
            output.Append(result ? "* short\r\n" : "");
            
            ushort num4;
            result = ushort.TryParse(input, out num4);
            output.Append(result ? "* ushort\r\n" : "");
            
            int num5;
            result = int.TryParse(input, out num5);
            count = result ? count + 1 : count;
            output.Append(result ? "* int\r\n" : "");
            
            uint num6;
            result = uint.TryParse(input, out num6);
            count = result ? count + 1 : count;
            output.Append(result ? "* uint\r\n" : "");
            
            long num7;
            result = long.TryParse(input, out num7);
            count = result ? count + 1 : count;
            output.Append(result ? "* long\r\n" : "");

            if (count > 0)
            {
                Console.Write(output);
            }
            else
            {
                Console.Write($"{input} can't fit in any type");
            }
        }
    }
}