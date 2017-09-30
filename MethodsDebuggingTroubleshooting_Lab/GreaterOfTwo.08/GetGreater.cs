using System;

namespace GreaterOfTwo
{
    internal class GetGreater
    {
        public static void Main(string[] args)
        {
            var type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    var a = int.Parse(Console.ReadLine());
                    var b = int.Parse(Console.ReadLine());
                    Console.Write(GetMaxGeneric(a, b));
                    break;
                case "char":
                    var char1 = char.Parse(Console.ReadLine());
                    var char2 = char.Parse(Console.ReadLine());
                    Console.Write(GetMaxGeneric(char1, char2));
                    break;
                case "string":
                    Console.Write(GetMaxGeneric(Console.ReadLine(), Console.ReadLine()));
                    break;
                default:
                    return;
            }
        }

        private static T GetMaxGeneric<T>(T first, T second) where T : IComparable<T>
        {
            var cmp = first.CompareTo(second);
            return cmp >= 0 ? first : second;
        }
    }
}