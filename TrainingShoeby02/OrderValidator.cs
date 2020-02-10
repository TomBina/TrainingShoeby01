using System.Collections.Generic;
using System.Linq;

namespace TrainingShoeby02
{
    public class OrderValidator
    {
        public bool Validate(int buyCount, List<Product> products) 
            => buyCount <= products.Sum(p => p.Stock);
    }
}