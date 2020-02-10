using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

// - Procedural code: refactor the code to OOP.
// - Single Responsibility Principle: this class is doing way too much (deserializing, calculations, order processing). Separate these concerns.
// - Multiple deserializers: if the json file doesn't exist we want to deserialize data.xml. Implement this requirement by wrapping these serializers in separated polymorphic classes.
// - Fix the 2 bugs in the stock check.
namespace TrainingShoeby02
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise();
        }

        private static void Exercise()
        {
            // Get the buycount
            Console.WriteLine("How many products would you like to buy?");
            var buyCount = int.Parse(Console.ReadLine());

            // Get the data
            var data = File.ReadAllText("data/data.json");
            var products = JsonConvert.DeserializeObject<List<Product>>(data);

            // Check if enough in stock
            if (buyCount > products.Sum(p => p.Stock))
            {
                Console.WriteLine("Not enough products in stock, order a lower amount.");
                buyCount = int.Parse(Console.ReadLine());
            }

            // Get the discount and instantiate orders
            var discount = GetDiscount(buyCount);
            var orders = products.Aggregate(new List<Order>(), (o, product) =>
            {
                if (buyCount > o.Count)
                {
                    var item = new Order()
                        {Product = product.Name, Price = product.Price * discount, Discount = discount};
                    o.Add(item);
                }

                return o;
            });

            ProcessOrder(orders);

            Console.ReadLine();
        }

        private static void ProcessOrder(List<Order> orders)
        {
            foreach (var order in orders)
            {
                Console.WriteLine(
                    $"Processed order {order.Product}, with price {order.Price:N} and discount {order.Discount:P} succesfully.");
            }
        }

        private static decimal GetDiscount(int buyCount)
        {
            var discount = 0m;

            switch (buyCount)
            {
                case 2:
                    discount = 0.1m;
                    break;
                case 3:
                    discount = 0.2m;
                    break;
                case 4:
                    discount = 0.3m;
                    break;
                default:
                    discount = 0m;
                    break;
            }

            return discount;
        }
    }
}