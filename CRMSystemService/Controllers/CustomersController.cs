using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRMSystemService.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRMSystemService.Controllers
{
    [Produces("application/json")]
    [Route("api/Customers")]
    public class CustomersController : Controller
    {
        private const string INVALID_CUSTOMER_SERVICE = "Invalid Customer Service Dependency Specified!";
        private ICustomerService customerService = default(ICustomerService);

        public CustomersController(ICustomerService customerService)
        {
            if (customerService == default(ICustomerService))
                throw new ArgumentException(INVALID_CUSTOMER_SERVICE);

            this.customerService = customerService;
        }

        public IActionResult GetCustomers()
        {
            var customers = this.customerService.GetCustomers();

            return Ok(customers);
        }

        [HttpGet]
        [Route("search/{customerName}")]
        public IActionResult GetCustomers(string customerName)
        {
            var filteredCustomers = this.customerService.GetCustomers(customerName);

            return Ok(filteredCustomers);
        }
    }
}