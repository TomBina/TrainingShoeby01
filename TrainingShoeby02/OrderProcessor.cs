using System.Collections.Generic;

namespace TrainingShoeby02
{
    public class OrderProcessor
    {
        private readonly UserInterface _userInterface;

        public OrderProcessor(UserInterface userInterface)
        {
            _userInterface = userInterface;
        }

        public void ProcessBatch(List<Order> orders)
        {
            foreach (var order in orders)
            {
                _userInterface.Message($"Processed order {order.Product}, with price {order.Price:N} and discount {order.Discount:P} succesfully.");
            }
        }
    }
}