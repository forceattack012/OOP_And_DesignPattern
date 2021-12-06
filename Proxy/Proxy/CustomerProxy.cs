using Proxy.Entities;
using Proxy.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Proxy
{
    public class CustomerProxy : ICustomerService
    {
        private CustomerService CustomerService = new CustomerService();
        public Customer GetCustomer()
        {
            return CustomerService.GetCustomer();
        }
    }
}
