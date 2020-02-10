namespace TrainingShoeby02
{
    public class DiscountCalculator
    {
        public decimal GetDiscount(int buyCount)
        {
            switch (buyCount)
            {
                case 2:
                    return 0.1m;
                case 3:
                    return 0.2m;
                case 4:
                    return 0.3m;
                default:
                    return 0m;
            }
        }
    }
}