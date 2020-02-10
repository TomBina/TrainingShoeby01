using System;
using System.Collections.Generic;

namespace TrainingShoeby03
{
    class Program
    {
        static void Main(string[] args)
        {
            // IEnumerable<T>
            IEnumerable<Customer> customers = GetCustomers();

            var enumerator = customers.GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
            }
            
            // Dictionary
            var dictCustomers = new Dictionary<int, Customer>();
            
            foreach (var customer in customers)
            {
                dictCustomers[customer.Id] = customer;
            };

            // Hashset
            var hashCustomers = new HashSet<Customer>(customers);
            
            // Adding duplicate customer
            hashCustomers.Add(new Customer()
            {
                Id = 1,
                Name = "Customer 1"
            });
        }

        private static IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>();

            for (var i = 0; i < 100; i++)
            {
                var customer = new Customer()
                {
                    Id = i,
                    Name = $"Customer {i}"
                };
                
                customers.Add(customer);
            }
            return customers;
        }
    }
}