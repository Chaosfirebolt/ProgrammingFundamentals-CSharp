﻿using System;

namespace DivisibleByThree
{
    internal class Divisible
    {
        public static void Main(string[] args)
        {
            for (var i = 3; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}