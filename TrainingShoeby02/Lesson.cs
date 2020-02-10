using System;
using System.Collections.Generic;

namespace TrainingShoeby02
{
    public class Lesson
    {
        // Exercise
        // The business requires us to make an app that can produce the following reports.
        // -> Number of orders
        // -> Total Revenue
        // -> Sold products
        // -> Orders that have more than 500m value, should be separated.
        
        public static void Init()
        {
            var purchaseOrders = GetPurchaseOrders();

            decimal totalRevenueOfSmallOrders = 0m;
            decimal totalRevenueOfBigOrders = 0m;
            decimal numberOfSmallOrders = 0m;
            decimal numberOfBigOrders = 0m;
            int totalProductsOfBigOrders = 0;
            int totalProductsOfSmallOrders = 0;
            
            foreach (var order in purchaseOrders)
            {
                decimal orderRevenue = 0m;

                foreach (var product in order.Products)
                {
                    orderRevenue += product.Price;
                }

                if (orderRevenue > 500m)
                {
                    numberOfBigOrders += 1;
                    totalRevenueOfBigOrders += orderRevenue;
                    totalProductsOfBigOrders += order.Products.Count;
                }
                else
                {
                    numberOfSmallOrders += 1;
                    totalRevenueOfSmallOrders += orderRevenue;
                    totalProductsOfSmallOrders += order.Products.Count;
                }
            }
        }

        public static List<PurchaseOrder> GetPurchaseOrders()
        {
            var product1 = new Product()
            {
                Name = "Testproduct 1",
                Price = 100m,
                Stock = 10
            };
            var product2 = new Product()
            {
                Name = "Testproduct 2",
                Price = 200m,
                Stock = 20
            };

            var products = new List<Product>()
            {
                product1, product2, product1
            };

            var purchaseOrder = new PurchaseOrder()
            {
                Id = Guid.NewGuid(),
                Products = products
            };
            
            var purchaseOrders = new List<PurchaseOrder>()
            {
                purchaseOrder, purchaseOrder, purchaseOrder
            };

            return purchaseOrders;
        }
    }

    public class PurchaseOrder
    {
        public Guid Id { get; set; }
        public List<Product> Products { get; set; }
    }
}