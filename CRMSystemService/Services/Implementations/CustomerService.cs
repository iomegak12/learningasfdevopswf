using CRMSystemService.Models;
using CRMSystemService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMSystemService.Services.Implementations
{
    public class CustomerService : ICustomerService
    {
        private static List<Customer> customers = default(List<Customer>);

        static CustomerService()
        {
            var random = new Random();

            customers = new List<Customer>
            {
                new Customer { CustomerId = 11, Name = "Northwind", Address = "Bangalore", CreditLimit = random.Next(10000, 50000), Status = true },
                new Customer { CustomerId = 12, Name = "Southwind", Address = "Bangalore", CreditLimit = random.Next(10000, 50000), Status = true },
                new Customer { CustomerId = 13, Name = "Westwind", Address = "Bangalore", CreditLimit = random.Next(10000, 50000), Status = true },
                new Customer { CustomerId = 14, Name = "Eastwind", Address = "Bangalore", CreditLimit = random.Next(10000, 50000), Status = true },
                new Customer { CustomerId = 15, Name = "Oxyrich", Address = "Bangalore", CreditLimit = random.Next(10000, 50000), Status = true },
                new Customer { CustomerId = 16, Name = "Adventureworks", Address = "Bangalore", CreditLimit = random.Next(10000, 50000), Status = true }
            };
        }

        public IEnumerable<Customer> GetCustomers(string customerName = null)
        {
            if (string.IsNullOrEmpty(customerName))
                return customers;

            return customers
                .Where(customer => customer.Name.Contains(customerName))
                .ToList();
        }
    }
}
