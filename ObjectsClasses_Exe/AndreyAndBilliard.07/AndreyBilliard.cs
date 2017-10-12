using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndreyAndBilliard
{
    internal class AndreyBilliard
    {
        public static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var products = new Dictionary<string, Product>();
            for (int i = 0; i < count; i++)
            {
                var newProduct = ParseProduct(Console.ReadLine());
                if (products.ContainsKey(newProduct.Name))
                {
                    products[newProduct.Name].Price = newProduct.Price;
                }
                else
                {
                    products.Add(newProduct.Name, newProduct);
                }
            }
            var clients = new Dictionary<string, Client>();
            var input = Console.ReadLine();
            while (input != null && input != "end of clients")
            {
                var data = input.Split(new []{'-', ','}, StringSplitOptions.RemoveEmptyEntries);
                var product = data[1];
                if (products.ContainsKey(product))
                {
                    var client = data[0];
                    if (!clients.ContainsKey(client))
                    {
                        clients.Add(client, new Client(client));
                    }

                    var quantity = int.Parse(data[2]);
                    if (clients[client].BoughtProducts.ContainsKey(products[product]))
                    {
                        clients[client].BoughtProducts[products[product]] += quantity;
                    }
                    else
                    {
                        clients[client].BoughtProducts.Add(products[product], quantity);
                    }
                }
                
                input = Console.ReadLine();
            }

            var output = new StringBuilder();
            var total = 0M;
            clients.Values
                .OrderBy(cl => cl.Name)
                .ToList()
                .ForEach(cl =>
                {
                    output.Append($"{cl.Name}").Append(Environment.NewLine);
                    foreach (var product in cl.BoughtProducts)
                    {
                        output.Append($"-- {product.Key.Name} - {product.Value}").Append(Environment.NewLine);
                    }
                    var bill = cl.Bill();
                    total += bill;
                    output.Append($"Bill: {bill:F2}").Append(Environment.NewLine);
                });
            output.Append($"Total bill: {total:F2}");
            Console.Write(output);
        }

        private static Product ParseProduct(string input)
        {
            var data = input.Split('-');
            return new Product(data[0], decimal.Parse(data[1]));
        }
    }

    internal class Client
    {
        public string Name { get; }
        public Dictionary<Product, int> BoughtProducts { get; }

        public Client(string name)
        {
            Name = name;
            BoughtProducts = new Dictionary<Product, int>();
        }

        public decimal Bill()
        {
            var total = 0M;
            foreach (var pair in BoughtProducts)
            {
                total += pair.Key.Price * pair.Value;
            }
            return total;
        }
    }

    internal class Product
    {
        public string Name { get; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != typeof(Product))
            {
                return false;
            }
            var other = (Product) obj;
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}