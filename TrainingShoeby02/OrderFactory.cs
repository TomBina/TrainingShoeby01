using System.Collections.Generic;
using System.Linq;

namespace TrainingShoeby02
{
    public static class OrderFactory
    {
        public static List<Order> Create(int buyCount, List<Product> products, decimal discount)
        {
            var orders = new List<Order>();
        
            for (var i = 0; i <= buyCount - 1; i++)
            {
                var product = products.First(p => p.Stock > 0);
                orders.Add(new Order()
                {
                    Product = product.Name,
                    Price = product.Price * discount,
                    Discount = discount
                });

                product.Stock = --product.Stock;
            }

            return orders;
        }
    }
}