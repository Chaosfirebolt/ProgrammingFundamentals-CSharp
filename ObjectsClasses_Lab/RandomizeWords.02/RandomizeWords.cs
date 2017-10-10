using System;

namespace RandomizeWords
{
    internal class RandomizeWords
    {
        public static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ');
            Randomize(words);
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }

        private static void Randomize(string[] arr)
        {
            var rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                var j = rnd.Next(i, arr.Length);
                Swap(arr, i, j);
            }
        }

        private static void Swap(string[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}