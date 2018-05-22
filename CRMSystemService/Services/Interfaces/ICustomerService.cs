using CRMSystemService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMSystemService.Services.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers(string customerName = default(string));
    }
}
