﻿using System.Collections.Generic;

 namespace TrainingShoeby02
{
    class Program
    {
        static void Main(string[] args)
        {
            var rawDataSource = new FileDataSource("data/data.xml");
            var deserializers = new Dictionary<DataType, IDeserializer>()
            {
                [DataType.Json] = new JsonDeserializer(),
                [DataType.Xml] = new XmlDeserializer()
            };
            var repo = new ProductsRepository(rawDataSource, deserializers);
            var products = repo.GetAll();
            var userInterface = UserInterface.Instance;
            var orderValidator = new OrderValidator();
            var buyCount = userInterface.GetBuyCount();

            while (!orderValidator.Validate(buyCount, products))
            {
                userInterface.Message("Not enough products in stock, order a lower amount.");
                buyCount = userInterface.GetBuyCount();
            }

            userInterface.Message(buyCount + " valid!");

            var discountCalculator = new DiscountCalculator();
            var discount = discountCalculator.GetDiscount(buyCount);
            var orders = OrderFactory.Create(buyCount, products, discount);
            var orderProcessor = new OrderProcessor(userInterface);
            
            orderProcessor.ProcessBatch(orders);
        }
    }
}