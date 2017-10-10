using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesReport
{
    internal class SalesReport
    {
        public static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var sales = new Dictionary<string, List<Sale>>();
            for (int i = 0; i < count; i++)
            {
                var sale = Sale.ReadSale(Console.ReadLine());
                if (sales.ContainsKey(sale.Town))
                {
                    sales[sale.Town].Add(sale);
                }
                else
                {
                    var list = new List<Sale>{sale};
                    sales.Add(sale.Town, list);
                }
            }
            var output = new StringBuilder();
            sales
                .OrderBy(p => p.Key)
                .ToList()
                .ForEach(p =>
                {
                    output.Append(p.Key).Append(" -> ");
                    var total = p.Value.Sum(s => s.Price * s.Quantity);
                    output.Append($"{total:F2}").Append(Environment.NewLine);
                });
            Console.Write(output);
        }
    }

    internal class Sale
    {
        public string Town { get; }
        public string Product { get; }
        public decimal Price { get; }
        public decimal Quantity { get; }

        public Sale(string town, string product, decimal price, decimal quantity)
        {
            Town = town;
            Product = product;
            Price = price;
            Quantity = quantity;
        }

        public static Sale ReadSale(string input)
        {
            var data = input.Split(' ');
            return new Sale(data[0], data[1], decimal.Parse(data[2]), decimal.Parse(data[3]));
        }
    }
}