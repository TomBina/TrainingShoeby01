using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TrainingShoeby04
{
    internal class ReportGenerator
    {
        private readonly string _fileName;

        public ReportGenerator(string fileName)
        {
            _fileName = fileName;
        }

        public Task<Report> GenerateAsync()
        {
            var task = new Task<Report>(() =>
            {
                var contents = File.ReadAllText(_fileName);
                var orders = JsonConvert.DeserializeObject<List<Order>>(contents);

                var uniqueCustomers = orders.Select(o => o.Customer).Distinct().Count();
                var uniqueOrders = orders.Count;
                var totalOrderValue = orders.Sum(o => o.Amount);
                var highestOrderId = orders.Max(o => o.Id);

                return new Report()
                {
                    UniqueCustomers = uniqueCustomers,
                    UniqueOrders = uniqueOrders,
                    TotalOrderValue = totalOrderValue,
                    HighestOrderId = highestOrderId
                };
            });
            task.Start();
            
            return task;
        }
    }
}