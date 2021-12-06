using Proxy.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Services
{
    public class CustomerService : ICustomerService
    {
        public Customer GetCustomer()
        {
            return new Customer()
            {
                Name = "A",
                Address = "ABC",
                AddressNo = "123"
            };
        }
    }
}
