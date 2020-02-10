using System.Collections.Generic;

namespace TrainingShoeby02
{
    public class ProductsRepository : Repository<Product>
    {
        private readonly IRawDataSource _rawDataSource;
        private readonly Dictionary<DataType, IDeserializer> _deserializers;
        
        public ProductsRepository(IRawDataSource rawDataSource, Dictionary<DataType, IDeserializer> deserializers)
        {
            _rawDataSource = rawDataSource;
            _deserializers = deserializers;
        }

        public override List<Product> GetAll()
        {
            var data = _rawDataSource.GetData();

            var deserializer = _deserializers[data.type];
            var products = deserializer.Deserialize<List<Product>>(data.data);

            return products;
        }
    }
}