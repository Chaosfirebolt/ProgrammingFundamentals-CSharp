﻿using System;

namespace AddTwoNumbers
{
    internal class AddTwoNumbers
    {
        public static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
    }
}