using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TrainingShoeby04
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //TasksAsync();
            //Threads(); 
            //Tasks();
            //Linq();

            Exercise();

            while (true)
            {
            }
        }

        private static void Exercise()
        {
          
        }

        private static void Linq()
        {
            var orders = new List<Order>();
            var random = new Random();

            for (var i = 0; i < 100; i++)
            {
                var customerId = (int)Math.Floor((decimal) (i / 10));
                orders.Add(new Order()
                {
                    Id = i,
                    Customer = new Customer()
                    {
                        Id = customerId,
                        Name = $"Customer {customerId}"
                    },
                    Amount = random.Next(1, 1000)
                });
            }

            // Filtering
            var filtered = orders.Where(o => o.Amount > 100m);
            // Sorting
            var sorted = orders.OrderBy(o => o.Amount);
            // First 
            var order = orders.First(o => o.Id == 1);
            // Grouping
            var groupedByCustomer = orders.GroupBy(o => o.Customer);
            // Mapping
            var allAmounts = orders.Select(o => o.Amount);
            // Sum
            var sum = orders.Sum(o => o.Amount);
        }

        private static async Task TasksAsync()
        {
            var task = new Task<int>(() =>
            {
                var numbers = GetData();
                var total = 0;

                foreach (var number in numbers)
                {
                    total += number;
                }

                return total;
            });

            task.Start();

            var result = await task;

            Console.WriteLine($"Result: {result}");
        }

        private static void Tasks()
        {
            var task = new Task<int>(() =>
            {
                var numbers = GetData();
                var total = 0;

                foreach (var number in numbers)
                {
                    total += number;
                }

                return total;
            });
            task.ContinueWith(prevTask => Console.WriteLine($"Result: {prevTask.Result}"));

            task.Start();
        }

        private static void Threads()
        {
            var thread = new Thread(() =>
            {
                var numbers = GetData();
                var total = 0;

                foreach (var number in numbers)
                {
                    total += number;
                }

                Console.WriteLine(total);
            });

            thread.Start();

            // or using threadpool
            // ThreadPool.QueueUserWorkItem(thread => { });
        }

        private static int[] GetData()
        {
            var numbers = new int[1000];
            var random = new Random();
            for (var i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 100);
            }

            return numbers;
        }
    }
}