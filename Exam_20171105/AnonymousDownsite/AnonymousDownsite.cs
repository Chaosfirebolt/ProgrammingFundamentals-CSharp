using System;
using System.Numerics;
using System.Text;

namespace AnonymousDownsite
{
    internal class AnonymousDownsite
    {
        public static void Main(string[] args)
        {
            var websiteCount = int.Parse(Console.ReadLine());
            var secutiryKey = BigInteger.Parse(Console.ReadLine());
            var totalLoss = 0M;
            var output = new StringBuilder();
            for (int i = 0; i < websiteCount; i++)
            {
                var data = Console.ReadLine().Split(' ');
                output.Append(data[0]).Append(Environment.NewLine);
                totalLoss += decimal.Parse(data[1]) * decimal.Parse(data[2]);
            }
            output.Append($"Total Loss: {totalLoss:F20}").Append(Environment.NewLine);
            output.Append($"Security Token: {BigInteger.Pow(secutiryKey, websiteCount)}");
            Console.Write(output);
        }
    }
}