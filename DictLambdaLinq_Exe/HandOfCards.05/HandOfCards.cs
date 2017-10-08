using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandOfCards
{
    internal class HandOfCards
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var hands = new Dictionary<string, HashSet<string>>();
            while (input != null && input != "JOKER")
            {
                var data = input.Split(':');
                var name = data[0];
                var cards = data[1].Trim().Split(',').Select(s => s.Trim()).ToArray();
                if (hands.ContainsKey(name))
                {
                    foreach (var card in cards)
                    {
                        hands[name].Add(card);
                    }
                }
                else
                {
                    var hand = new HashSet<string>();
                    foreach (var card in cards)
                    {
                        hand.Add(card);
                    }
                    hands.Add(name, hand);
                }
                
                input = Console.ReadLine();
            }

            var valueMap = InitValueMap();
            var output = new StringBuilder();
            foreach (var pair in hands)
            {
                var sum = 0;
                var cards = pair.Value;
                foreach (var card in cards)
                {
                    var power = card.Substring(0, card.Length  - 1);
                    var type = card.Substring(card.Length - 1);
                    sum += valueMap[power] * valueMap[type];
                }
                output.Append($"{pair.Key}: {sum}").Append(Environment.NewLine);
            }
            Console.Write(output);
        }

        private static Dictionary<string, int> InitValueMap()
        {
            var map = new Dictionary<string, int>();
            var powers = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            for (int i = 0; i < powers.Length; i++)
            {
                map.Add(powers[i], i + 2);
            }

            var types = new[] { "C", "D", "H", "S" };
            for (int i = 0; i < types.Length; i++)
            {
                map.Add(types[i], i + 1);
            }
            return map;
        }
    }
}