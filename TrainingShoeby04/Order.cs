namespace TrainingShoeby04
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public decimal Amount { get; set; }

        public override string ToString()
            => $"Order {Id}, Amount {Amount}, Customer {Customer.Name}";
    }
}