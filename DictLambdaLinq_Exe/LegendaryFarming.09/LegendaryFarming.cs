using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegendaryFarming
{
    internal class LegendaryFarming
    {
        private const string Shards = "shards";
        private const string Fragments = "fragments";
        private const string Motes = "motes";
        
        public static void Main(string[] args)
        {
            var keyMaterials = InitKeyMats();
            var junk = new SortedDictionary<string, int>();
            var input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                var materials = input.ToLower().Split(' ');
                for (int i = 0; i < materials.Length; i += 2)
                {
                    var mat = materials[i + 1];
                    var quantity = int.Parse(materials[i]);
                    if (IsKeyMaterial(mat))
                    {
                        AddDict(keyMaterials, mat, quantity);

                        if (keyMaterials[mat] >= 250)
                        {
                            keyMaterials[mat] -= 250;
                            var legendary = "";
                            switch (mat)
                            {
                                case Shards:
                                    legendary = "Shadowmourne";
                                    break;
                                case Motes:
                                    legendary = "Dragonwrath";
                                    break;
                                case Fragments:
                                    legendary = "Valanyr";
                                    break;
                            }
                            Print(legendary, keyMaterials, junk);
                            return;
                        }
                    }
                    else
                    {
                        AddDict(junk, mat, quantity);
                    }
                }
                
                input = Console.ReadLine();
            }
        }

        private static void Print(string legendary, Dictionary<string, int> keyMaterials, SortedDictionary<string, int> junk)
        {
            var output = new StringBuilder($"{legendary} obtained!");
            keyMaterials
                .OrderByDescending(kp => kp.Value)
                .ThenBy(kp => kp.Key)
                .ToList()
                .ForEach(kp => output.Append(Environment.NewLine).Append($"{kp.Key}: {kp.Value}"));
            foreach (var jp in junk)
            {
                output.Append(Environment.NewLine).Append($"{jp.Key}: {jp.Value}");
            }
            Console.Write(output);
        }

        private static void AddDict(IDictionary<string, int> dictionary, string key, int value)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary[key] += value;
            }
            else
            {
                dictionary.Add(key, value);
            }
        }

        private static Dictionary<string, int> InitKeyMats()
        {
            return new Dictionary<string, int>{{Shards, 0}, {Motes, 0}, {Fragments, 0}};
        }

        private static bool IsKeyMaterial(string mat)
        {
            return mat == Shards || mat == Motes || mat == Fragments;
        }
    }
}