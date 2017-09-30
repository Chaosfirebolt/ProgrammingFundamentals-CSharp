﻿using System;

namespace ExchangeVarValues
{
    internal class ExchangeVarValues
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before:\r\na = {a}\r\nb = {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After:\r\na = {a}\r\nb = {b}");
        }
    }
}