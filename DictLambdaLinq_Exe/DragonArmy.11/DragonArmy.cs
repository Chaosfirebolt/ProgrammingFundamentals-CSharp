using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonArmy
{
    internal class DragonArmy
    {
        public static void Main(string[] args)
        {
            var dragonCount = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, HashSet<Dragon>>();
            for (int i = 0; i < dragonCount; i++)
            {
                var data = Console.ReadLine().Split(' ');
                var dragon = new Dragon(data[1], data[0], data[2], data[3], data[4]);
                if (!dragons.ContainsKey(dragon.Type))
                {
                    dragons.Add(dragon.Type, new HashSet<Dragon>());
                }
                dragons[dragon.Type].Remove(dragon);
                dragons[dragon.Type].Add(dragon);
            }

            var output = new StringBuilder();
            foreach (var pair in dragons)
            {
                var sb = new StringBuilder();
                var totalDamage = 0D;
                var totalHealth = 0D;
                var totalArmor = 0D;
                pair.Value
                    .OrderBy(dr => dr.Name)
                    .ToList()
                    .ForEach(dr =>
                    {
                        sb.Append("-").Append(dr.ToString()).Append(Environment.NewLine);
                        totalDamage += dr.Damage;
                        totalHealth += dr.Health;
                        totalArmor += dr.Armor;
                    });
                var count = pair.Value.Count;
                output.Append($"{pair.Key}::({totalDamage / count:F2}/{totalHealth / count:F2}/{totalArmor / count:F2})").Append(Environment.NewLine);
                output.Append(sb);
            }
            Console.Write(output);
        }
    }

    internal class Dragon
    {
        private const int DefaultDamage = 45;
        private const int DefaultHealth = 250;
        private const int DefaultArmor = 10;
        
        public string Name { get; }
        public string Type { get; }
        public int Damage { get; }
        public int Health { get; }
        public int Armor { get; }

        public Dragon(string name, string type, string damage, string health, string armor)
        {
            Name = name;
            Type = type;
            Damage = TryParse(damage, DefaultDamage);
            Health = TryParse(health, DefaultHealth);
            Armor = TryParse(armor, DefaultArmor);
        }

        public override string ToString()
        {
            return $"{Name} -> damage: {Damage}, health: {Health}, armor: {Armor}";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Dragon))
            {
                return false;
            }
            var other = (Dragon) obj;
            return Name.Equals(other.Name) && Type.Equals(other.Type);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() * 17 + Type.GetHashCode() * 31;
        }

        private static int TryParse(string str, int defaultValue)
        {
            int result;
            if (!int.TryParse(str, out result))
            {
                result = defaultValue;
            }
            return result;
        }
    }
}