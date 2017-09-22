using System;

namespace NeighbourWars
{
    internal class NeighbourWars
    {
        public static void Main(string[] args)
        {
            var peshoDmg = int.Parse(Console.ReadLine());
            var goshoDmg = int.Parse(Console.ReadLine());

            var pesho = 100;
            var gosho = 100;
            var round = 0;
            string winner;
            while (true) {
                round++;
                if (round % 2 != 0) {
                    gosho -= peshoDmg;
                    if (gosho <= 0) {
                        winner = "Pesho";
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {gosho} health.");
                } else {
                    pesho -= goshoDmg;
                    if (pesho <= 0) {
                        winner = "Gosho";
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {pesho} health.");
                }
                if (round % 3 == 0) {
                    pesho += 10;
                    gosho += 10;
                }
            }
            Console.WriteLine($"{winner} won in {round}th round.");
        }
    }
}