using System;

namespace FastPrimeCheckerRefactor
{
    internal class PrimeChecker
    {
        public static void Main(string[] args)
        {
            int lastNumber = int.Parse(Console.ReadLine());
            for (int currNumber = 2; currNumber <= lastNumber; currNumber++)
            {    
                bool isPrime = true;
                int lastCheck = (int) Math.Sqrt(currNumber);
                for (int checker = 2; checker <= lastCheck; checker++)
                {
                    if  (currNumber % checker == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currNumber} -> {isPrime}");
            }
        }
    }
}