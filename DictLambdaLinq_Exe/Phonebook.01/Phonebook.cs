﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Phonebook
{
    internal class Phonebook
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var phonebook = new Dictionary<string, string>();
            var output = new StringBuilder();
            while (input != "END")
            {
                if (input == null)
                {
                    continue;
                }
                var data = input.Split(' ');
                string name;
                switch (data[0])
                {
                    case "A":
                        name = data[1];
                        var phone = data[2];
                        if (phonebook.ContainsKey(name))
                        {
                            phonebook[name] = phone;
                        }
                        else
                        {
                            phonebook.Add(name, phone);
                        }
                        break;
                    case "S":
                        name = data[1];
                        output.Append(phonebook.ContainsKey(name) ? $"{name} -> {phonebook[name]}" : $"Contact {name} does not exist.")
                            .Append(Environment.NewLine);
                        break;
                }
                
                input = Console.ReadLine();
            }
            Console.Write(output);
        }
    }
}